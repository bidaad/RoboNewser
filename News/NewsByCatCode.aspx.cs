using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class News_NewsByCatCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string strCode = Request["Code"];
            int Code;
            Int32.TryParse(strCode, out Code);
            BOLNews NewsBOL = new BOLNews();
            NewsList1.ShowNewsByCatCode(Code, null);

            string strPageNo = Request["PageNo"];
            int PageNo = Convert.ToInt32(strPageNo);
            if (PageNo == 0)
                PageNo = 1;


            IBaseBOL<DataTable> HardCodeBOL = new BOLHardCode();
            HardCodeBOL.QueryObjName = "HCResourceSitesCats";
            DataTable dtCurCat = HardCodeBOL.GetDetails(Code);
            if (dtCurCat.Rows.Count == 1)
            {
                ltrHeader.Text = "Latest " + dtCurCat.Rows[0]["Name"].ToString() + " News Page " + PageNo;
                Page.Title = " Latest " + dtCurCat.Rows[0]["Name"].ToString() + " Page " + PageNo;
            }
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "NewsByCatCode::Load");
        }

    }
}