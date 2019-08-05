using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class AllNews : System.Web.UI.Page
{
    public string strPageNo;
    int PageNo = 1;
    int _pageSize = 100;
    string ConcatUrl;

    protected void Page_Load(object sender, EventArgs e)
    {
        strPageNo = Request["PageNo"];
        try
        {
            PageNo = Convert.ToInt32(strPageNo);
        }
        catch
        {
        }
        if (PageNo == 0)
            PageNo = 1;
        if (PageNo > 50)
            PageNo = 50;

        BOLNews NewsBOL = new BOLNews();
        int ResultCount = 1000;//NewsBOL.GetLatestNewsCount();
        rptNewsList.DataSource = NewsBOL.GetTinyLatestNews(_pageSize, PageNo);
        rptNewsList.DataBind();

        int PageCount = ResultCount / _pageSize;
        if (ResultCount % _pageSize > 0)
            PageCount++;
        pgrToolbar.PageNo = PageNo;
        pgrToolbar.PageCount = PageCount;
        pgrToolbar.ConcatUrl = ConcatUrl;
        pgrToolbar.PageBind();

    }
}