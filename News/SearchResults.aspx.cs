using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.News
{
    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string Keyword = Server.UrlDecode(Request["Keyword"]);
                if (Keyword != "" && Keyword != null)
                {
                    NewsList1.ShowNewsByKeyword(Keyword);
                }
                //((TextBox)Master.FindControl("txtKeyword")).Text = Keyword;
            }
        }
    }
}