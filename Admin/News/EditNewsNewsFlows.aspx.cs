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
using System.Web.SessionState;
using RoboNewser.Code.DAL;


public partial class NewsNewsFlows_EditNewsNewsFlows : EditFormDetail<NewsNewsFlows>
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BOLClass = new BOLNewsNewsFlows((int)MasterCode);

        MasterFieldName = "NewsCode";
        Label MasterPageTitle = (Label)Master.FindControl("lblTitle");
        MasterPageTitle.Text = BOLClass.PageLable;

        if (MasterCode == null)
            throw new Exception("No MasterCode Exception");
        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            ViewState["InstanceName"] = Request["InstanceName"];
            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }
    }

    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (ReturnCode != -1)
            {
                if (ViewState["InstanceName"]!=null)Tools.CloseWin(Page, Master, BaseID, ViewState["InstanceName"].ToString());
            }
        }
        catch
        {
        }
    }
}
