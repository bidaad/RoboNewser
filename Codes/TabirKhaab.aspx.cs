using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Codes
{
    public partial class TabirKhaab : System.Web.UI.Page
    {
        public string Keyword;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Keyword = txtKeyword.Text.Trim();
            SearchByKeyword(Keyword);
        }
        private void SearchByKeyword(string Keyword)
        {
            Response.Redirect("~/Fun/Tabir/SearchNames/?Keyword=" + Keyword);
        }
    }
}