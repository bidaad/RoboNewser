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
/// Summary description for BOLP2E
/// </summary>
public class BOLP2E
{
	public BOLP2E()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataTable GetWordTranslation(string Word, int TopCount, string TransType)
    {
        DictionariesDataContext dc = new DictionariesDataContext();

        switch (TransType)
        {
            case "StartsWith":
                return new Converter<EF>().ToDataTable((from d in dc.EFs
                                                        where d.Meaning.StartsWith(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "EndsWith":
                return new Converter<EF>().ToDataTable((from d in dc.EFs
                                                        where d.Meaning.EndsWith(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "Contains":
                return new Converter<EF>().ToDataTable((from d in dc.EFs
                                                        where d.Meaning.Contains(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "Equals":
                return new Converter<EF>().ToDataTable((from d in dc.EFs
                                                        where d.Meaning.Equals(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            default:
                return new DataTable();
                break;
        }

    }

}
