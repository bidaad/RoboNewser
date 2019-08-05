using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCNewsItems : System.Web.UI.UserControl
    {
        protected int _pageNo;
        public int PageNo
        {
            set
            {
                _pageNo = value;
            }
            get
            {
                return _pageNo;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BOLNews NewsBOL = new BOLNews();
                IQueryable<vLatestNews> ItemList = NewsBOL.GetLatestNews(10, _pageNo);
                rptNews.DataSource = ItemList;
                rptNews.DataBind();
            }
            catch
            {
            }

        }
    }
}