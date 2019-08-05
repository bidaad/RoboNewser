using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class News_Default : System.Web.UI.Page
{
    public string Keyword;
    protected void Page_Load(object sender, EventArgs e)
    {
        string UserAgent = Request.UserAgent;

        if (!Page.IsPostBack)
        {
            //tnMostVisited.ShowLatestTextNews(100);

            try
            {
                BOLNews NewsBOL = new BOLNews();

                Keyword = Request["Keyword"];
                if (string.IsNullOrEmpty(Keyword))
                    NewsList1.ShowPicNews();
                //else
                //NewsList1.SearchNews(Keyword);

                rptRoboNewserPicNews.Visible = true;
                rptRoboNewserPicNews.DataSource = NewsBOL.GetRandPicNews(4);
                rptRoboNewserPicNews.DataBind();
            }

            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "News_Default::Load");
            }
        }

    }
}