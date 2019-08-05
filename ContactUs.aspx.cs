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

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (!RadCaptcha1.IsValid)
        {
            msgText.Text = "security code in invalid";
            msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
            return;
        }
        string FromName = txtName.Text;
        string Email = txtEmail.Text;
        string Comment = txtComment.Text;

        string MailBody = "";
        MailBody = "<b>From:</b>" + FromName + "<BR>";
        MailBody += "<b>Comment: </b>" + Comment.Replace("\n", "<br>");

        Tools tools = new Tools();
        bool SendResult = tools.SendEmail(Email + " " + MailBody, "RoboNewser Contact" + FromName, "info@RoboNewser.com", "bidaad@gmail.com", "", "");
        if (SendResult)
        {
            BOLEmails EmailsBOL = new BOLEmails();
            EmailsBOL.Insert(Email, 5, Comment);
            pnlSend.Visible = false;
            msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
            msgText.Text = "Your message sent.";
        }
        else
        {
            msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
            msgText.Text = "error occured";

        }

    }
}
