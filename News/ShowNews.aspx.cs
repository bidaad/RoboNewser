using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;
using System.Web.UI.HtmlControls;
using System.Data;

public partial class News_ShowNews : System.Web.UI.Page
{
    public string ItemURL;
    public string OriginalURL;
    public string strNewsCode;
    public string strFullStory;
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
                //PageTools1.ItemCode = Code;
                //PageTools1.HCEntityCode = 1;
                vNewsDetail CurNews = NewsBOL.GetNewsByCode(Code);
                if (CurNews == null)
                {
                    msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msgText.Text = "No news found.";
                    pnlShowNews.Visible = false;
                    return;
                }
                strNewsCode = CurNews.Code.ToString();
                ItemURL = "https://www.robonewser.com/" + "/News/" + CurNews.Code + ".html";
                Tools.SetLink("lnkCanonical", "https://www.robonewser.com/" + "/News/" + CurNews.Code +  ".html");

                Tools.SetMeta("keywords", CurNews.Title);
                Tools.SetMeta("description", CurNews.Title);
                Tools.SetMeta("twittercard", CurNews.Title);
                Tools.SetMeta("twittertitle", CurNews.Title);
                Tools.SetMeta("twitterdescription", CurNews.Title);
                Tools.SetMeta("ogtitle", CurNews.Title);
                Tools.SetMeta("ogurl", "https://www.robonewser.com/" + "/News/" + CurNews.Code + ".html");
                Tools.SetMeta("twitterimagesrc", "");
                Tools.SetMeta("ogimage", "https://static.robonewser.com/Files/News/" + CurNews.PicName);
                Tools.SetMeta("ogdescription", CurNews.Title);


                //NewsBOL.UpdateViewCount(Code);
                lblViewTitle.Text = CurNews.Title;
                Page.Title = CurNews.Title + " | RoboNewser";
                ReqUtils Utils = new ReqUtils();
                string FullStory = CurNews.Contents;
                FullStory = Utils.RemoveTags(FullStory);

                FullStory = Tools.FormatString(FullStory);
                FullStory = Tools.ShowBriefText(FullStory, 3000) + "...";

                FullStory = FullStory.Replace("<img ", "<img class=\"img-responsive\" ");
                strFullStory = FullStory;
                //if (FullStory.IndexOf("<br />") == -1)
                //{
                //    if(FullStory.IndexOf("<img ") == -1)
                //        lblViewContents.Text = GenParagraph(FullStory);
                //    else
                //        lblViewContents.Text = CorrectEnters(FullStory);
                //}
                //else
                //    lblViewContents.Text = FullStory;

                DataTable dtNewsImages = new Converter<NewsImages>().ToDataTable(NewsBOL.GetNewsImages(CurNews.Code));

                lblViewContents.Text = GenParagraph(FullStory, dtNewsImages);

                DateTimeMethods dtm = new DateTimeMethods();
                lblViewNewsDate.Text = ((DateTime)CurNews.NewsDate).ToString("D");
                if (!string.IsNullOrEmpty(CurNews.PicName))
                {
                    imgPicName.ImageUrl = CurNews.ImgUrl;// "https://www.robonewser.com/Files/News/" + CurNews.PicName;
                    imgPicName.ToolTip = CurNews.Title;
                }
                else
                    pnlPic.Visible = false;
                RelatedNews1.NewsCode = Code.ToString();
                KeywordList1.NewsCode = Code.ToString();

                lblViewCount.Text = NewsBOL.GetVisitCount(CurNews.Code);
                hplViewResourceName.Text = CurNews.Name;
                hplMoreFull.NavigateUrl = CurNews.Url;
                OriginalURL = CurNews.Url;

                    //hplViewResourceName.NavigateUrl = "https://www.robonewser.com/N" + CurNews.Code + "_" + Tools.ReplaceSpaceWithUnderline(CurNews.Title) + ".html";
                lblViewCode.Text = CurNews.Code.ToString();

                string strNewsHour = CurNews.NewsDate.Value.Hour.ToString();
                if (strNewsHour.Length == 1)
                    strNewsHour = "0" + strNewsHour;
                string strNewsMinute = CurNews.NewsDate.Value.Minute.ToString();
                if (strNewsMinute.Length == 1)
                    strNewsMinute = "0" + strNewsMinute;

                lblViewNewsTime.Text = strNewsHour + ":" + strNewsMinute;

                News3Col1.LoadPicNews();

                //rptImages.DataSource = NewsBOL.GetRelatedPicNews(CurNews.Code, 16);
                //rptImages.DataBind();

                //int CatCode = (int)CurNews.CatCode;
                //switch (CatCode)
                //{
                //    case 1:
                //        {
                //            lblCatTitle.Text = "Sience ";
                //            break;
                //        }
                //    case 2:
                //        {
                //            lblCatTitle.Text = "Business";
                //            break;
                //        }
                //    case 3:
                //        {
                //            lblCatTitle.Text = "Politics";
                //            break;
                //        }
                //    case 4:
                //        {
                //            lblCatTitle.Text = "Sports";
                //            break;
                //        }
                //    case 5:
                //        {
                //            lblCatTitle.Text = "Technology";
                //            break;
                //        }
                //    case 6:
                //        {
                //            lblCatTitle.Text = "Culture";
                //            break;
                //        }
                //    case 7:
                //        {
                //            lblCatTitle.Text = "Entertainment";
                //            break;
                //        }
                //    case 8:
                //        {
                //            lblCatTitle.Text = "World";
                //            break;
                //        }
                //    case 9:
                //        {
                //            lblCatTitle.Text = "Health";
                //            break;
                //        }
                //    default:
                //        break;
                //}
                //lblCatTitle.Text = "Latest " + lblCatTitle.Text + " news";

                //NewsList1.ShowPager = false;
                //NewsList1.ShowNewsByCatCode((int)CurNews.CatCode, null);


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
                //if (FullStory.Length < 100)
                //{
                //    Response.Redirect(CurNews.Url);
                //    return;
                //}

                //SmallAdsList1.ShowAdsByNewsCode(Code);


                //dtlRelatedPicNews.DataSource = NewsBOL.GetRelatedPicNews(Code);
                //dtlRelatedPicNews.DataBind();

                //ProductsDataContext pdc = new ProductsDataContext();
                //vRandPayeganGood CurRandBanner = pdc.vRandPayeganGoods.SingleOrDefault();
                //if (CurRandBanner != null)
                //{
                //    hplPBanner.ImageUrl = CurRandBanner.strHBannerURL.Trim();
                //    hplPBanner.NavigateUrl = "http://forosh.biz/Detail.aspx?q=" + CurRandBanner.strGoodCode.Trim() + "&s=9144";
                //}
                //CurRandBanner = pdc.vRandPayeganGoods.SingleOrDefault();
                //if (CurRandBanner != null)
                //{
                //    hplPBanner2.ImageUrl = CurRandBanner.strHBannerURL.Trim();
                //    hplPBanner2.NavigateUrl = "http://forosh.biz/Detail.aspx?q=" + CurRandBanner.strGoodCode.Trim() + "&s=9144";
                //}
                

            }
        }
        catch (Exception err)
        {
           // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
           // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "ShowNews::Load");
        }
    }

    private string CorrectEnters(string FullStory)
    {
        int Counter = 0;
        while (FullStory.IndexOf("\r\r") > -1 && Counter < 100)
        {
            FullStory = FullStory.Replace("\r\r", "\r");
            Counter++;
        }
        FullStory = FullStory.Replace("\r", "<br />");
        return FullStory;
    }

    private string GenParagraph(string FullStory, DataTable dtNewsImages)
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
                string ExtraImage = "";
                SavedDotPos = DotPos;
                if (Index + ParagraphLen < FullStory.Length)
                    DotPos = FullStory.IndexOf(".", Index + ParagraphLen);
                else
                    DotPos = 0;
                if (DotPos > 0)
                {
                    if (dtNewsImages.Rows.Count > LoopCounter)
                        ExtraImage = "<div><img src=\"" + dtNewsImages.Rows[LoopCounter]["ImgUrl"].ToString() + "\" class=\"img-fluid\" /></div>";
                    else
                        ExtraImage = "";
                    Result = Result + FullStory.Substring(Index, DotPos - Index) + "." + ExtraImage + "</p><p>";
                    Index = DotPos + 1;
                }
                else
                {
                    Result = Result + FullStory.Substring(SavedDotPos, FullStory.Length - SavedDotPos - 1) + "</p><p>";
                    Index = FullStory.Length;
                }
                LoopCounter++;
            }

            Result = "<p>" + Result + "</p>";

            if (dtNewsImages.Rows.Count > LoopCounter)
            {
                for (int i = LoopCounter; i < dtNewsImages.Rows.Count; i++)
                {
                    Result = Result + "<div class=\"marginer-10\"><img src=\"" + dtNewsImages.Rows[LoopCounter]["ImgUrl"].ToString() + "\" class=\"img-fluid\" /></div>";
                }
            }

            return Result;
        }
        catch
        {
            return FullStory;
        }

    }
}
