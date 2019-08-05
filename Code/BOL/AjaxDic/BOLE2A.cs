﻿using System;
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
/// Summary description for BOLE2A
/// </summary>
public class BOLE2A
{
	public BOLE2A()
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
                return new Converter<EA>().ToDataTable((from d in dc.EAs
                                                        where d.Word.StartsWith(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "EndsWith":
                return new Converter<EA>().ToDataTable((from d in dc.EAs
                                                        where d.Word.EndsWith(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "Contains":
                return new Converter<EA>().ToDataTable((from d in dc.EAs
                                                        where d.Word.Contains(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            case "Equals":
                return new Converter<EA>().ToDataTable((from d in dc.EAs
                                                        where d.Word.Equals(Word)
                                                        select d).Distinct().Take(TopCount));
                break;
            default:
                return new DataTable();
                break;
        }

    }

}
