using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RoboNewser.Code.DAL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                Tools.SetLink("lnkCanonical", "https://www.robonewser.com/" );

                Tools.SetMeta("keywords", "news, latest news, news today, headline news, breaking news, current news, top news, world news, online news, dail news, local news, new news, recent news");
                Tools.SetMeta("description", "RoboNewser is a news aggregator which presents a continuous, customizable flow of articles organized from thousands of publishers and magazines.");
                Tools.SetMeta("twitterdescription", "RoboNewser is a news aggregator which presents a continuous, customizable flow of articles organized from thousands of publishers and magazines.");
                Tools.SetMeta("ogtitle", "News Crawler");
                Tools.SetMeta("ogurl", "https://www.robonewser.com/" );
                Tools.SetMeta("twitterimagesrc", "");
                Tools.SetMeta("ogimage", "https://www.robonewser.com/images/logo.png");
                Tools.SetMeta("ogdescription", "RoboNewser is a news aggregator which presents a continuous, customizable flow of articles organized from thousands of publishers and magazines.");


                //BOLNews NewsBOL = new BOLNews();
                //rptHeadlines.DataSource = NewsBOL.GetHeadlines(5);
                //rptHeadlines.DataBind();

                WorldNews.ShowNewsByCatCode(8, 5);
                BusinessNews.ShowNewsByCatCode(2, 5);
                SportsNews.ShowNewsByCatCode(4, 5);
                TechnologyNews.ShowNewsByCatCode(5, 5);
                EntertainmentNews.ShowNewsByCatCode(7, 5);
                HealthNews.ShowNewsByCatCode(9, 5);
                ScienceNews.ShowNewsByCatCode(1, 5);

            }
            catch (Exception err)
            {

                //Response.Write(err.Message);
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "DefaultPage::Load");
            }

        }
    }

    protected int GetRandNum(int Rang)
    {
        Random RandomNumber = new Random();
        double dblRandRowIndex = RandomNumber.NextDouble() * Rang;
        int RandRowIndex = Convert.ToInt32(dblRandRowIndex);
        if (RandRowIndex > 0)
            RandRowIndex--;
        return RandRowIndex;

    }
   

    public string FormatEvent(string str)
    {
        try
        {
            return Tools.ConvertToUnicode(str.Replace("/services/dayhistory/", "").Replace("Default.asp", "").Replace("monthstrrefferer", "m").Replace("daystrrefferer", "d"));
        }
        catch (Exception err)
        {
            return "";
        }
    }
   

    protected void rptHeadlines_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        BOLNews NewsBOL = new BOLNews();
        if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            HyperLink hplRelatedNews = (HyperLink)e.Item.FindControl("hplRelatedNews");
            HiddenField hfRelatedNews = (HiddenField)e.Item.FindControl("hfRelatedNews");
            HiddenField hfPic = (HiddenField)e.Item.FindControl("hfPic");
            //int NewsCode = Convert.ToInt32(hplRelatedNews.Attributes["Code"]);
            int NewsCode = Convert.ToInt32(hfRelatedNews.Value);


            Image imgNews = (Image)e.Item.FindControl("imgNews");
            string PicName = hfPic.Value;
            if (string.IsNullOrEmpty(PicName))
                imgNews.Visible = false;


            int RelatedNewsCount = NewsBOL.GetRelatedNewsCount(NewsCode);
            if (RelatedNewsCount > 0)
            {
                hplRelatedNews.Text = "View more " + NewsBOL.GetRelatedNewsCount(NewsCode) + " news";
                hplRelatedNews.NavigateUrl = "~/News/RelatedNews.aspx?Code=" + NewsCode;
            }
            else
                hplRelatedNews.Visible = false;


        }
    }
}
