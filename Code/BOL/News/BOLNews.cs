using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.SessionState;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using DataAccess;
using System.Data.SqlClient;
using RoboNewser.Code.DAL;
using System.Data.Linq;
using Monty.Linq;

public class BOLNews : BaseBOLNews, IBaseBOL<News>
{
    const int CachingTime = 10;

    public bool CheckNewsExists(string NewsUrl, int ResourceSiteCatCode)
    {
        NewsDataContext dc = new NewsDataContext();
        IQueryable<News> Result = from n in dc.News
                                  where n.Url.Equals(NewsUrl) && n.ResouceSiteCatCode.Equals(ResourceSiteCatCode)
                                  select n;

        return (Result.Count() > 0);
    }

    public IQueryable<vTinyLatestNews> GetTinyLatestNews(int PageSize, int PageNo)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetTinyLatestNews" + PageSize + "-" + PageNo] == null)
        {
            int SkipCount = PageSize * (PageNo - 1);
            IQueryable<vTinyLatestNews> Result = dataContext.vTinyLatestNews.OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
            context.Cache.Insert("GetTinyLatestNews" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vTinyLatestNews>)context.Cache["GetTinyLatestNews" + PageSize + "-" + PageNo];


    }

    internal object GetHeadlines(int NewsCount)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetHeadlines" + NewsCount] == null)
        {
            IQueryable<vHeadlineNews> Result = dataContext.vHeadlineNews.OrderByDescending(p => p.RelNewsCount).Take(NewsCount);
            context.Cache.Insert("GetHeadlines" + NewsCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vHeadlineNews>)context.Cache["GetHeadlines" + NewsCount];
    }

    public int InsertfromResourceSites(int? ZoneCode, int? SiteCode, int? HCResourceSiteCatCode, string Title, string Url, DateTime NewsDate, string Contents, string ImgUrl, string PicName, int LanguageCode)
    {
        int? ReturnNewsCode = 0;
        NewsDataContext dc = new NewsDataContext();
        dc.spInsertNews(SiteCode, HCResourceSiteCatCode, Title, Url, NewsDate, Contents, ImgUrl, PicName, LanguageCode, ref ReturnNewsCode);
        return (int)ReturnNewsCode;
    }
    public IQueryable<News> GetRecentUrgentNews()
    {
        return (from n in dataContext.News
                    .Where(n => n.Urgent.Equals(true))
                    .OrderByDescending(n => n.Code)
                select n).Take(5);
    }
    public IList CheckBusinessRules()
    {
        var messages = new List<string>();
        //Business rules here

        return messages;
    }

    public object GetRandNews(int RecordCount)
    {
        return dataContext.vRandNews.Take(RecordCount);
    }

    public object GetRandPicNews(int RecordCount)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetRandPicNews" + RecordCount] == null)
        {

            IQueryable<vRandPicNews> Result = dataContext.vRandPicNews.Take(RecordCount);
            context.Cache.Insert("GetRandPicNews" + RecordCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vRandPicNews>)context.Cache["GetRandPicNews" + RecordCount];
    }

    public vNewsDetail GetNewsByCode(int Code)
    {

        return dataContext.vNewsDetails.SingleOrDefault(p => p.Code.Equals(Code));
    }

    internal IEnumerable<NewsImages> GetNewsImages(int NewsCode)
    {
        return dataContext.NewsImages.Where(p => p.NewsCode.Equals(NewsCode));
    }

    public IQueryable<vRelatedNews> GetRelatedNews(int NewsCode, int PageSize, int PageNo)
    {
        //HttpContext context = HttpContext.Current;
        //if (context.Cache["GetRelatedNews" + NewsCode + "-" + PageSize + "-" + PageNo] == null)
        //{

        //    int SkipCount = (PageNo - 1) * PageSize;
        //    IQueryable<vRelatedNews> Result = dataContext.vRelatedNews.Where(p => p.EntityCode.Equals(NewsCode)).OrderByDescending(p => p.RelatedCode).Skip(SkipCount).Take(PageSize);
        //    context.Cache.Insert("GetRelatedNews" + NewsCode + "-" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        //}
        //return (IQueryable<vRelatedNews>)context.Cache["GetRelatedNews" + NewsCode + "-" + PageSize + "-" + PageNo];

        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<vRelatedNews> Result = dataContext.vRelatedNews.Where(p => p.EntityCode.Equals(NewsCode)).OrderByDescending(p => p.RelatedCode).Skip(SkipCount).Take(PageSize);
        return Result;

    }


    public object GetSmallRelatedNews(int NewsCode, int PageSize)
    {
        object Result = (from p in dataContext.vRelatedNews
                        where p.EntityCode.Equals(NewsCode)
                        select new {p.Code, p.Title, p.RelatedCode } into selection
                        orderby selection.RelatedCode descending
                        select selection
                        ).Take(PageSize);


        //dataContext.vRelatedNews.Where(p => p.EntityCode.Equals(NewsCode)).OrderByDescending(p => p.RelatedCode).Skip(SkipCount).Take(PageSize);

        return Result;
    }



    public int GetRelatedNewsCount(int NewsCode)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetRelatedNewsCount" + NewsCode] == null)
        {
            int Result = dataContext.vRelatedNews.Where(p => p.EntityCode.Equals(NewsCode)).Count();
            context.Cache.Insert("GetRelatedNewsCount" + NewsCode, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (int)context.Cache["GetRelatedNewsCount" + NewsCode];


        
    }

    internal object GetRelatedPicNews(int NewsCode, int TakeCount)
    {
        //HttpContext context = HttpContext.Current;
        //if (context.Cache["GetRelatedPicNews" + NewsCode + "-" + TakeCount] == null)
        //{
        //    var Result = (from p in dataContext.vRelatedNews
        //                  where p.EntityCode.Equals(NewsCode) && p.PicName != null && p.PicName != ""
        //                  select new { p.Code, p.Title, p.ImgUrl }).Take(TakeCount);

        //    context.Cache.Insert("GetRelatedPicNews" + NewsCode + "-" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        //}
        //return (object)context.Cache["GetRelatedPicNews" + NewsCode + "-" + TakeCount];

        var Result = (from p in dataContext.vRelatedNews
                      where p.EntityCode.Equals(NewsCode) && p.PicName != null && p.PicName != ""
                      select new { p.Code, p.Title, p.ImgUrl }).Take(TakeCount);

        return Result;
    }

    public IQueryable<vLatestNews> GetLatestNews(int PageSize, int PageNo)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetLatestNews" + PageSize + "-" + PageNo] == null)
        {
            int SkipCount = PageSize * (PageNo - 1);
            IQueryable<vLatestNews> Result = dataContext.vLatestNews.OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
            context.Cache.Insert("GetLatestNews" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vLatestNews>)context.Cache["GetLatestNews" + PageSize + "-" + PageNo];


    }
    public int GetLatestNewsCount()
    {

        return dataContext.vLatestNews.Count();
    }
    public IQueryable<vLatestNews> GetLatestNewsByResourceCode(int ResourceSiteCode, int PageSize, int PageNo)
    {
        int SkipCount = PageSize * (PageNo - 1);


        return dataContext.vLatestNews.Where(p => p.ResourceSiteCode.Equals(ResourceSiteCode)).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
    }
    public int GetLatestNewsByResourceCodeCount(int ResourceSiteCode)
    {

        return dataContext.vLatestNews.Where(p => p.ResourceSiteCode.Equals(ResourceSiteCode)).Count();
    }
    public object SearchNewsByKeyword(string Keyword, int PageSize, int PageNo)
    {
        int SkipCount = PageSize * (PageNo - 1);
        Keyword = Keyword.Trim();
        int LoopCounter = 0;
        while (Keyword.IndexOf("  ") >= 0 && LoopCounter < 100)
        {
            Keyword = Keyword.Replace("  ", " ");
            LoopCounter++;
        }
        string[] KeywordArray = Keyword.Split(' ');
        string WhereClause = "";
        for (int i = 0; i < KeywordArray.Length; i++)
        {
            if (i == 0)
                WhereClause = "(CONTAINS(Title, N''" + KeywordArray[i] + "'') or CONTAINS(Contents, N''" + KeywordArray[i] + "''))";
            else
                WhereClause = WhereClause + " and (CONTAINS(Title, N''" + KeywordArray[i] + "'') or CONTAINS(Contents, N''" + KeywordArray[i] + "''))";
        }
        return dataContext.ExecuteQuery<vLatestNews>(string.Format("exec spSearchNews N'{0}'", WhereClause)).Skip(SkipCount).Take(PageSize);
    }

    public int SearchNewsByKeywordCount(string Keyword)
    {
        Keyword = Keyword.Trim();
        int LoopCounter = 0;
        while (Keyword.IndexOf("  ") >= 0 && LoopCounter < 100)
        {
            Keyword = Keyword.Replace("  ", " ");
            LoopCounter++;
        }
        string[] KeywordArray = Keyword.Split(' ');
        string WhereClause = "";
        for (int i = 0; i < KeywordArray.Length; i++)
        {
            if (i == 0)
                WhereClause = "(CONTAINS(Title, N'" + KeywordArray[i] + "') or CONTAINS(Contents, N'" + KeywordArray[i] + "'))";
            else
                WhereClause = WhereClause + " and (CONTAINS(Title, N'" + KeywordArray[i] + "') or CONTAINS(Contents, N'" + KeywordArray[i] + "'))";
        }

        string cnStr = ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString;
        SQLServer dal = new SQLServer(cnStr);
        dal.AddParameter("@WhereClause", WhereClause, SQLServer.SQLDataType.SQLNVarchar, 4000, ParameterDirection.Input);
        DataSet ds = dal.runSPDataSet("dbo.spSearchNewsCount", null);
        dal.ClearParameters();
        DataTable dt = ds.Tables[0];

        return Convert.ToInt32(dt.Rows[0]["RecordCount"]);

        //return dataContext.ExecuteQuery<>(string.Format("exec spSearchNewsCount N'{0}'", WhereClause));
        //return dataContext.spSearchNewsCount(WhereClause);
    }
    public IQueryable<vNewsByCatCode> GetNewsByCatCode(int CatCode, int PageSize, int PageNo)
    {

        HttpContext context = HttpContext.Current;
        if (context.Cache["GetNewsByCatCode" + CatCode + "-" + PageSize + "-" + PageNo] == null)
        {
            int SkipCount = PageSize * (PageNo - 1);

            IQueryable<vNewsByCatCode> Result = dataContext.vNewsByCatCodes.Where(p => p.CatCode.Equals(CatCode)).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
            context.Cache.Insert("GetNewsByCatCode" + CatCode + "-" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vNewsByCatCode>)context.Cache["GetNewsByCatCode" + CatCode + "-" + PageSize + "-" + PageNo];


    }
    public int GetNewsByCatCodeCount(int CatCode)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetNewsByCatCodeCount" + CatCode ] == null)
        {
            int Result = dataContext.vNewsByCatCodes.Where(p => p.CatCode.Equals(CatCode)).Count();
            context.Cache.Insert("GetNewsByCatCodeCount" + CatCode , Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (int)context.Cache["GetNewsByCatCodeCount" + CatCode ];

    }

    internal string GetNewsByCatCode(int CatCode)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetNewsByCatCode" + CatCode] == null)
        {
            BOLHardCode HardCodeBOL = new BOLHardCode();
            HardCodeBOL.TableOrViewName = "HCResourceSitesCats";
            string Result = HardCodeBOL.GetNameByCode(CatCode);
            context.Cache.Insert("GetNewsByCatCode" + CatCode, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (string)context.Cache["GetNewsByCatCode" + CatCode];

    }

    public object GetNewsByKeywordCode(int KeywordCode, int PageSize, int PageNo)
    {
        int SkipCount = PageSize * (PageNo - 1);


        //return dataContext.vNewsByKeywords.Where(p => p.KeywordCode.Equals(KeywordCode)).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
        return dataContext.spGetNewsByKeywordCode(KeywordCode).Where(p => p.KeywordCode.Equals(KeywordCode)).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
    }


    public object GetPicNewsByKeywordCode(int KeywordCode)
    {
        return dataContext.spGetPicNewsByKeywordCode(KeywordCode).Where(p => p.KeywordCode.Equals(KeywordCode)).OrderByDescending(p => p.NewsDate);
    }

    public int GetNewsByKeywordCodeCount(int KeywordCode)
    {

        return dataContext.vNewsByKeywords.Where(p => p.KeywordCode.Equals(KeywordCode)).Count();
    }
    public IQueryable<vNewsflowNews> GetNewsNewsflows(int NewsflowCode, int PageSize, int PageNo)
    {
        int SkipCount = PageSize * (PageNo - 1);


        return dataContext.vNewsflowNews.Where(p => p.NewsFlowCode.Equals(NewsflowCode)).OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
    }
    public int GetNewsNewsflowsCount(int NewsflowCode)
    {

        return dataContext.vNewsflowNews.Where(p => p.NewsFlowCode.Equals(NewsflowCode)).Count();
    }




    public object GetList(int StartIndex, int PageSize)
    {
        int SkipCount = (StartIndex - 1) * PageSize;
        return dataContext.vNews.OrderByDescending(p => p.Code).Skip(SkipCount).Take(PageSize);
    }

    public IQueryable<vRandTextNews> GetLatestTextNews(int PageSize, int PageNo, int? MaxLen)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetLatestTextNews" + MaxLen + "-" + PageSize + "-" + PageNo] == null)
        {
            int SkipCount = PageSize * (PageNo - 1);
            IQueryable<vRandTextNews> Result = dataContext.vRandTextNews;
            if (MaxLen != null)
                Result = Result.Where(p => p.Title.Length <= MaxLen);
            Result = Result.OrderByDescending(p => p.NewsDate).Skip(SkipCount).Take(PageSize);
            context.Cache.Insert("GetLatestTextNews" + MaxLen + "-" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vRandTextNews>)context.Cache["GetLatestTextNews" + MaxLen + "-" + PageSize + "-" + PageNo];
    }

    public int SearchPicNewsCount()
    {

        IQueryable<vLatestNews> Result = dataContext.vLatestNews.Where(p => !p.PicName.Equals(""));
        return Result.Count();
    }

    public object SearchPicNews(int PageSize, int PageNo)
    {
        /*
        int SkipCount = PageSize * (PageNo - 1);
        IQueryable<vLatestNews> Result = dataContext.vLatestNews.Where(p => !p.PicName.Equals(""));
        Result = Result.OrderByDescending(p => p.Code);
        Result = Result.Skip(SkipCount).Take(PageSize);
        return Result;
         * */

        HttpContext context = HttpContext.Current;
        if (context.Cache["SearchPicNews" + PageSize + "-" + PageNo] == null)
        {
            int SkipCount = PageSize * (PageNo - 1);
            IQueryable<vLatestNews> Result = dataContext.vLatestNews.Where(p => !p.PicName.Equals(""));
            Result = Result.OrderByDescending(p => p.Code);
            Result = Result.Skip(SkipCount).Take(PageSize);
            context.Cache.Insert("SearchPicNews" + PageSize + "-" + PageNo, Result, null, DateTime.Now.AddMinutes(10), TimeSpan.Zero);
        }
        return (IQueryable<vLatestNews>)context.Cache["SearchPicNews" + PageSize + "-" + PageNo];


    }

    public object GetImportantKeywords(int TakeCount)
    {

        return dataContext.vImportantKeywords.OrderByDescending(p => p.KeywordCount).Take(TakeCount);
    }


    internal IQueryable<vRandPicNews> GetRandPicNews(int PageSize, int PageNo)
    {
        int SkipCount = PageSize * (PageNo - 1);


        return dataContext.vRandPicNews;
    }

    public object GetRelatedPicNews(int Code)
    {
        return dataContext.spGetRelatedPicNews(Code);
    }

    public void UpdateViewCount(int Code)
    {
        try
        {
            dataContext.spUpdateNewsviewCount(Code);
            //CurrentNews.ViewCount = CurrentNews.ViewCount + 1;
            //dataContext.SubmitChanges();
        }
        catch
        {
        }
    }

    internal object SearchNews(int PageSize, int PageNo, string Keyword, out int ResultCount)
    {
        PagedDataSource objPds = new PagedDataSource();
        string WhereClause = Tools.MakeWhereClause(Keyword, "Title,Contents");
        if (WhereClause.StartsWith("AND "))
            WhereClause = WhereClause.Substring(4, WhereClause.Length - 4);

        //DataTable dt = Tools.DoSearchSite("vLatestNews", "Code, Title, ResourceName, PicName, Contents, NewsDate, ResourceSiteCode, ResourceSiteCatCode, CatCode, ImgUrl", WhereClause, "Code");
        string SqlStr = "SELECT     TOP 100 dbo.News.Code, dbo.News.Title, dbo.ResourceSites.Name AS ResourceName, dbo.News.PicName, cast(dbo.News.Contents as nvarchar(400)) as Contents, dbo.News.NewsDate, " +
                        " dbo.ResourceSites.Code AS ResourceSiteCode, dbo.ResourseSiteCats.Code AS ResourceSiteCatCode, dbo.ResourseSiteCats.CatCode, dbo.News.ImgUrl " +
                        " FROM         dbo.News INNER JOIN " +
                        " dbo.ResourseSiteCats ON dbo.News.ResouceSiteCatCode = dbo.ResourseSiteCats.Code INNER JOIN " +
                        " dbo.ResourceSites ON dbo.ResourseSiteCats.ResouseSiteCode = dbo.ResourceSites.Code Where " + WhereClause + "ORDER BY dbo.News.NewsDate DESC";
        DataTable dt = Tools.DoSearchSiteQuery(SqlStr);
        ResultCount = dt.Rows.Count;
        objPds.DataSource = dt.DefaultView;
        objPds.AllowPaging = true;
        objPds.PageSize = PageSize;
        objPds.CurrentPageIndex = PageNo - 1;

        return objPds;
    }

    internal int SearchNewsCount(string Keyword)
    {
        throw new NotImplementedException();
    }

    internal object GetLatest10News()
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetLatest10News"] == null)
        {
            dataContext = new NewsDataContext();
            IQueryable<vLatestNews> Result = dataContext.vLatestNews.OrderByDescending(p => p.Code).Take(30);
            context.Cache.Insert("GetLatest10News", Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vLatestNews>)context.Cache["GetLatest10News"];

    }

    internal void IncrementVisitCount(int Code)
    {
        try
        {
            NewsVisits NewRecord = new NewsVisits();
            dataContext.NewsVisits.InsertOnSubmit(NewRecord);
            NewRecord.NewsCode = Code;
            NewRecord.VisitDate = DateTime.Now;
            dataContext.SubmitChanges();
        }
        catch
        {
        }
    }

    internal object GetMostVisitedTextNews(int PageSize, int PageNo, int? MaxLen)
    {
        int SkipCount = PageSize * (PageNo - 1);


        var Result = dataContext.vMostVisitedNews;
//        if (MaxLen != null)
//            Result = Result.Where(p => p.Title.Length <= MaxLen).AsQueryable();
        return Result.OrderByDescending(p=> p.VisitCount).Skip(SkipCount).Take(PageSize);//.FromCache(System.Web.Caching.CacheItemPriority.Normal, new TimeSpan(1,0,0));
        //return Result;
    }

    internal string GetVisitCount(int Code)
    {
        string Result = "";
        try
        {
            Result = dataContext.fnGetNewsVisitCount(Code).ToString();
        }
        catch
        {
        }
        return Result;
    }

    internal string GetLatestNewsByKeyword(string Keyword)
    {
        try
        {
            BOLKeywords KeywordsBOL = new BOLKeywords();
            int? KeywordCode = KeywordsBOL.GetKeywordCode(Keyword);
            if (KeywordCode != null)
            {
                IEnumerable<spGetNewsByKeywordCodeResult> Result = dataContext.spGetNewsByKeywordCode(KeywordCode).Where(p => p.KeywordCode.Equals(KeywordCode)).OrderByDescending(p => p.NewsDate).Take(1);
                spGetNewsByKeywordCodeResult CurItem = Result.First();
                return CurItem.Title + "|" + CurItem.ResourceName + " " + Tools.GetPrettyPersianDate2(CurItem.NewsDate);
            }
            return "";
        }
        catch
        {
            return "";
        }
    }

    internal IQueryable<News> GetLatestPicNews(int PageSize, int PageNo)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        return dataContext.News.Where(p => p.PicName != "").OrderByDescending(p=>p.Code).Skip(SkipCount).Take(PageSize);
    }

    internal int GetLatestPicNewsCount()
    {
        return dataContext.News.Where(p => p.PicName != "").Count();
    }

    internal IQueryable<vLatestPicNews> GetTopPicNews(int CatCode)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetTopPicNews" + CatCode] == null)
        {
            IQueryable<vLatestPicNews> Result = dataContext.vLatestPicNews.Where(p=> p.CatCode.Equals(CatCode)).Take(1);
            context.Cache.Insert("GetTopPicNews" + CatCode, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vLatestPicNews>)context.Cache["GetTopPicNews" + CatCode];
    }

    internal object GetPicNews(int? CatCode, int? Code, int TakeCount)
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetPicNews" + CatCode + "-" + "-" + Code + "-" + TakeCount] == null)
        {
            IQueryable<vLatestPicNews> Result = dataContext.vLatestPicNews;
            if (Code != null)
                Result = Result.Where(p => !p.Code.Equals(Code));
            if (CatCode != null)
                Result = Result.Where(p => p.CatCode.Equals(CatCode));

            Result = Result.Take(TakeCount);
            context.Cache.Insert("GetPicNews" + CatCode + "-" + "-" + Code + "-" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vLatestPicNews>)context.Cache["GetPicNews" + CatCode + "-" + "-" + Code + "-" + TakeCount];
    }

    internal object GetMostVisited4h(int TakeCount)
    {
        int CachingTime = 120;

        HttpContext context = HttpContext.Current;
        try
        {
            if (context.Cache["GetMostVisited4h" + TakeCount] == null)
            {
                dataContext = new NewsDataContext();
                IQueryable<vMVNews4h> Result = dataContext.vMVNews4hs.Take(TakeCount);
                context.Cache.Insert("GetMostVisited4h" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
            }
            return (IQueryable<vMVNews4h>)context.Cache["GetMostVisited4h" + TakeCount];
        }
        catch
        {
            context.Cache["GetMostVisited4h" + TakeCount] = null;
            return null;
        }

    }
    internal object GetMostVisited12h(int TakeCount)
    {
        HttpContext context = HttpContext.Current;
        int CachingTime = 120;

        try{
        if (context.Cache["GetMostVisited12h" + TakeCount] == null)
        {
            dataContext = new NewsDataContext();
            IQueryable<vMVNews12h> Result = dataContext.vMVNews12hs.Take(TakeCount);
            context.Cache.Insert("GetMostVisited12h" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vMVNews12h>)context.Cache["GetMostVisited12h" + TakeCount];
        }
        catch
        {
            context.Cache["GetMostVisited4h" + TakeCount] = null;
            return null;
        }

    }
    internal object GetMostVisited24h(int TakeCount)
    {
        HttpContext context = HttpContext.Current;
        int CachingTime = 120;

        try{
        if (context.Cache["GetMostVisited24h" + TakeCount] == null)
        {
            dataContext = new NewsDataContext();
            IQueryable<vMVNews24h> Result = dataContext.vMVNews24hs.Take(TakeCount);
            context.Cache.Insert("GetMostVisited24h" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (IQueryable<vMVNews24h>)context.Cache["GetMostVisited24h" + TakeCount];
        }
        catch
        {
            context.Cache["GetMostVisited4h" + TakeCount] = null;
            return null;
        }

    }

    internal string InsertEmail(string ToEmail, string SenderIP)
    {
        NewsEmails CurRecord = dataContext.NewsEmails.SingleOrDefault(p => p.Email.Equals(ToEmail));
        if (CurRecord != null)
            return CurRecord.ID;
        else
        {
            CurRecord = new NewsEmails();
            dataContext.NewsEmails.InsertOnSubmit(CurRecord);
            CurRecord.Email = ToEmail;
            CurRecord.SenderIP = SenderIP;

            Guid newGd = Guid.NewGuid();
            string ID = newGd.ToString().Replace("-", "");
            CurRecord.ID = ID;
            CurRecord.Active = false;
            dataContext.SubmitChanges();
            return ID;
        }
    }

    internal bool NewsEmailIDExists(string ID)
    {
        return dataContext.NewsEmails.SingleOrDefault(p => p.ID.Equals(ID)) != null;
    }

    internal bool ActivateNewsEmailID(string ID)
    {
        try
        {
            NewsEmails CurRecord = dataContext.NewsEmails.SingleOrDefault(p => p.ID.Equals(ID));
            if (CurRecord != null)
            {
                CurRecord.Active = true;
                dataContext.SubmitChanges();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    internal bool EmailExists(string Email)
    {
        return dataContext.NewsEmails.Where(p => p.Email.Equals(Email)).Any();
    }

    internal void UpdateNewsEmailID(string Email, bool Active)
    {
        NewsEmails CurRecord = dataContext.NewsEmails.SingleOrDefault(p => p.Email.Equals(Email));
        if (CurRecord != null)
        {
            CurRecord.Active = Active;
            dataContext.SubmitChanges();
        }
    }

    internal IQueryable<vTinyNews> LoadPicNews(int TakeCount)
    {
        HttpContext context = HttpContext.Current;
        int CachingTime = 120;

        try
        {
            if (context.Cache["LoadPicNews" + TakeCount] == null)
            {
                dataContext = new NewsDataContext();
                //IQueryable<vNews> Result = dataContext.vNews.Where(p => p.PicName != null && p.PicName != "").OrderByDescending(p => p.Code).Take(TakeCount);
                //var Result = (from p in dataContext.vNews
                //                where p.PicName != null && p.PicName != ""
                //                select new { p.Code, p.ImgUrl, p.Title, p.ResourceSite}
                //                ).OrderByDescending(p => p.Code).Take(TakeCount);
                IQueryable<vTinyNews> Result = dataContext.vTinyNews.Where(p => p.PicName != null && p.PicName != "").OrderByDescending(p => p.Code).Take(TakeCount);
                context.Cache.Insert("LoadPicNews" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
            }
            return (IQueryable<vTinyNews>)context.Cache["LoadPicNews" + TakeCount];
        }
        catch
        {
            context.Cache["LoadPicNews" + TakeCount] = null;
            return null;
        }

    }
}

public class TinyNews
{
    public int Code
    {
        get;
        set;
    }
    public string ImgUrl
    {
        get;
        set;
    }
    public string Title
    {
        get;
        set;
    }
    public string ResourceSite
    {
        get;
        set;
    }
    
}