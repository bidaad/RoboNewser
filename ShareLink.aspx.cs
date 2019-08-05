using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser
{
    public partial class ShareLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strMedia = Request["Media"];
            string strLinkUrl = Request["LinkUrl"];
            string strLinkTitle = Request["LinkTitle"];
            

            switch (strMedia)
            {
                case "facebook":
                    Response.Redirect("http://www.facebook.com/sharer/sharer.php?u=" + strLinkUrl);
                    break;
                case "digg":
                    Response.Redirect("http://digg.com/submit?url=" + strLinkUrl);
                    break;
                case "twitter":
                    Response.Redirect("https://twitter.com/intent/tweet?text=" + strLinkTitle + "&url=" + strLinkUrl);
                    break;
                default:
                    break;
            }

        }
    }
}