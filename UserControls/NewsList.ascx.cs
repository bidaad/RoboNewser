using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace Khabardaan.Web.UI.UserControls
{
    public partial class NewsList : System.Web.UI.UserControl
    {
        public string strPageNo;
        int PageNo = 1;
        int _pageSize = 50;
        string ConcatUrl;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        public string _keyword = null;
        protected bool _showPager =true;
        public bool ShowPager
        {
            set
            {
                _showPager = value;
            }
            get
            {
                return _showPager;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public string ShowPic(object Title, object PicName)
        {
            string Result = "";
            if (PicName != null && PicName != "")
                Result = "<img class=\"cPic2\" alt=\"" + Title + "\" src=\"" + Page.ResolveUrl("//static.robonewser.com/Files/News/") + PicName + "\" />";
            return Result;
        }
        public void SearchNews(string Keyword)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;

                if (PageNo > 50)
                    PageNo = 50;

                int ResultCount = 0;
                BOLNews NewsBOL = new BOLNews();
                rptNewsList.DataSource = NewsBOL.SearchNews(_pageSize, PageNo, Keyword, out ResultCount);
                rptNewsList.DataBind();

                int PageCount = (int)ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;

                ConcatUrl += "&Keyword=" + Keyword;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch
            {
            }

        }
        public void ShowLatestNews()
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                IQueryable<vLatestNews> ItemList = NewsBOL.GetLatestNews(_pageSize, PageNo);
                int ResultCount = NewsBOL.GetLatestNewsCount();
                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();

                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch
            {
            }
        }
        public void ShowNewsByResourceCode(int ResourceSiteCode)
        {
            try
            {
                strPageNo = Request["PageNo"];

                PageNo = Convert.ToInt32(strPageNo);

                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                IQueryable<vLatestNews> ItemList = NewsBOL.GetLatestNewsByResourceCode(ResourceSiteCode, _pageSize, PageNo);
                int ResultCount = NewsBOL.GetLatestNewsByResourceCodeCount(ResourceSiteCode);
                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();

                ConcatUrl = "&Code=" + ResourceSiteCode;
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch (Exception exp)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(exp.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowNewsByResourceCode");
            }


        }
        public void ShowNewsByKeywordCode(int KeywordCode)
        {
            try
            {
                strPageNo = Request["PageNo"];
                try
                {
                    PageNo = Convert.ToInt32(strPageNo);
                }
                catch
                {
                }
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                //IQueryable<vNewsByKeywords> ItemList = NewsBOL.GetNewsByKeywordCode(KeywordCode, _pageSize, PageNo);

                BOLKeywords KeywordsBOL = new BOLKeywords();
                Keywords CurrentKeyword = KeywordsBOL.GetKeywordByCode(KeywordCode);
                if (CurrentKeyword != null)
                    _keyword = CurrentKeyword.Name;

                int ResultCount = NewsBOL.GetNewsByKeywordCodeCount(KeywordCode);
                rptNewsList.DataSource = NewsBOL.GetNewsByKeywordCode(KeywordCode, _pageSize, PageNo);
                rptNewsList.DataBind();

                if (rptNewsList.Items.Count == 0)
                {

                    Keywords CurKeyword = ((IBaseBOL<Keywords>)KeywordsBOL).GetDetails(KeywordCode);
                    ResultCount = NewsBOL.SearchNewsByKeywordCount(CurKeyword.Name);

                    rptNewsList.DataSource = NewsBOL.SearchNewsByKeyword(CurKeyword.Name, _pageSize, PageNo); ;
                    rptNewsList.DataBind();
                }

                ConcatUrl = "&Code=" + KeywordCode + "&Keyword=" +  CurrentKeyword.Name.Replace(" ", "_");
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch (Exception err)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowNewsByKeywordCode");

                //string MailBody = "Page: " + Request.FilePath + " Exception: " + err.Message;
                //Tools tools = new Tools();
                //bool SendResult = tools.SendEmail(MailBody, "پارست ::Error ", "bidaad@gmail.com", "", "", "");
            }

        }
        public void ShowNewsByNewsFlows(int NewsflowCode)
        {
            try
            {
                strPageNo = Request["PageNo"];

                PageNo = Convert.ToInt32(strPageNo);

                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                IQueryable<vNewsflowNews> ItemList = NewsBOL.GetNewsNewsflows(NewsflowCode, _pageSize, PageNo);
                int ResultCount = NewsBOL.GetNewsNewsflowsCount(NewsflowCode);
                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();

                ConcatUrl = "&Code=" + NewsflowCode;
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch (Exception err)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowNewsByNewsFlows");
            }
        }
        public void ShowNewsByCatCode(int CatCode, int? TakeCount)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                if (TakeCount != null)
                    _pageSize = (int)TakeCount;

                BOLNews NewsBOL = new BOLNews();
                IQueryable<vNewsByCatCode> ItemList = NewsBOL.GetNewsByCatCode(CatCode, _pageSize, PageNo);
                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();

                lblMessage.Text = NewsBOL.GetNewsByCatCode(CatCode);



                if (_showPager)
                {
                    int ResultCount = NewsBOL.GetNewsByCatCodeCount(CatCode);
                    ConcatUrl = "&Code=" + CatCode;
                    int PageCount = ResultCount / _pageSize;
                    if (ResultCount % _pageSize > 0)
                        PageCount++;
                    pgrToolbar.PageNo = PageNo;
                    pgrToolbar.PageCount = PageCount;
                    pgrToolbar.ConcatUrl = ConcatUrl;
                    pgrToolbar.PageBind();
                }
                else
                    pgrToolbar.Visible = false;
            }
            catch (Exception err)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowNewsByCatCode");
            }


        }
        public void ShowNewsByKeyword(string Keyword)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                int ResultCount = NewsBOL.SearchNewsByKeywordCount(Keyword);
                _keyword = Keyword;

                if (ResultCount > 0)
                {
                    lblMessage.Text = ResultCount + " results found for " + Keyword ;
                    rptNewsList.DataSource = NewsBOL.SearchNewsByKeyword(Keyword, _pageSize, PageNo); ;
                    rptNewsList.DataBind();

                    ConcatUrl = "&Keyword=" + Keyword;
                    int PageCount = ResultCount / _pageSize;
                    if (ResultCount % _pageSize > 0)
                        PageCount++;
                    pgrToolbar.PageNo = PageNo;
                    pgrToolbar.PageCount = PageCount;
                    pgrToolbar.ConcatUrl = ConcatUrl;
                    pgrToolbar.PageBind();

                }
                else
                {
                    lblMessage.Text = "No result found for" + Keyword ;
                }
            }
            catch (Exception err)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowNewsByKeyword");
            }


        }
        public void ShowPicNews()
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                int ResultCount = NewsBOL.SearchPicNewsCount();
                rptNewsList.DataSource = NewsBOL.SearchPicNews(_pageSize, PageNo); ;
                rptNewsList.DataBind();

                ConcatUrl = "";
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch
            {
            }

        }
        public void ShowRelatedNews(int Code)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
                if (PageNo == 0)
                    PageNo = 1;
                if (PageNo > 50)
                    PageNo = 50;

                BOLNews NewsBOL = new BOLNews();
                IQueryable<vRelatedNews> ItemList = NewsBOL.GetRelatedNews(Code, _pageSize, PageNo);
                int ResultCount = NewsBOL.GetRelatedNewsCount(Code);
                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();

                ConcatUrl = "&Code=" + Code;
                int PageCount = ResultCount / _pageSize;
                if (ResultCount % _pageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch (Exception err)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::ShowRelatedNews");
            }

        }

        public string ShowText(Object obj)
        {
            int SelectLen = 180;
            try
            {

                if (obj != null)
                {
                    string str = obj.ToString();
                    try
                    {
                        ReqUtils Utils = new ReqUtils();
                        str = Utils.RemoveTags(str);
                        if (!string.IsNullOrEmpty(_keyword))
                        {
                            string FirstKeyword = _keyword;
                            if (_keyword.IndexOf(" ") != -1)
                            {
                                string[] KeywordArray = _keyword.Split(' ');
                                FirstKeyword = KeywordArray[0];
                            }
                            int FirstKeywordIndex = str.IndexOf(FirstKeyword);
                            if (FirstKeywordIndex > SelectLen)
                            {
                                int StartIndex = FirstKeywordIndex - 150;
                                int StopIndex = FirstKeywordIndex + 150;
                                if (StopIndex > str.Length)
                                    StopIndex = str.Length;
                                int CutLen = StopIndex - StartIndex;
                                str = "..." + str.Substring(StartIndex, CutLen) + "...";
                            }
                        }
                    }
                    catch
                    {
                    }

                    if (str.Length > SelectLen)
                        str = str.Substring(0, SelectLen) + "...";

                    if (!string.IsNullOrEmpty(_keyword))
                    {
                        _keyword = _keyword.Trim();
                        string[] KeywordArray = _keyword.Split(' ');
                        for (int i = 0; i < KeywordArray.Length; i++)
                        {
                            if (KeywordArray[i].Length > 1)
                                str = str.Replace(KeywordArray[i], "<span class=keyworditem>" + KeywordArray[i] + "</span>");
                        }
                        return str;
                    }
                    else
                        return str;
                }
                else
                    return "";
            }
            catch
            {
                return obj.ToString();
            }

        }

        public string NewsShowBriefText(Object objText)
        {
            int SelectLen = 300;
            int Offset = 50;
            string Result = "";

            try
            {
                if (objText != null)
                {
                    string NewsText = objText.ToString();
                    if (_keyword == null)
                        Result = Tools.ShowBriefText(Tools.RemoveTags(objText), SelectLen);
                    else
                    {
                        Tools tools = new Tools();
                        NewsText = tools.RemoveTags(NewsText);
                        int KewwordPos = NewsText.IndexOf(_keyword);
                        if (KewwordPos != -1)
                        {
                            if (KewwordPos > Offset)
                            {
                                if (NewsText.Length > KewwordPos - Offset + SelectLen)
                                    Result = NewsText.Substring(KewwordPos - Offset, SelectLen) + "...";
                                else
                                    Result = NewsText.Substring(KewwordPos - Offset, NewsText.Length - (KewwordPos - Offset)) + "...";
                            }
                            Result = Result.Replace(_keyword, "<em>" + _keyword + "</em>");
                        }
                        else
                            Result = Tools.ShowBriefText(Tools.RemoveTags(objText), SelectLen);
                    }
                }
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsList::NewsShowBriefText");

                Result = Tools.ShowBriefText(Tools.RemoveTags(objText), SelectLen);
            }
            return Result;
        }

        protected void rptNewsList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            try
            {
                BOLNews NewsBOL = new BOLNews();
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    HyperLink hplRelatedNews = (HyperLink)e.Item.FindControl("hplRelatedNews");
                    HiddenField hfRelatedNews = (HiddenField)e.Item.FindControl("hfRelatedNews");
                    HiddenField hfPic = (HiddenField)e.Item.FindControl("hfPic");
                    Image imgNews = (Image)e.Item.FindControl("imgNews");
                    HyperLink hplimgNews = (HyperLink)e.Item.FindControl("hplimgNews");

                    string PicName = hfPic.Value;
                    if (string.IsNullOrEmpty(PicName))
                    {
                        imgNews.Visible = false;
                        hplimgNews.Visible = false;
                    }


                    int NewsCode = Convert.ToInt32(hfRelatedNews.Value);

                    //int RelatedNewsCount = NewsBOL.GetRelatedNewsCount(NewsCode);
                    //if (RelatedNewsCount > 0)
                    //{
                    //    hplRelatedNews.Text = "View more " + NewsBOL.GetRelatedNewsCount(NewsCode) + " news";
                    //    hplRelatedNews.NavigateUrl = "~/News/RelatedNews.aspx?Code=" + NewsCode;
                    //}
                    //else
                    hplRelatedNews.Visible = false;
                }
            }
            catch
            {

            }
        }
    }
}