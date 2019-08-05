using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace DMS.Web.UI.UserControls
{
    public partial class PageTools : System.Web.UI.UserControl
    {
        protected int _itemCode;
        public int ItemCode
        {
            get
            {
                return _itemCode;
            }
            set
            {
                _itemCode = value;
            }
        }
        protected int _hCEntityCode;
        public int HCEntityCode
        {
            get
            {
                return _hCEntityCode;
            }
            set
            {
                _hCEntityCode = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //Stars1.ItemCode = _itemCode;
            //Stars1.HCEntityCode = _hCEntityCode;

        }

        protected void btnSendToFriends_Click(object sender, ImageClickEventArgs e)
        {
            pnlSendEmail.Visible = true;
            string JSCommand = "popup('" + pnlSendEmail.ClientID + "')";
            ScriptManager.RegisterStartupScript(this, typeof(string), "RunPopup", JSCommand, true);
            
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string CurrentUrl = HttpContext.Current.Request.Url.AbsoluteUri;
            string FromName = txtFrom.Text;
            string ToName = txtTo.Text;

            string FromEmail = txtFromEmail.Text;
            string ToEmail = txtToEmail.Text;

            string Message = txtMessage.Text;
            string Subject = "لینک جالب از طرف " + FromName;
            string Body = @"با سلام" + "<br>"
            + " دوست عزیز " + ToName + "<br> فکر میکنم لینک زیر برایت جالب باشد:" + "<br>"
            + CurrentUrl + "<br>"
            + Message + "<br><br>"
            + "پورتال جامع پارسی" + "<br>"
            + "<a href='http://www.RoboNewser.com'>RoboNewser.com</a>";

            Tools tools = new Tools();
            bool SendResult = tools.SendEmail(Body, Subject, FromEmail, ToEmail, "", "");
            if (SendResult)
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                msg.Text = "پیام شما با موفقیت ارسال شد.";
            }
            else
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msg.Text = "متاسفانه در ارسال پیام شما خطایی رخ داده است.";
            }
            pnlSendEmail.Visible = false;
        }

        protected void btnCloseWin_Click(object sender, ImageClickEventArgs e)
        {
            pnlSendEmail.Visible = false;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSendEmail.Visible = false;
        }
    }
}