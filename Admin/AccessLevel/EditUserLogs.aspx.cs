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
using System.Web.SessionState;


public partial class UserLogs_EditUserLogs : EditFormDetail<UserLogs>
{
    private string BaseID = "UserLogs";
    IBaseBOL<UserLogs> BOLClass;

    

    protected bool ValidateInputs()
    {
        return true;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        BOLClass = new BOLUserLogs((int)MasterCode);

        Label MasterPageTitle = (Label)Master.FindControl("lblTitle");
        MasterPageTitle.Text = BOLClass.PageLable;

        if (MasterCode == null)
            throw new Exception("No MasterCode Exception");
        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;
            cboHCEntityTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCEntities");
            cboHCUserActionCode.DataSource = new BOLHardCode().GetHCDataTable("HCUserActions");

            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }


    }
    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        if (!ValidateInputs())
            return;

        BOLUserLogs CurObj = new BOLUserLogs((int)MasterCode);
        if (!NewMode) CurObj.Code = Convert.ToInt32(Code);
        CurObj.UserCode = (int)MasterCode;

        CurObj.Code = (int)lkpCode.Code;
        CurObj.EntityCode = (int)lkpEntityCode.Code;
        CurObj.HCEntityTypeCode = (int)cboHCEntityTypeCode.Value;
        CurObj.HCUserActionCode = (int)cboHCUserActionCode.Value;
        CurObj.ActionDate = (DateTime)dteActionDate.SelectedDateChristian;



        CurObj.SaveChanges(NewMode);

        Tools.CloseWin(this, Master, BaseID, (string)ViewState["InstanceName"]);
    }
}
