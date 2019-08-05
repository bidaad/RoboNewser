using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class News_RelatedNews : System.Web.UI.Page
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
                News CurNews = ((IBaseBOL<News>)NewsBOL).GetDetails(Code);
                if (CurNews != null)
                {
                    Page.Title = CurNews.Title;
                    hplTitle.Text = CurNews.Title;
                    //hplTitle.NavigateUrl = "~/News/" + Code + ".htm";
                    lblDate.Text = Tools.GetPrettyDate((DateTime)CurNews.NewsDate);
                    string FullStory = CurNews.Contents;
                    ReqUtils Utils = new ReqUtils();
                    FullStory = Utils.RemoveTags(FullStory);

                    lblContents.Text = Tools.ShowBriefText(FullStory, 300);
                    if (CurNews.PicName != null && CurNews.PicName != "")
                    {
                        imgPic.ImageUrl = CurNews.ImgUrl;
                        imgPic.CssClass = "img-fluid";
                    }
                    else
                        imgPic.Visible = false;
                    NewsList1.ShowRelatedNews(Code);
                }

            }
        }
        catch (Exception err)
        {
            //BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            //ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "RelatedNews::Load");
        }
    }
}
