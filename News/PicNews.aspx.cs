using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace EngRoboNewser.News
{
    public partial class PicNews : System.Web.UI.Page
    {
        public string strPageNo;
        int PageNo = 1;
        int PageSize = 100;
        string ConcatUrl;
        public string ShowPic(object Title, object PicName)
        {
            string Result = "";
            if (PicName != null && PicName != "")
                Result = "<img class=\"cPic3\" src=\"" + Page.ResolveUrl("//static.robonewser.com/Files/News/") + PicName + "\" />";
            return Result;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                strPageNo = Request["PageNo"];

                PageNo = Convert.ToInt32(strPageNo);

                if (PageNo == 0)
                    PageNo = 1;

                if (!Page.IsPostBack)
                {
                    //tnMostVisited.ShowLatestTextNews(100);
                }


                Page.Title = " تصاویر خبری  " + " صفحه " + PageNo;
                BOLNews NewsBOL = new BOLNews();
                int ResultCount = NewsBOL.GetLatestPicNewsCount();
                rptNewsList.DataSource = NewsBOL.GetLatestPicNews(PageSize, PageNo);
                rptNewsList.DataBind();

                int PageCount = ResultCount / PageSize;
                if (ResultCount % PageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "PicNews::Load");
            }
        }
    }
}