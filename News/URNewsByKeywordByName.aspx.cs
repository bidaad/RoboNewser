using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.News
{
    public partial class URNewsByKeywordByName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                string Keyword = Request["Keyword"];
                BOLNews NewsBOL = new BOLNews();

                Keyword = Keyword.Replace("_", " ");
                BOLKeywords KeywordsBOL = new BOLKeywords();
                Keywords CurKeyword = KeywordsBOL.GetDataByKeyword(Keyword);
                if (CurKeyword != null)
                {
                    lblTitle.Text = CurKeyword.Name ;
                    Page.Title = CurKeyword.Name + " | RoboNewser";

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


                    NewsList1.ShowNewsByKeywordCode(CurKeyword.Code);

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