using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCMostVisitedNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BOLNews NewsBOL = new BOLNews();

                rptMVNews12h.DataSource = NewsBOL.GetMostVisited12h(10);
                rptMVNews12h.DataBind();

            }
            catch (Exception err)
            {
                //BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                //ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCMostVisitedNews::Load");
            }

        }
    }
}