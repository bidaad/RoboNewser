using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.Ajax
{
    public partial class AjaxNewsTicker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLNews NewsBOL = new BOLNews();
            rptNews.DataSource = NewsBOL.GetLatest10News();
            rptNews.DataBind();
        }
    }
}