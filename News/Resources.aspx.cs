using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News_Resources : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try{
        BOLResourceSites ResourceSitesBOL = new BOLResourceSites();
        dtlResources.DataSource = ResourceSitesBOL.GetActiveList();
        dtlResources.DataBind();
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "Resources::Load");
        }

//        TextNewsList1.ShowLatestTextNews(100);

    }
}