using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser
{
    public partial class SitemapKPics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strStartIndex = Request["s"];
            int StartIndex;
            Int32.TryParse(strStartIndex, out StartIndex);
            if (StartIndex == 0)
                StartIndex = 1;
            BOLKeywords KeywordsBOL = new BOLKeywords();
            rptKeywords.DataSource = KeywordsBOL.GetPicKeywords(25000, 1);
            rptKeywords.DataBind();
        }
    }
}