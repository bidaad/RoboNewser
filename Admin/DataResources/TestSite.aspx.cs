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
using System.Net;

public partial class DataResources_TestSite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str1 = @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

        <html xmlns=""http://www.w3.org/1999/xhtml"">
        <head><title>
	        Test site
        </title></head>
        <body><div style=""width:600px;"">
        ";
        string str2 = "</div></body></html>";
        string Code = Request["Code"];
        //IBaseBOL<ResourceSites> ResourceSitesBOL = new BOLResourceSites();
        //ResourceSites ActiveSiteList = ResourceSitesBOL.GetDetails(Convert.ToInt32(Code));
        //int SiteCode = ActiveSiteList.Code;
        int LimitCount = 10;

        Response.Write(str1);
        GetSingleSite(Convert.ToInt32(Code), LimitCount);
        Response.Write(str2);


    }

    void ListNews(int privateSiteCode, string privateNewsUrl, string privateNewsTitle, string privateREDetail, string privateREImage, string privateREVideo, int Count, string LinkDomainName, int EncodingTypeCode)
    {
        ReqUtils gn = new ReqUtils();
        string NewsContentHtml = "";
        string FullStory = "";
        string ImageSource = "";
        string VideoSource = "";
        string TextTitle = "";
        string NewsCode = "";

        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        if (EncodingTypeCode != 1)
        {
            IBaseBOL<DataTable> BolHardCode = new BOLHardCode();
            BolHardCode.QueryObjName = "HCEncodingTypes";
            DataTable dt = BolHardCode.GetDetails(EncodingTypeCode);
            enc = System.Text.Encoding.GetEncoding(dt.Rows[0]["Description"].ToString());
        }
        privateNewsUrl = privateNewsUrl.Replace("//", "/");
        privateNewsUrl = privateNewsUrl.Replace("http:/", "http://");
        privateNewsUrl = privateNewsUrl.Replace("https:/", "https://");
        if (privateREDetail.Length > 0)
        {
            NewsContentHtml = gn.GetHTML(privateNewsUrl, enc);

            if (privateREDetail != null && privateREDetail != "")
                FullStory = gn.GetREGroup(NewsContentHtml, privateREDetail, "CONTENT");
            if (privateREImage != null && privateREImage != "")
                ImageSource = gn.GetREGroup(NewsContentHtml, privateREImage, "IMAGE");
            if (privateREVideo != null && privateREVideo != "")
                VideoSource = gn.GetREGroup(NewsContentHtml, privateREVideo, "VIDEO");

            if (!ImageSource.StartsWith("http://") && !ImageSource.StartsWith("https://") && ImageSource != "")
                ImageSource = LinkDomainName + ImageSource;


            if (!VideoSource.StartsWith("http://") && VideoSource != "")
                VideoSource = LinkDomainName + VideoSource;


            FullStory = gn.RemoveTags(FullStory, "br");
            FullStory = FullStory.Replace("'", "");
            FullStory = FullStory.Replace("\"", "");
            FullStory = FullStory.Replace("\r", "");
            FullStory = FullStory.Replace("\t", "");
            FullStory = FullStory.Replace("&nbsp;", "");

            ImageSource = ImageSource.Replace("[", "%5B");
            ImageSource = ImageSource.Replace("]", "%5D");

            VideoSource = VideoSource.Replace("[", "%5B");
            VideoSource = VideoSource.Replace("]", "%5D");


            if (ImageSource != "") //Save News File
            {
                try
                {
                    int SlashPos = ImageSource.LastIndexOf("/");
                    string FileName = ImageSource.Substring(SlashPos + 1, ImageSource.Length - SlashPos - 1);
                    WebClient WebCl = new WebClient();
                    string FName = Server.MapPath("~/Files/News/" + Tools.GetRandomFileName(FileName));
                    //WebCl.DownloadFile(ImageSource, FName);
                }
                catch
                {
                }
            }
        }
        TextTitle = gn.RemoveTags(privateNewsTitle);

        string ImageTag = "";
        if (ImageSource != "")
            ImageSource = "<img src=\"" + ImageSource + "\">";
        string outStr = string.Format("<table border=\"1\" class=\"cNews\" dir=\"rtl\" width=\"100%\" ><tr><td>{0}</td><td >{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='{5}'>{6}</a></td></tr></table>", Count, TextTitle, FullStory.Length, ImageSource, VideoSource, privateNewsUrl, privateNewsUrl);
        Response.Write(outStr);
        Response.Flush();


        gn.Dispose();

    }

    public ArrayList GetNewsList(string rssAddress)
    {
        //string rssAddress = "http://rss.msnbc.msn.com/id/3032091/device/rss/rss.xml";
        ArrayList NewsAL = new ArrayList();
        try
        {
            object objRss = Tools.ConsumeRss(rssAddress, null);
            if (objRss != null)
            {
                DataView dv = (DataView)objRss;
                for (int i = 0; i < dv.Table.Rows.Count; i++)
                {
                    DataRow dr = dv.Table.Rows[i];
                    NewsAL.Add("<a href='" + dr["link"] + "'>" + dr["title"] + "</a>");
                }
            }
        }
        catch
        {
        }
        return NewsAL;
    }

    public void GetSingleSite(int privateSiteCode, int privateLimitCount)
    {
        int Count = 1;
        string NewsTitle = "";
        string HtmlContent = "";
        string EditedNewsTitle = "";
        string NewsTextTitle = "";

        ReqUtils gn;

        string SelectStatement = "";

        BOLResourseSiteCats ResourceSiteCatsBOL = new BOLResourseSiteCats(1);
        vResourseSiteCats SingleSite = ResourceSiteCatsBOL.GetSingleSite(privateSiteCode);

        int SiteCode = SingleSite.Code;
        string SiteName = SingleSite.Name;
        string SiteUrl = SingleSite.Url;
        int? EncodingTypeCode = SingleSite.HCEncodingTypeCode;
        string BaseURL = SingleSite.BaseURL;

        string RELink = SingleSite.RELink;
        string REDetail = SingleSite.REDetail;
        string REImage = SingleSite.REImage;
        string REVideo = SingleSite.REVideo;

        ArrayList NewList = new ArrayList();

        gn = new ReqUtils();
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        if (EncodingTypeCode != 1)
        {
            IBaseBOL<DataTable> BolHardCode = new BOLHardCode();
            BolHardCode.QueryObjName = "HCEncodingTypes";
            DataTable dt = BolHardCode.GetDetails((int)EncodingTypeCode);
            enc = System.Text.Encoding.GetEncoding(dt.Rows[0]["Description"].ToString());
        }

        int LastSlash = SiteUrl.LastIndexOf("/");
        string LinkDomainName;
        if (BaseURL != null && BaseURL != "")
            LinkDomainName = BaseURL;
        else
            LinkDomainName = SiteUrl.Substring(0, LastSlash + 1);
        if (!(bool)SingleSite.RssIsActive)
        {
            HtmlContent = gn.GetHTML(SiteUrl, enc);
            NewList = gn.ExtractNewsLinks(HtmlContent, RELink, LinkDomainName);
        }
        else
            NewList = GetNewsList(SingleSite.RssUrl);

        IEnumerator NewENum = NewList.GetEnumerator();

        gn = new ReqUtils();
        while (NewENum.MoveNext())
        {
            NewsTitle = NewENum.Current.ToString();
            NewsTextTitle = gn.RemoveTags(NewsTitle);
            BOLNews NewsBOl = new BOLNews();

            if (!NewsBOl.CheckNewsExists(NewsTextTitle, SiteCode))
            {
                string RealLink = gn.ExtractLink(NewsTitle);
                string outStr = "";
                //outStr = string.Format("<table width=100% ><tr><td class=\"cNews\">{1}</td><td>{0}</td></tr></table>", Count, NewsTitle);
                //Response.Write(outStr);
                //Response.Flush();
                ListNews(SiteCode, RealLink, NewsTitle, REDetail, REImage, REVideo, Count, LinkDomainName, (int)EncodingTypeCode);
            }

            Count++;
            if (privateLimitCount != 0)
                if (privateLimitCount == Count)
                    break;
        }
    }


}
