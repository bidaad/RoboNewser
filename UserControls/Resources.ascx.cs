using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GBN.Web.UI.UserControls
{
    public partial class Resources : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BOLResourceSites ResourceSitesBOL = new BOLResourceSites();
                rptReasources.DataSource = ResourceSitesBOL.GetActiveList();
                rptReasources.DataBind();
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCResources::Load");
            }
        }
    }
}