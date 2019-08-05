using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_RandNews : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            BOLNews NewsBOL = new BOLNews();
            rptRandNews.DataSource = NewsBOL.GetLatest10News();
            rptRandNews.DataBind();

            //rptRandPicNews.DataSource = NewsBOL.GetRandPicNews(4); ;
            //rptRandPicNews.DataBind();

            //IranKidsDataContext dc = new IranKidsDataContext();
            //rptRandIranKids.DataSource = dc.vRandProducts.Take(6);
            //rptRandIranKids.DataBind();
        }

        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCRandNews::Load");
        }
    }
}
