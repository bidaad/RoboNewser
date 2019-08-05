using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using RoboNewser.Code.DAL;

public partial class News_NewsByKeyword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            int KeywordCode = Convert.ToInt32(Request["Code"]);
            BOLNews NewsBOL = new BOLNews();

            BOLKeywords KeywordsBOL = new BOLKeywords();
            Keywords CurKeyword = ((IBaseBOL<Keywords>)KeywordsBOL).GetDetails(KeywordCode);
            if (CurKeyword != null)
            {
                Response.Redirect("~/NK" + CurKeyword.Code + "_" + Tools.ReplaceSpaceWithUnderline(CurKeyword.Name) + ".html", false);
                return;

                NewsList1.ShowNewsByKeywordCode(KeywordCode);

                lblTitle.Text = " خبرهای " + CurKeyword.Name;
                Page.Title = "خبرهای " + CurKeyword.Name;
                HtmlMeta metadesc = (HtmlMeta)Page.Master.FindControl("description");
                metadesc.Attributes["content"] = CurKeyword.Name;
            }
            else
                Response.Redirect("~/", false);
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "NewsByKeywordCode::Load");
            Response.Redirect("~/", false);
        }
    }
}
