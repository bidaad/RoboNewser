using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCNewsFeedTool : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try{
            BOLHardCode HardCodeBOL = new BOLHardCode();

            ddlCats.DataSource = HardCodeBOL.GetList("HCResourceSitesCats");
            ddlCats.DataTextField = "Name";
            ddlCats.DataValueField = "Code";
            ddlCats.DataBind();
            ListItem li1 = new ListItem("همه گروه ها", "0");
            ddlCats.Items.Insert(0, li1);

            BOLResourceSites ResourceSitesBOL = new BOLResourceSites();
            ddlResources.DataSource = ResourceSitesBOL.GetActiveList();
            ddlResources.DataTextField = "Name";
            ddlResources.DataValueField = "Code";
            ddlResources.DataBind();
            ListItem li2 = new ListItem("همه منابع", "0");
            ddlResources.Items.Insert(0, li2);
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsFeedTools::Load");
            }

        }
    }
}