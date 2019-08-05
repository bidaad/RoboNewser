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
using RoboNewser.Code.DAL;

/// <summary>
/// Summary description for BOLSearchedKeywords
/// </summary>
public class BOLSearchedKeywords
{
	public BOLSearchedKeywords()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void Insert(string Keyword, int HCSiteSectionCode, string IP, int ReturnCount, DateTime SearchDate)
    {
        UtilDataContext dc = new UtilDataContext();
        SearchedKeywords NewKeyword = new SearchedKeywords();
        dc.SearchedKeywords.InsertOnSubmit(NewKeyword);
        NewKeyword.IP = IP;
        NewKeyword.ReturnCount = ReturnCount;
        NewKeyword.Keyword = Keyword;
        NewKeyword.HCSiteSectionCode = HCSiteSectionCode;
        NewKeyword.SearchDate = SearchDate;
        dc.SubmitChanges();
        
    }
}
