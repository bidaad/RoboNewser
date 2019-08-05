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
    public partial class ShowExternalNews : System.Web.UI.Page
    {
        public string NewsUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //TextNewsList2.ShowLatestTextNews(100);

                int Code;
                string strCode = Request["Code"];
                Int32.TryParse(strCode, out Code);
                if (Code != 0)
                {


                    BOLNews NewsBOL = new BOLNews();
                    //PageTools1.ItemCode = Code;
                    //PageTools1.HCEntityCode = 1;
                    vNewsDetail CurNews = NewsBOL.GetNewsByCode(Code);
                    if (CurNews == null)
                    {
                        msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                        msgText.Text = "خبری با این کد یافت نشد.";
                        //pnlShowNews.Visible = false;
                        return;
                    }
                    Response.Redirect("~/N" + CurNews.Code + "_" + Tools.ReplaceSpaceWithUnderline(CurNews.Title) + ".html", false);
                    return;

                    NewsUrl = CurNews.Url;
                    //NewsBOL.UpdateViewCount(Code);
                    Page.Title = CurNews.Title;
                    string FullStory = Tools.FormatString(CurNews.Contents);

                    HtmlMeta metaTitle = (HtmlMeta)Page.Master.FindControl("title");
                    metaTitle.Attributes["content"] = CurNews.Title;
                    HtmlMeta metaURL = (HtmlMeta)Page.Master.FindControl("url");
                    metaURL.Attributes["content"] = "https://www.robonewser.com/news/" + CurNews.Code + ".htm";
                    HtmlMeta metaKeywords = (HtmlMeta)Page.Master.FindControl("keywords");
                    metaKeywords.Attributes["content"] = "";
                    HtmlMeta metaDescription = (HtmlMeta)Page.Master.FindControl("description");
                    string BriefStory = Tools.ShowBriefText(FullStory, 400);
                    ReqUtils Utils = new ReqUtils();
                    BriefStory = Utils.RemoveTags(BriefStory);
                    metaDescription.Attributes["content"] = BriefStory;

                    if (!string.IsNullOrEmpty(CurNews.PicName))
                    {
                        HtmlMeta metaImage = (HtmlMeta)Page.Master.FindControl("image");
                        metaImage.Attributes["content"] = "https://www.robonewser.com/Files/News/" + CurNews.PicName;
                    }


                    DateTimeMethods dtm = new DateTimeMethods();
                    //lblViewTitle.Text = CurNews.Title;
                    //lblViewNewsDate.Text = Tools.ChangeEnc(dtm.GetPersianLongDate((DateTime)CurNews.NewsDate));

                    //RelatedNews1.NewsCode = Code.ToString();
                    //KeywordList1.NewsCode = Code.ToString();

                    //lblViewCount.Text = NewsBOL.GetVisitCount(CurNews.Code);// Tools.ChangeEnc(CurNews.ViewCount.ToString());
                    //hplResourceName.Text = "جدید ترین خبرهای " + CurNews.Name;
                    //hplResourceName.NavigateUrl = "~/News/Resources/" + CurNews.ResouseSiteCode + ".htm";

                    //hplCatName.Text = "جدید ترین خبرهای " + CurNews.CatName;
                    //hplCatName.NavigateUrl = "~/News/NewsByCatCode.aspx?Code=" + CurNews.CatCode;
                    //hplRelatedNews.NavigateUrl = "~/News/RelatedNews.aspx?Code=" + CurNews.Code;


                    //hplViewResourceName.NavigateUrl = CurNews.Url;
                    //lblViewCode.Text = CurNews.Code.ToString();
                    //lblViewNewsTime.Text = Tools.ChangeEnc(CurNews.NewsDate.Value.Hour + ":" + CurNews.NewsDate.Value.Minute);

                    //ShareFaceBook.NavigateUrl = "~/ShareLink.aspx?Media=facebook&LinkUrl=" + Server.UrlEncode("https://www.robonewser.com/News/ShowNews.aspx?Code=" + CurNews.Code) + "&LinkTitle=" + Server.UrlEncode(CurNews.Title);
                    //ShareDigg.NavigateUrl = "~/ShareLink.aspx?Media=digg&LinkUrl=" + Server.UrlEncode("https://www.robonewser.com/News/ShowNews.aspx?Code=" + CurNews.Code) + "&LinkTitle=" + Server.UrlEncode(CurNews.Title);
                    //ShareTwitter.NavigateUrl = "~/ShareLink.aspx?Media=twitter&LinkUrl=" + Server.UrlEncode("https://www.robonewser.com/News/ShowNews.aspx?Code=" + CurNews.Code) + "&LinkTitle=" + Server.UrlEncode(CurNews.Title);



                    //rptResourceNewsList.DataSource = NewsBOL.GetLatestNewsByResourceCode((int)CurNews.ResouseSiteCode, 4, 1);
                    //rptResourceNewsList.DataBind();

                    //rptMostVisitedNews.DataSource = NewsBOL.GetMostVisitedTextNews(5, 1, 100);
                    //rptMostVisitedNews.DataBind();

                    //rptCatNews.DataSource = NewsBOL.GetNewsByCatCode((int)CurNews.CatCode, 4, 1);
                    //rptCatNews.DataBind();

                    //rptRelatedNews.DataSource = NewsBOL.GetRelatedNews((int)CurNews.Code, 4, 1);
                    //rptRelatedNews.DataBind();
                    //if (rptRelatedNews.Items.Count == 0)
                    //    pnlRelatedNews.Visible = false;

                    BOLNewsKeywords NewsKeywordsBOL = new BOLNewsKeywords(CurNews.Code);
                    //rptKeywords.DataSource = NewsKeywordsBOL.GetTopKeywords(CurNews.Code, 3);
                    //rptKeywords.DataBind();


                    if (Request.UserAgent == "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)" ||
                        Request.UserAgent == "Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)" ||
                        Request.UserAgent == "msnbot/2.0b (+http://search.msn.com/msnbot.htm)._" ||
                        Request.UserAgent == "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)" ||
                        Request.UserAgent == "Mozilla/5.0 (en-us) AppleWebKit/525.13 (KHTML, like Gecko; Google Web Preview) Version/3.1 Safari/525.13" ||
                        Request.UserAgent == "Mozilla/5.0 (compatible; MJ12bot/v1.3.3; http://www.majestic12.co.uk/bot.php?+)" ||
                        Request.UserAgent == "Mozilla/5.0 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)" ||
                        Request.UserAgent == "Mozilla/5.0 (compatible; MJ12bot/v1.4.3; http://www.majestic12.co.uk/bot.php?+)" ||
                        Request.UserAgent == "Sogou web spider/4.0(+http://www.sogou.com/docs/help/webmasters.htm#07)"
                        )
                    {
                    }
                    else
                    {
                        NewsBOL.IncrementVisitCount(Code);

                    }
                    if (FullStory.Length < 100)
                    {
                        Response.Redirect(CurNews.Url);
                        return;
                    }

                }
            }

            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "ShowExternalNews::Load");
            }
        }

        private string GenParagraph(string FullStory)
        {
            try
            {
                int DotPos = 0;
                int SavedDotPos = 0;
                string Result = "";
                int Index = 0;
                int ParagraphLen = 300;
                int LoopCounter = 0;
                while (Index < FullStory.Length && LoopCounter < 100)
                {
                    SavedDotPos = DotPos;
                    if (Index + ParagraphLen < FullStory.Length)
                        DotPos = FullStory.IndexOf(".", Index + ParagraphLen);
                    else
                        DotPos = 0;
                    if (DotPos > 0)
                    {
                        Result = Result + FullStory.Substring(Index, DotPos - Index) + ".<br />";
                        Index = DotPos + 1;
                    }
                    else
                    {
                        Result = Result + FullStory.Substring(SavedDotPos + 1, FullStory.Length - SavedDotPos - 1) + "<br />";
                        Index = FullStory.Length;
                    }
                    LoopCounter++;
                }
                return Result;
            }
            catch
            {
                return FullStory;
            }

        }
    }
}