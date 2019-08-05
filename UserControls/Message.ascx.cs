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

public partial class UserControls_Message : System.Web.UI.UserControl
{
    public void ShowMessage(MessageTypes msgType, string Message)
    {
        if (msgType == MessageTypes.Info)
        {
            pnlMessage.Visible = true;
            lblMessage.Text = Message;
            pnlMessage.CssClass = "InfoMessage";
        }
        else if (msgType == MessageTypes.Error)
        {
            pnlMessage.Visible = true;
            lblMessage.Text = Message;
            pnlMessage.CssClass = "ErrorMessage";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }
}
