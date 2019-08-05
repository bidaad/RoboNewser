using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace RoboNewser.News
{
    public partial class URNewsByResource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                string strCode = Request["Code"];
                int Code;
                Int32.TryParse(strCode, out Code);
                BOLNews NewsBOL = new BOLNews();
                NewsList1.ShowNewsByResourceCode(Code);

                BOLResourceSites ResourceSitesBOL = new BOLResourceSites();
                ResourceSites CurResourceSite = ((IBaseBOL<ResourceSites>)ResourceSitesBOL).GetDetails(Code);
                Page.Title = lblResourceTitle.Text = " آخرین خبرهای " + CurResourceSite.Name;
            }
            catch
            {
            }
        }
    }
}