using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class News_RSS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BOLLogs LogsBOL = new BOLLogs();
        LogsBOL.LogRequest();

        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.ContentType = "text/xml";
        BOLNews NewsBOL = new BOLNews();
        rptNews.DataSource = NewsBOL.GetLatestNews(10, 1);
        rptNews.DataBind();
    }
}