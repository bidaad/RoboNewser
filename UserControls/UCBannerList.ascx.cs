using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.UserControls
{
    public partial class UCBannerList : System.Web.UI.UserControl
    {
        protected string _positionCode = "13";
        public string PositionCode
        {
            get
            {
                return _positionCode;
            }
            set
            {
                _positionCode = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            BOLBanners BannersBOL = new BOLBanners();
            rptBanners.DataSource = BannersBOL.GetBannersByPositionCode(_positionCode).Take(4);
            rptBanners.DataBind();
            }
            catch (Exception err)
            {
                BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
                ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCBannerList::Load");
            }
        }
    }
}