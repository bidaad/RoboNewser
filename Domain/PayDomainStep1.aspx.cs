using Parsetv91._1.Code.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Domain
{
    public partial class PayDomainStep1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msg.Text = "";
            if (!Page.IsPostBack)
            {
            }

        }
        protected void btnPayCost_Click(object sender, ImageClickEventArgs e)
        {
            string Name = txtName.Text;
            string Email = txtEmail.Text;

            if (string.IsNullOrEmpty(Name))
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msg.Text = "لطفا نام را وارد کنید";
                return;
            }
            if (string.IsNullOrEmpty(Email))
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msg.Text = "لطفا ایمیل را وارد کنید";
                return;
            }


            string AfterBuyUrl = "http://www.parset.com/Domain/PayDomainStep2.aspx";
            try
            {

                if (Session["DomainPrice"] == null)
                    return;
                //lblDomainCost.Text = Tools.FormatCurrency2(Tools.ChangeEnc(100));
                object strAddVal = Convert.ToInt32(Session["DomainPrice"]);
                if (strAddVal == null)
                {
                    msg.Text = "مبلغ معتبر نيست";
                    msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    return;
                }

                int TotalCost;
                Int32.TryParse(strAddVal.ToString(), out TotalCost);
                if (TotalCost == 0)
                {
                    msg.Text = "مبلغ معتبر نيست";
                    msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    return;
                }

                string UserIP = "";

                //int BankCode = Convert.ToInt32(ddlBankCode.SelectedValue);
                int BankCode = 2;
                BOLUserTransactions UserTransactionsBOL = new BOLUserTransactions(1);
                int UserTransactionCode = UserTransactionsBOL.Insert(null, DateTime.Now, 1, 3, UserIP, TotalCost, 5, BankCode, Name, Email, "");
                if (UserTransactionCode != -1)
                {
                    if (BankCode == 1)//Saman
                    {
                        long OrderId = Convert.ToInt64(UserTransactionCode);

                        Literal ltrMP = (Literal)this.Master.FindControl("ltrMP");
                        ltrMP.Text = @"<form id=""formsaman"" method=post action=""https://acquirer.sb24.com/CardServices/controller"">
				                    <input type=""hidden"" name=""MID"" id=""MID"" value=""" + ConfigurationManager.AppSettings["SamanMerchantID"] + @""" />
				                    <input type=""hidden"" name=""ResNum"" id=""ResNum"" value=""" + OrderId + @""" />
				                    <input type=""hidden"" name=""Amount"" id=""Amount"" value=""" + TotalCost + @""" />
				                    <input type=""hidden"" name=""RedirectURL"" id=""RedirectURL"" value=""" + AfterBuyUrl + @""" />
    		                       </form>
			                       <script type=""text/javascript"">document.getElementById(""formsaman"").submit();</script>";
                        return;
                    }
                    #region Parsian
                    else if (BankCode == 2) // Parsian Bank
                    {
                        long Authority = 0;
                        byte Status = 1;
                        Parset.com.pecco24.www.EShopService ParsianService = new Parset.com.pecco24.www.EShopService();
                        ParsianService.PinPaymentRequest(ConfigurationManager.AppSettings["ParsianPin"], TotalCost, UserTransactionCode, AfterBuyUrl, ref Authority, ref Status);
                        if (Status == 0)
                        {
                            BOLUserBuys UserBuysBOL = new BOLUserBuys(1);
                            int UpdateResult = UserBuysBOL.UpdateAuthority(UserTransactionCode, Authority.ToString());
                            if (UpdateResult == 0)
                            {
                                Response.Redirect("https://www.pecco24.com/pecpaymentgateway/?au=" + Authority);
                                return;
                            }
                            else
                            {
                                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                                msg.Text = "خطا ذخیره داده های تراکنش بانک پارسیان" + " کد خطا: " + Status;
                                return;
                            }
                        }
                        else
                        {
                            msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                            msg.Text = "خطا در برقراری ارتباط با بانک پارسیان" + " کد خطا: " + Status;
                            return;
                        }
                    }
                    #endregion

                }
                else
                {
                    msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msg.Text = "خطا در ثبت تراکنش";
                    return;
                }

            }
            catch (Exception err)
            {
                msg.Text = "خطا در برقراری ارتباط با سرور بانک " + err.Message;
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                return;
            }

        }

        protected bool DomainIsAvailable(string DomainName)
        {
            try
            {
                DomainName = DomainName.Trim();
                DomainName = DomainName.Replace("www.", "");

                string WhoisServer = "whois.geektools.com";
                TcpClient objTCPC = new TcpClient(WhoisServer, 43);
                string strDomain = DomainName + "\r\n";
                byte[] arrDomain = Encoding.ASCII.GetBytes(strDomain);

                Stream objStream = objTCPC.GetStream();
                objStream.Write(arrDomain, 0, strDomain.Length);
                StreamReader objSR = new StreamReader(objTCPC.GetStream(),
                Encoding.ASCII);
                string strResponse = objSR.ReadToEnd();

                objTCPC.Close();
                if (strResponse.IndexOf("CRSNIC has no information for that domain") != -1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        protected void btnCheckDomain_Click(object sender, EventArgs e)
        {
            if (!RadCaptcha1.IsValid)
            {
                msg.Text = "کد امنیتی اشتباه است";
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                return;
            }

            string Domain = txtDomainName.Text;
            if (DomainIsAvailable(Domain))
            {
                string Extention = GetExtension(Domain);
                
                DomainPricesDataContext dc = new DomainPricesDataContext();
                DomainPrices CurExtention = dc.DomainPrices.SingleOrDefault(p => p.Extention.Equals(Extention));
                if (CurExtention != null)
                {
                    Session["DomainPrice"] = CurExtention.Price;
                    Session["DomainName"] = Domain;
                    lblDomainCost.Text = Tools.FormatCurrency2(CurExtention.Price / 10);
                    pnlPay.Visible = true;
                }
                else
                {
                    msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msg.Text = "امکان ثبت این دامین وجود ندارد";
                    pnlPay.Visible = false;
                }
            }
            else
            {
                pnlPay.Visible = false;
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msg.Text = "دامین قبلا ثبت شده است";
                return;
            }
        }

        private string GetExtension(string Domain)
        {
            int LastDotIndex = Domain.LastIndexOf(".");
            string Extention = Domain.Substring(LastDotIndex + 1, Domain.Length - LastDotIndex - 1);
            Extention = Extention.ToUpper();
            return Extention;
        }
    }
}