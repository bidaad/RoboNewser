using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.News
{
    public partial class KeywordPics : System.Web.UI.Page
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
                    lblTitle.Text = CurKeyword.Name;
                    Page.Title = CurKeyword.Name + " pictures | RoboNewser";

                    Tools.SetLink("lnkCanonical", "https://www.robonewser.com/" + "/KPics/" + Tools.ReplaceSpaceWithUnderline(CurKeyword.Name) + ".html");

                    Tools.SetMeta("keywords", CurKeyword.Name + " pictures");
                    Tools.SetMeta("description", CurKeyword.Name + " pictures");
                    Tools.SetMeta("twittercard", CurKeyword.Name + " pictures");
                    Tools.SetMeta("twittertitle", CurKeyword.Name + " pictures");
                    Tools.SetMeta("twitterdescription", CurKeyword.Name + " pictures");
                    Tools.SetMeta("ogtitle", CurKeyword.Name + " pictures");
                    Tools.SetMeta("ogurl", "https://www.robonewser.com/" + "/KPics/" + Tools.ReplaceSpaceWithUnderline(CurKeyword.Name) + ".html");
                    Tools.SetMeta("twitterimagesrc", "");
                    Tools.SetMeta("ogimage", "");
                    Tools.SetMeta("ogdescription", CurKeyword.Name + " pictures");

                    rptPics.DataSource = NewsBOL.GetPicNewsByKeywordCode(CurKeyword.Code);
                    rptPics.DataBind();

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