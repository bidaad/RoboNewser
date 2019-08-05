using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser
{
    public partial class KeywordsByRole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Role = Request["Role"];

            Role = Role.Replace("_", " ");
            BOLKeywords KeywordsBOL = new BOLKeywords();
            rptKeywords.DataSource = KeywordsBOL.GetKeywordByRole(Role);
            rptKeywords.DataBind();

            lblTitle.Text = "List of " + Role + "s";
            Page.Title = Role + " | RoboNewser";

            Tools.SetLink("lnkCanonical", "https://www.robonewser.com/" + "/Roles/" + Tools.ReplaceSpaceWithUnderline(Role) );

            Tools.SetMeta("keywords", Role);
            Tools.SetMeta("description", Role);
            Tools.SetMeta("twittercard", Role);
            Tools.SetMeta("twittertitle", Role);
            Tools.SetMeta("twitterdescription", Role);
            Tools.SetMeta("ogtitle", Role);
            Tools.SetMeta("ogurl", "https://www.robonewser.com/" + "/Roles/" + Tools.ReplaceSpaceWithUnderline(Role) );
            Tools.SetMeta("twitterimagesrc", "");
            Tools.SetMeta("ogimage", "");
            Tools.SetMeta("ogdescription", Role);

        }
    }
}