using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class News_NewsByResource : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCode = "";
        try
        {

            strCode = Request["Code"];
            int Code;
            Int32.TryParse(strCode, out Code);
            BOLResourceSites ResourceSitesBOL = new BOLResourceSites();
            ResourceSites CurResourceSite = ResourceSitesBOL.GetDetails(Code);
            if (CurResourceSite != null)
            {
                Response.Redirect("~/NR" + Code + "_" + Tools.ReplaceSpaceWithUnderline(CurResourceSite.Name) + ".html",false);
            }
            Page.Title = lblResourceTitle.Text = " آخرین خبرهای " + CurResourceSite.Name;

            NewsList1.ShowNewsByResourceCode(Code);

        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "NewsByResource::Load:Code=" + strCode);
        }
    }
}
