using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class News3Col : System.Web.UI.UserControl
    {
        public void LoadPicNews()
        {
            try
            {
                BOLNews NewsBOL = new BOLNews();
                var NewList = NewsBOL.LoadPicNews(20);
                rptNews61.DataSource = NewList.Skip(0).Take(6);
                rptNews61.DataBind();

                rptNews41.DataSource = NewList.Skip(6).Take(4);
                rptNews41.DataBind();

                rptNews62.DataSource = NewList.Skip(10).Take(6);
                rptNews62.DataBind();

                rptNews42.DataSource = NewList.Skip(16).Take(4);
                rptNews42.DataBind();
            }
            catch
            {

            }

        }
    }
}