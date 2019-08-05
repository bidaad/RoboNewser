using Parsetv91._1.Code.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Domain
{
    public partial class PayDomainStep2 : System.Web.UI.Page
    {

        public string BMITransactionKey = ConfigurationManager.AppSettings["BMITransactionKey"];
        public string CardAcqID = ConfigurationManager.AppSettings["BMIMerchantID"];
        public string TerminalId = ConfigurationManager.AppSettings["BMITerminalID"];
        public string ReturnURL = ConfigurationManager.AppSettings["BMIReturnURL"];
        public string ServiceURL = ConfigurationManager.AppSettings["BMIServiceURL"];

        string strOrderId = "";
        string strResNum;// Factor No
        string strRefNum;//DigitalSignature
        string strState;


        protected void Page_Load(object sender, EventArgs e)
        {


            int BankCode = 0;
            HtmlMeta metadesc = (HtmlMeta)Page.Master.FindControl("Refresh");
            metadesc.Attributes["content"] = "100000";

            string strFP = HttpContext.Current.Request.Form["FP"];
            strOrderId = HttpContext.Current.Request.Form["OrderId"];
            string strTimeStamp = HttpContext.Current.Request.Form["TimeStamp"];

            //Response.Write("strFP=" + strFP + "<BR>");
            //Response.Write("strOrderId=" + strOrderId + "<BR>");
            //Response.Write("strTimeStamp=" + strTimeStamp + "<BR>");

            #region Saman Parameters
            string strResNum = Request["ResNum"];// Factor No
            string strRefNum = Request["RefNum"];//DigitalSignature
            string strState = Request["State"];
            #endregion


            #region Parsian Parameters
            string strAuthority = Request["au"];
            string strStatus = Request["rs"];
            #endregion

            #region Parsian
            if (strAuthority != "" && strAuthority != null) //Parsian Bank
            {
                BankCode = 2;
                BOLUserTransactions UserTransactionsBOL = new BOLUserTransactions(1);
                vUserTransactions CurTransaction = UserTransactionsBOL.GetTransByAuthority(strAuthority);

                if (CurTransaction != null)
                {
                    if (CurTransaction.HCTransStatusCode == 2)
                    {
                        msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Warning;
                        msg.Text = "این تراکنش قبلا تایید شده است.";
                        return;
                    }
                    byte Status = 1;
                    Parset.com.pecco24.www.EShopService ParsianService = new Parset.com.pecco24.www.EShopService();
                    ParsianService.PinPaymentEnquiry(ConfigurationManager.AppSettings["ParsianPin"], Convert.ToInt64(strAuthority), ref Status);
                    if (Status == 0)
                    {
                        UserTransactionsBOL.ChangeStatus(CurTransaction.Code, 2);
                        //int UserTransactionCode = UserTransactionsBOL.Insert(null, DateTime.Now, 2, 3, "", -1 * CurTransaction.Amount, 4, BankCode);

                        msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                        msg.Text = "پرداخت با موفقیت انجام شد.";

                        ltrMessage.Text = "پرداخت مبلغ " + CurTransaction.Amount + " ریال بابت دامنه  " + Session["DomainName"].ToString() + " تایید میشود. دامین مربوطه ظرف یک روز کاری ثبت و مشخصات آن برای شما ارسال میگردد. ";

                        string Name = CurTransaction.Name;
                        string Email = CurTransaction.GuestEmail;

                        string MailBody = "<div style=\"font-family:Tahoma;direction:rtl;\">" + Name + "<BR>";
                        MailBody += "پرداخت مبلغ " + CurTransaction.Amount + " ریال بابت دامنه  " + Session["DomainName"].ToString() + " تایید میشود. دامین مربوطه ظرف یک روز کاری ثبت و مشخصات آن برای شما ارسال میگردد. <br />" + "شماره تراکنش:" + CurTransaction.Code + "</div>";
                        BOLEmails EmailsBOL = new BOLEmails();
                        EmailsBOL.Insert(Email, 6, "");

                        Tools tools = new Tools();
                        bool SendResult = tools.SendEmail(MailBody, "تایید پرداخت مبلغ دامنه", "DomainReg@parset.com", Email, "bidaad@gmail.com", "");

                        return;
                    }
                    else
                    {
                        msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                        msg.Text = "مشترک گرامی، پرداخت الکترونیک شما با موفقیت انجام نشد، این مشکل معمولاً در مواردی رخ می‌دهد که شما در صفحه بانک پرداخت را تایید نمی‌کنید، در حساب خود به اندازه کافی موجودی ندارید، مشکلی در برقرار ارتباط با بانک بوجود آمده و ... در هر صورت جای نگرانی وجود ندارد، چرا که هیچ وجهی از حساب شما کسر نشده است.. کد خطا:" + strStatus;
                    }

                }
                else
                {
                    msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msg.Text = "مشترک گرامی، پرداخت الکترونیک شما با موفقیت انجام نشد، این مشکل معمولاً در مواردی رخ می‌دهد که شما در صفحه بانک پرداخت را تایید نمی‌کنید، در حساب خود به اندازه کافی موجودی ندارید، مشکلی در برقرار ارتباط با بانک بوجود آمده و ... در هر صورت جای نگرانی وجود ندارد، چرا که هیچ وجهی از حساب شما کسر نشده است.. کد خطا:" + strStatus;
                }
            }
            #endregion

            #region Saman
            if (strResNum != "" && strResNum != null)// Saman Bank
            {
                long OrderId = Convert.ToInt64(strOrderId);
                //CheckRequestStatus(OrderId);
            }
            #endregion



        }
    }
}