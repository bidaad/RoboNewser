using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace RoboNewser.UserControls
{
    public partial class UCNewsCats : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                BOLNews NewsBOL = new BOLNews();
                IQueryable<vLatestNews> LatestNews = NewsBOL.GetLatestNews(1, 1);
                if (LatestNews.Count() == 1)
                {
                    DateTime LatestNewsDateTime = (DateTime)LatestNews.First().NewsDate;
                    lblLatestUpdate.Text = " به روز شده در " + Tools.GetPrettyPersianDate2(LatestNewsDateTime);
                }
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCNewsCats::Load");
            }
             * */

        }
    }
}