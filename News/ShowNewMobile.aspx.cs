using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace RoboNewser.News
{
    public partial class ShowNewMobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                int Code;
                string strCode = Request["Code"];
                Int32.TryParse(strCode, out Code);
                if (Code != 0)
                {

                    BOLNews NewsBOL = new BOLNews();
                    vNewsDetail CurNews = NewsBOL.GetNewsByCode(Code);
                    //NewsBOL.UpdateViewCount(Code);
                    lblViewTitle.Text = CurNews.Title;
                    Page.Title = CurNews.Title;
                    string FullStory = Tools.FormatString(CurNews.Contents);
                    if (FullStory.IndexOf("<br />") == -1)
                        lblViewContents.Text = GenParagraph(FullStory);
                    else
                        lblViewContents.Text = FullStory;

                    DateTimeMethods dtm = new DateTimeMethods();
                    lblViewNewsDate.Text = Tools.ChangeEnc(dtm.GetPersianLongDate((DateTime)CurNews.NewsDate));
                    if (!string.IsNullOrEmpty(CurNews.PicName))
                        imgPicName.ImageUrl = "https://www.robonewser.com/Files/News/" + CurNews.PicName;
                    else
                        pnlPic.Visible = false;

                    //lblViewCount.Text = Tools.ChangeEnc( CurNews.ViewCount.ToString());
                    lblViewCount.Text = NewsBOL.GetVisitCount(CurNews.Code);// Tools.ChangeEnc(CurNews.ViewCount.ToString());
                    hplViewResourceName.Text = CurNews.Name;
                    hplViewResourceName.NavigateUrl = CurNews.Url;
                    lblViewCode.Text = CurNews.Code.ToString();
                    lblViewNewsTime.Text = Tools.ChangeEnc(CurNews.NewsDate.Value.Hour + ":" + CurNews.NewsDate.Value.Minute);


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

                }
            }
            catch
            {
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