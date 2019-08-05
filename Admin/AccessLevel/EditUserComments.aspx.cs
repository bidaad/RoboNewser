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


public partial class UserComments_EditUserComments : EditFormDetail<UserComments>
{

    protected void Page_Load(object sender, EventArgs e)
    {

        BOLClass = new BOLUserComments((int)MasterCode);

        MasterFieldName = "UserCode";
        Label MasterPageTitle = (Label)Master.FindControl("lblTitle");
        MasterPageTitle.Text = BOLClass.PageLable;

        if (MasterCode == null)
            throw new Exception("No MasterCode Exception");
        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {
            ViewState["InstanceName"] = Request["InstanceName"];
            cboHCSiteSectionCode.DataSource = new BOLHardCode().GetHCDataTable("HCSiteSections");

            if (!NewMode)
                LoadData((int)Code);
        }
    }

    protected void DoSave(object sender, EventArgs e)
    {
        try
        {
            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (ReturnCode != -1)
            {
                Tools.CloseWin(Page, Master, BaseID, ViewState["InstanceName"].ToString());
            }
        }
        catch
        {
        }
    }
}
