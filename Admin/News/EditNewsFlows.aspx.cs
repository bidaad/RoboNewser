using RoboNewser.Code.DAL;
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


public partial class NewsFlows_EditNewsFlows : EditForm<NewsFlows>
{

    protected bool ValidateInputs()
    {
        return true;
    }


    protected void Page_Load(object sender, EventArgs e)
    {

        string Tab1Click = "BrowseObj1.ShowDetail('NewsFlowsKeywords', '" + Code + "', true,'BrowseObj1')";
        if(!NewMode)
            Tools.SetClientScript(Page, "NewsFlowsKeywords", Tab1Click);
        RadMultiPage1.SelectedIndex = 0;
        tsNews.Tabs[0].Selected = true;

        BOLClass = new BOLNewsFlows();

        hplSysName.Text = BOLClass.PageLable;
        hplSysName.NavigateUrl = "";//"~/" + BaseID;


        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            ShowDetails();
            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;

            cboHCShowTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCShowTypes");
            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }


    }

    private void ShowDetails()
    {
        Tools.SetClientScript(Page, "NewsFlowsKeywords", "BrowseObj1.ShowDetail('NewsFlowsKeywords', '" + Code + "', true,'BrowseObj1')");

        string Tab2Click = "BrowseObj2.ShowDetail('NewsNewsFlows', '" + Code + "', true,'BrowseObj2')";
        Tab2.Attributes.Add("onclick", Tab2Click);


        #region HandleSelectedTab
        if (Request["SelectedTab"] != null)
        {
            RadMultiPage1.SelectedIndex = Int32.Parse(Request["SelectedTab"]);
            SelectedTabIndex = Int32.Parse(Request["SelectedTab"]);
            switch (Int32.Parse(Request["SelectedTab"]))
            {
                case 0:
                    RadMultiPage1.SelectedIndex = 0;
                    tsNews.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
            tsNews.Tabs[Int32.Parse(Request["SelectedTab"])].Selected = true;
        }
        else
        {
            RadMultiPage1.SelectedIndex = 0;
            tsNews.Tabs[0].Selected = true;
        }
        #endregion
    }
    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            int NewsCode = SaveControls("");
            if (NewMode && NewsCode != -1)
            {
                NewMode = false;
                Code = NewsCode;
                ShowDetails();
            }
            else
            {
                if (NewsCode != -1)
                    GoToList(null, null);
            }
        }
        catch
        {
        }
    }

}
