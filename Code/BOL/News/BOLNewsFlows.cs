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
using RoboNewser.Code.DAL;

public class BOLNewsFlows : BaseBOLNewsFlows, IBaseBOL<NewsFlows>
{
    public IList CheckBusinessRules()
    {
        var messages = new List<string>();
        //Business rules here

        if (false)
            messages.Add("");

        return messages;
    }


    internal object GetActiveNewsflows()
    {
        return dataContext.NewsFlows.Where(p=> p.HCShowTypeCode.Equals(3) || p.HCShowTypeCode.Equals(3)).OrderByDescending(p=> p.ShowOrder).Take(10);
    }

    internal IQueryable<NewsFlows> GetNewsflows(int PageSize, int PageNo, string Keyword)
    {
        int SkipCount = (PageNo - 1) * PageSize;
        IQueryable<NewsFlows> Result = dataContext.NewsFlows.Where(p => p.HCShowTypeCode.Equals(3) || p.HCShowTypeCode.Equals(3)).OrderByDescending(p => p.ShowOrder);
        if (!string.IsNullOrEmpty(Keyword))
            Result = Result.Where(p => p.Title.Contains(Keyword));
        return Result.Skip(SkipCount).Take(PageSize);
    }

    internal int GetNewsFlowCount(string Keyword)
    {
        IQueryable<NewsFlows> Result = dataContext.NewsFlows.Where(p => p.HCShowTypeCode.Equals(3) || p.HCShowTypeCode.Equals(3));
        if (!string.IsNullOrEmpty(Keyword))
            Result = Result.Where(p => p.Title.Contains(Keyword));
        return Result.Count();
    }
}
