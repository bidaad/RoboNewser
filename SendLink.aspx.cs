using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace RoboNewser
{
    public partial class SendLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Load Scripts
            HtmlGenericControl script0 = new HtmlGenericControl("script");
            script0.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/jquery.min.js"));
            script0.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script0);

            HtmlGenericControl script23 = new HtmlGenericControl("script");
            script23.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/jquery.ticker.js"));
            script23.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script23);

            HtmlGenericControl script1 = new HtmlGenericControl("script");
            script1.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/jquery-ui.js"));
            script1.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script1);

            HtmlGenericControl script10 = new HtmlGenericControl("script");
            script10.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/jquery.easing.min.1.3.js"));
            script10.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script10);

            HtmlGenericControl script11 = new HtmlGenericControl("script");
            script11.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/jquery.jcontent.0.8.min.js"));
            script11.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script11);

            HtmlGenericControl script12 = new HtmlGenericControl("script");
            script12.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/hoverIntent.js"));
            script12.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script12);

            HtmlGenericControl script13 = new HtmlGenericControl("script");
            script13.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/superfish.js"));
            script13.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script13);

            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/mainv1.2.js"));
            script.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script);

            HtmlGenericControl script2 = new HtmlGenericControl("script");
            script2.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/farsi.js"));
            script2.Attributes.Add("type", "text/javascript");
            Page.Header.Controls.Add(script2);
            #endregion

            if (!Page.IsPostBack)
            {
                string Link = Request["Link"];
                ViewState["Link"] = Link;
            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (ViewState["Link"] == null)
                return;
            string CurrentUrl = ViewState["Link"].ToString();
            string FromName = txtFrom.Text;
            string ToName = txtTo.Text;

            string FromEmail = txtFromEmail.Text;
            string ToEmail = txtToEmail.Text;

            string Message = txtMessage.Text;
            string Subject = "لینک جالب از طرف " + FromName;
            string Body = @"<div style=""direction:rtl;font-family:tahoma;line-height:150%;"">" + @"با سلام" + "<br>"
            + " دوست عزیز " + ToName + "<br> فکر میکنم لینک زیر برایت جالب باشد:" + "<br>"
            + CurrentUrl + "<br>"
            + Message + "<br><br>"
            + "پورتال جامع پارسی" + "<br>"
            + "<a href='http://www.RoboNewser.com'>RoboNewser.com</a></div>";

            Tools tools = new Tools();
            bool SendResult = tools.SendEmail(Body, Subject, FromEmail, ToEmail, "", "");
            if (SendResult)
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                msg.Text = "پیام شما با موفقیت ارسال شد.";
                pnlSendEmail.Visible = false;
            }
            else
            {
                msg.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msg.Text = "متاسفانه در ارسال پیام شما خطایی رخ داده است.";
            }
        }
    }
}