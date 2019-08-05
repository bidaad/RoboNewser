using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewsSiteMap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strStartIndex = Request["s"];
        int StartIndex;
        Int32.TryParse(strStartIndex, out StartIndex);
        if (StartIndex == 0)
            StartIndex = 1;
        BOLNews NewsBOL = new BOLNews();
        rptNews.DataSource = NewsBOL.GetList(StartIndex, 25000);
        rptNews.DataBind();
    }
}