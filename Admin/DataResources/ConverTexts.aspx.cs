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

public partial class DataResources_ConverTexts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NewsDataContext dc = new NewsDataContext();
        var NList = from n in dc.News
                    select n;
        foreach (News CurNews in NList)
        {
            CurNews.ConvertedContent = ChangeText(CurNews.Contents);
            dc.SubmitChanges();
        }

        string Text = "متن تستی برای آزمایش";
        string r = ChangeText(Text);

    }
    public string ChangeText(string str)
    {
        string Result = "";
        for (int i = 0; i < str.Length; i++)
        {
            Result += ChangeTable(str.Substring(i,1));
        }
        return Result;
    }
    public string ChangeTable(string chr)
    {
        switch (chr)
        {
            case "ا":
                return "a";
            case "ب":
                return "b";
            case "پ":
                return "c";
            case "ت":
                return "d";
            case "ث":
                return "e";
            case "ج":
                return "f";
            case "چ":
                return "g";
            case "ح":
                return "h";
            case "خ":
                return "i";
            case "د":
                return "j";
            case "ذ":
                return "k";
            case "ر":
                return "l";
            case "ز":
                return "m";
            case "س":
                return "n";
            case "ش":
                return "o";
            case "ص":
                return "p";
            case "ض":
                return "q";
            case "ط":
                return "r";
            case "ظ":
                return "s";
            case "ع":
                return "t";
            case "غ":
                return "u";
            case "ف":
                return "v";
            case "ق":
                return "w";
            case "ک":
                return "x";
            case "گ":
                return "y";
            case "ل":
                return "z";
            case "م":
                return "1";
            case "ن":
                return "2";
            case "و":
                return "3";
            case "ه":
                return "4";
            case "ی":
                return "5";
            case "آ":
                return "6";
            case " ":
                return " ";
            default:
                return "0";
                break;
        }
    }
}
