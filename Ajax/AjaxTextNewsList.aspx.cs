using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace RoboNewser.Ajax
{
    public partial class AjaxTextNewsList : System.Web.UI.Page
    {
        public string strPageNo;
        int PageNo = 1;
        int _pageSize = 50;
        string ConcatUrl;
        public int ItemCount;
        public int GeneretedRandCount = 0;
        public int RandNum;
        private NewsTypes _newsType = NewsTypes.MostVisited;

        public NewsTypes NewsType
        {
            get
            {
                return _newsType;
            }
            set
            {
                _newsType = value;
            }
        }

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowLatestTextNews(20);
        }


        public void ShowLatestTextNews(int? MaxLen)
        {
            strPageNo = Request["PageNo"];
            try
            {
                PageNo = Convert.ToInt32(strPageNo);
            }
            catch
            {
            }
            if (PageNo == 0)
                PageNo = 1;


            PageNo = 1;
            BOLNews NewsBOL = new BOLNews();
            if (_newsType == NewsTypes.RandNews)
            {
                IQueryable<vRandTextNews> ItemList = NewsBOL.GetLatestTextNews(_pageSize, PageNo, MaxLen);
                ItemCount = ItemList.Count();

                rptNewsList.DataSource = ItemList;
                rptNewsList.DataBind();
            }
            else
            {
 
                rptNewsList.DataSource = NewsBOL.GetMostVisitedTextNews(_pageSize, PageNo, MaxLen);
                rptNewsList.DataBind();
            }

        }

    }
}