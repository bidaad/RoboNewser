using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using RoboNewser.Code.DAL;

namespace RoboNewser.News
{
    public partial class URNewsByKeyword : System.Web.UI.Page
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
                    lblTitle.Text = CurKeyword.Name + " news";
                    Page.Title = CurKeyword.Name + " news";

                    Tools.SetLink("lnkCanonical", "https://www.robonewser.com/" + "/K/" + Tools.ReplaceSpaceWithUnderline(CurKeyword.Name) + ".html");

                    Tools.SetMeta("keywords", CurKeyword.Name);
                    Tools.SetMeta("description", CurKeyword.Name);
                    Tools.SetMeta("twittercard", CurKeyword.Name);
                    Tools.SetMeta("twittertitle", CurKeyword.Name);
                    Tools.SetMeta("twitterdescription", CurKeyword.Name);
                    Tools.SetMeta("ogtitle", CurKeyword.Name);
                    Tools.SetMeta("ogurl", "https://www.robonewser.com/" + "/K/" + Tools.ReplaceSpaceWithUnderline(CurKeyword.Name) + ".html");
                    Tools.SetMeta("twitterimagesrc", "");
                    Tools.SetMeta("ogimage", "");
                    Tools.SetMeta("ogdescription", CurKeyword.Name);


                    NewsList1.ShowNewsByKeywordCode(KeywordCode);

                    dtlOtherKeywords.DataSource = KeywordsBOL.GetKeywordsStartsWith(CurKeyword.Name);
                    dtlOtherKeywords.DataBind();
                }
                else
                {
                    Response.Redirect("~/", false);
                }
            }
            catch (Exception err)
            {
                Response.Redirect("~/", false);
                //string MailBody = "Page: " + Request.FilePath + " Exception: " + err.Message;
                //Tools tools = new Tools();
                //bool SendResult = tools.SendEmail(MailBody, "پارست ::Error ", "bidaad@gmail.com", "", "", "");
            }
        }
    }
}