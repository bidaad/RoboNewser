using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RoboNewser.Code.DAL;

public partial class Sites_Direct_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        return;

        string SiteID = Request["SiteID"];
        if (SiteID != null)
        {
            SitesDataContext dc = new SitesDataContext();
            AllSites CurSite = dc.AllSites.SingleOrDefault(p => p.ID.Equals(SiteID));
            if (CurSite != null)
            {
                CurSite.VisitCount++;
                dc.SubmitChanges();
                Response.Redirect("http://" + CurSite.Url);
            }
        }

    }
}
