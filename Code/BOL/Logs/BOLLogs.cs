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
using System.Collections;
using System.Collections.Generic;
using RoboNewser.Code.DAL;
  
public class BOLLogs 
{

    public void LogRequest()
    {
        try
        {
            int? Result = 1;
            string UserCode = "";
            if (HttpContext.Current.Session["UserCode"] != null)
            {
                UserCode = HttpContext.Current.Session["UserCode"].ToString();
            }
            bool HCReqTypeCode = false;
            string UserAgent = HttpContext.Current.Request.UserAgent;
            if (UserAgent == "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)" ||
                UserAgent == "Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)" ||
                UserAgent == "msnbot/2.0b (+http://search.msn.com/msnbot.htm)._" ||
                UserAgent == "Mozilla/5.0 (compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm)" ||
                UserAgent == "Mozilla/5.0 (en-us) AppleWebKit/525.13 (KHTML, like Gecko; Google Web Preview) Version/3.1 Safari/525.13" ||
                UserAgent == "Mozilla/5.0 (compatible; MJ12bot/v1.3.3; http://www.majestic12.co.uk/bot.php?+)" ||
                UserAgent == "Mozilla/5.0 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)" ||
                UserAgent == "Mozilla/5.0 (compatible; MJ12bot/v1.4.3; http://www.majestic12.co.uk/bot.php?+)" ||
                UserAgent == "Sogou web spider/4.0(+http://www.sogou.com/docs/help/webmasters.htm#07)"

                )
                HCReqTypeCode = true;

            Result = InsertLog(UserAgent, HttpContext.Current.Request.QueryString.ToString(), UserCode, HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.AbsolutePath, Tools.GetIranDate(), HttpContext.Current.Request.ServerVariables["http_referer"], HCReqTypeCode, ref Result);
            if (Result == 0)
                HttpContext.Current.Response.End();

        }
        catch (Exception err)
        {
        }
    }

    public int? InsertLog(string  UserAgent,string  QueryString, string  UserInfo, string UserHostAddress, string AbsolutePath, DateTime LogDate, string Http_referer, bool HCReqTypeCode, ref int? Result)
    {
        LogsDataContext dataContext = new LogsDataContext();
        dataContext.spInsertLog(UserAgent, QueryString, UserInfo, UserHostAddress, AbsolutePath, LogDate, Http_referer,HCReqTypeCode, ref Result);
        return Result;
    }

    public string GetLogCountByDate(DateTime PassDate)
    {
        LogsDataContext dataContext = new LogsDataContext();
        return dataContext.Logs.Where(p => p.LogDateTime.Value.Date.Equals(PassDate.Date) && p.HCReqTypeCode.Equals(false)).Count().ToString();
    }

    public string GetTotalCount()
    {
        LogsDataContext dataContext = new LogsDataContext();
        return dataContext.Logs.Count().ToString();
    }
}
