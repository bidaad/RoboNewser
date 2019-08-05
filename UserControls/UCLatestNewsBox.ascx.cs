using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCLatestNewsBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int[] AlpahbetArray = {1,2,3,4,5,6,7,8,9,10};
                rptPagerNews.DataSource = AlpahbetArray;
                rptPagerNews.DataBind();
            }
            catch
            {
            }
        }
    }
}