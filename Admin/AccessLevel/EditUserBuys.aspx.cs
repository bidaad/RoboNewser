using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RoboNewser.Code.DAL;


public partial class UserBuys_EditUserBuys : Page//EditFormDetail<UserBuys>
{
    public int Code;
    protected void Page_Load(object sender, EventArgs e)
    {
        Code = Convert.ToInt32( Request["Code"]);
        //BOLClass = new BOLUserBuys(1);

        //MasterFieldName = "TransactionCode";
        //Label MasterPageTitle = (Label)Master.FindControl("lblTitle");
        //MasterPageTitle.Text = BOLClass.PageLable;

        //if (MasterCode == null)
        //    throw new Exception("No MasterCode Exception");
        //if ((Code == null) && (!NewMode)) return;
        //if (!Page.IsPostBack)
        //{
        //    ViewState["InstanceName"] = Request["InstanceName"];
        Tools.SetClientScript(this, "ActiveTab1", "BrowseObj1.ShowDetail('UserBuyProducts', '" + Code + "',true,'BrowseObj1')");
        if (!Page.IsPostBack)
        {
            cboHCTransStatusCode.DataSource = new BOLHardCode().GetHCDataTable("HCUserTransStatuses");
            cboChargeTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCChargeTypes");
            cboHCTransStatusCode.DataSource = new BOLHardCode().GetHCDataTable("HCUserTransStatuses");
            cboBankCode.DataSource = new BOLHardCode().GetHCDataTable("HCBanks");

            //LoadData((int)Code);
            BOLUserBuys UserBuysBOL = new BOLUserBuys(1);
            UserBuys CurUserBuy = ((IBaseBOL<UserBuys>)UserBuysBOL).GetDetails((int)Code);
            
            BOLUserTransactions UserTransactionsBOL = new BOLUserTransactions(1);
            UserTransactions CurTransaction = ((IBaseBOL<UserTransactions>)UserTransactionsBOL).GetDetails(CurUserBuy.TransactionCode);
            if(CurTransaction != null)
            {
                txtAuthority.Text = CurTransaction.Authority;
                txtBankName.Text = CurTransaction.BankName;
                txtBankState.Text = CurTransaction.BankState;
                txtComment.Text = CurTransaction.Comment;
                txtDigitalSignature.Text = CurTransaction.DigitalSignature;
                txtFishNo.Text = CurTransaction.FishNo;
                txtUserIP.Text = CurTransaction.UserIP;

                if(CurTransaction.BankCode != null)
                    cboBankCode.SelectedValue = CurTransaction.BankCode.ToString();
                if (CurTransaction.HCPayMethodCode != null)
                    cboChargeTypeCode.SelectedValue = CurTransaction.HCPayMethodCode.ToString();
                cboHCTransStatusCode.SelectedValue = CurTransaction.HCTransStatusCode.ToString();

                if(CurTransaction.ChargeDate != null)
                    dteChargeDate.SelectedDateChristian = CurTransaction.ChargeDate;
                if(CurTransaction.PayDate != null)
                    dtePayDate.SelectedDateChristian = CurTransaction.PayDate;

                BOLUserBuyProducts UserBuyProductsBOL = new BOLUserBuyProducts((int)Code);
                DataTable dtBuyProducts = ((IBaseBOL<UserBuyProducts>)UserBuyProductsBOL).GetDataSource(new SearchFilterCollection(), "Code", 100, 1);
                int TotalAmount = 0;
                for (int i = 0; i < dtBuyProducts.Rows.Count; i++)
                {
                    int Amount = Convert.ToInt32(dtBuyProducts.Rows[i]["Amount"]);
                    int Quantity = Convert.ToInt32(dtBuyProducts.Rows[i]["Quantity"]);
                    TotalAmount += (Amount * Quantity);
                }
                lblTotalAmount.Text = Tools.FormatCurrency( TotalAmount.ToString());

            }


            if (CurTransaction.UserCode != null)
                pnlGuestUser.Visible = false;
            else
            {
                txtFirstName.Text = CurUserBuy.FirstName;
                txtLastName.Text = CurUserBuy.LastName;
                txtEmail.Text = CurUserBuy.Email;
                txtPhone.Text = CurUserBuy.Phone;
            }


        }
    }

    protected void DoSave(object sender, EventArgs e)
    {
        try
        {
            BOLUserBuys UserBuysBOL = new BOLUserBuys(1);
            UserBuys CurUserBuy = ((IBaseBOL<UserBuys>)UserBuysBOL).GetDetails((int)Code);

            BOLUserTransactions UserTransactionsBOL = new BOLUserTransactions(1);
            UserTransactions CurTransaction = ((IBaseBOL<UserTransactions>)UserTransactionsBOL).GetDetails(CurUserBuy.TransactionCode);

            string Authority = txtAuthority.Text;
            string BankName = txtBankName.Text;
            string BankState = txtBankState.Text;
            string Comment = txtComment.Text;
            string DigitalSignature = txtDigitalSignature.Text;
            string FishNo = txtFishNo.Text;
            string UserIP = txtUserIP.Text;
            int? NullVal = null;

            int? BankCode = cboBankCode.SelectedValue == "" ? NullVal : Convert.ToInt32(cboBankCode.SelectedValue);
            int? ChargeTypeCode = cboChargeTypeCode.SelectedValue == "" ? NullVal : Convert.ToInt32(cboChargeTypeCode.SelectedValue);
            int? HCTransStatusCode = cboHCTransStatusCode.SelectedValue == "" ? NullVal : Convert.ToInt32(cboHCTransStatusCode.SelectedValue);

            DateTime? ChargeDate = dteChargeDate.SelectedDateChristian;
            DateTime? PayDate = dtePayDate.SelectedDateChristian;

            UserTransactionsBOL.UpdateTrans(CurUserBuy.TransactionCode, Authority, BankName, BankState, Comment, DigitalSignature,
                FishNo, UserIP, BankCode, ChargeTypeCode, HCTransStatusCode, ChargeDate, PayDate);

            //Tools.CloseWin(Page, Master, BaseID, ViewState["InstanceName"].ToString());
        }
        catch
        {
        }
    }
    protected void btnBackToList_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Main/?BaseID=" + Request["BaseID"]);
    }
}
