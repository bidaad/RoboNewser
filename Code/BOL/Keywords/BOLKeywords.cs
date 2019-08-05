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
using RoboNewser.Code.DAL;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using DataAccess;

public class BOLKeywords : BaseBOLKeywords, IBaseBOL<Keywords>
{
    const int CachingTime = 30;

    public IList CheckBusinessRules()
    {
        var messages = new List<string>();
        //Business rules here

        if (false)
            messages.Add("");

        return messages;
    }

    public static bool IsInTitleKeywords(string str)
    {
        KeywordsDataContext dataContext = new KeywordsDataContext();
        var ResultList = from k in dataContext.vTitleKeywords
                         where k.Title.Equals(str)
                         select k;
        if (ResultList.Count() == 0)
            return false;
        else
            return true;
    }

    internal int GetKeywordCount()
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetKeywordCount" ] == null)
        {
            int Result = dataContext.Keywords.Count();
            context.Cache.Insert("GetKeywordCount", Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (int)context.Cache["GetKeywordCount"];
    }

    internal object GetKeywords(int pageSize, int pageNo)
    {
        int SkipCount = (pageNo - 1) * pageSize;
        return dataContext.Keywords.Skip(SkipCount).Take(pageSize);
    }



    internal int GetPicKeywordCount()
    {
        HttpContext context = HttpContext.Current;
        if (context.Cache["GetKeywordCount"] == null)
        {
            int Result = dataContext.Keywords.Where(p=> p.HasPic.Equals(true)).Count();
            context.Cache.Insert("GetKeywordCount", Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (int)context.Cache["GetKeywordCount"];
    }

    internal object GetPicKeywords(int pageSize, int pageNo)
    {
        int SkipCount = (pageNo - 1) * pageSize;
        return dataContext.Keywords.Where(p => p.HasPic.Equals(true)).Skip(SkipCount).Take(pageSize);
    }


    public Keywords GetDataByKeyword(string KeyName)
    {
        return dataContext.Keywords.SingleOrDefault(u => u.Name.Equals(KeyName));
    }

    public int? GetKeywordCode(string Word)
    {
        KeywordsDataContext dc = new KeywordsDataContext();
        IQueryable<Keywords> Result = from p in dc.Keywords
                                      where p.Name.Equals(Word)
                                      select p;
        foreach (var item in Result)
        {
            return item.Code;
            
        }
        return null;
    }

    public object GetList(int StartIndex, int PageSize)
    {
        int SkipCount = (StartIndex - 1) * PageSize;
        return dataContext.vUsedKeywords.Skip(SkipCount).Take(PageSize);
    }

    public void AddToGrabage(int KeywordCode)
    {
        dataContext.spAddtoGrabagge(KeywordCode);
    }

    public RoboNewser.Code.DAL.Keywords GetKeywordByCode(int KeywordCode)
    {
        RoboNewser.Code.DAL.KeywordsDataContext dc = new RoboNewser.Code.DAL.KeywordsDataContext();
        return dc.Keywords.SingleOrDefault(p => p.Code.Equals(KeywordCode));
    }

    internal object GetKeywordsStartsWith(string Name)
    {
        return dataContext.Keywords.Where(p => p.Name.StartsWith(Name)).OrderBy(p=>p.Name.Length).Take(50);
    }

    internal object GetMostImportantKeywords(int TakeCount)
    {
        //KeywordsDataContext dc = new KeywordsDataContext();
        //return dc.vImportantKeywords.Take(TakeCount).OrderByDescending(p=> p.KeywordCount);

        HttpContext context = HttpContext.Current;
        if (context.Cache["GetMostImportantKeywords" + TakeCount] == null)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["RoboNewserConnectionString"].ConnectionString;
            SQLServer dal = new SQLServer(cnStr);
            string SqlStr = @"SELECT        TOP " + TakeCount + @"  Name AS Keyword, COUNT(Code) AS KeywordCount, KeywordCode
                        FROM            dbo.vNewsKeywords
                        WHERE        (EntityCode IN
                                                     (SELECT        Code
                                                       FROM            dbo.News
                                                       WHERE        (DATEDIFF(day, NewsDate, GETDATE()) <= 1))) AND (KeywordCode NOT IN
                                                     (SELECT        KeywordCode
                                                       FROM            dbo.SpecialKeywords))
                        GROUP BY Name, KeywordCode
                        HAVING        (Name LIKE '% %') order by KeywordCount desc";
            DataSet ds = dal.runSQLDataSet(SqlStr, null);
            dal.ClearParameters();
            DataTable Result = ds.Tables[0];

            context.Cache.Insert("GetMostImportantKeywords" + TakeCount, Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
        }
        return (DataTable)context.Cache["GetMostImportantKeywords" + TakeCount];
    }

    internal object GetKeywordByRole(string role)
    {
        return dataContext.vKeywordRoles.Where(p => p.KRole.Equals(role)).OrderByDescending(p => p.ImgUrl);
    }
}
