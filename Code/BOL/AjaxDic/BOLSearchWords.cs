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
/// Summary description for BOLSearchWords
/// </summary>
public class BOLSearchWords
{
    public BOLSearchWords()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void AddToSearchWords(string Word, string Dic, string IP)
    {
        DictionariesDataContext dc = new DictionariesDataContext();
        SearchedWords newobj = new SearchedWords();
        dc.SearchedWords.InsertOnSubmit(newobj);
        newobj.Word = Word;
        newobj.Dic = Dic;
        newobj.IP = IP;
        dc.SubmitChanges();
    }

    public object GetLatestSearchedWords(int TopCount)
    {
        DictionariesDataContext dc = new DictionariesDataContext();
        return dc.SearchedWords.OrderByDescending(p => p.Code).Take(TopCount);
    }
}
