using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class UCNewsSubscribe : System.Web.UI.UserControl
    {
        protected void btnSendToFriend_Click(object sender, EventArgs e)
        {

            //string Referer = Page.Request.ServerVariables["http_referer"];
            //if (!Referer.StartsWith("https://www.robonewser.com/") && !Referer.StartsWith("http://RoboNewser.com/"))
            //    return;


            //string ToEmail = txtEmail.Text;
            //if (ToEmail.Trim() == "")
            //    return;

            //BOLNews NewsBOL = new BOLNews();
            //string SenderIP = Request.UserHostAddress;
            //string ID = NewsBOL.InsertEmail(ToEmail, SenderIP);

            //UtilDataContext dcUtil = new UtilDataContext();

            //EmailTemplates CurTemplate = dcUtil.EmailTemplates.SingleOrDefault(p => p.Title.Equals("NewsActivation"));
            //if (CurTemplate != null)
            //{
            //    string MsgBody = CurTemplate.Template;

            //    DateTimeMethods dtm = new DateTimeMethods();
            //    MsgBody = CurTemplate.Template;
            //    MsgBody = MsgBody.Replace("[ActivationLink]", "https://www.robonewser.com/News/Activate.aspx?Act=1&ID="+ ID);

            //    Tools tools = new Tools();
            //    bool SendResult = tools.SendEmail(MsgBody, "عضویت در خبرنامه پارست ", "noreply@RoboNewser.com", ToEmail, "", "");
            //    if (SendResult)
            //    {
            //        pnlSendInvitation.Visible = false;
            //        lblInvSent.Visible = true;
            //    }
            //}
        }
    }
}