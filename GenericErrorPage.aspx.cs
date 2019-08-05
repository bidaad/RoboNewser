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

public partial class GenericErrorPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //string MailBody = "Error Page: referer: " + Page.Request.ServerVariables["http_referer"];
            //MailBody += "<br />aspxerrorpath: " + Request["aspxerrorpath"];
            //Tools tools = new Tools();
            //bool SendResult = tools.SendEmail(MailBody, "پارست ::Error ", "bidaad@gmail.com", "", "", "");
        }
        catch
        {
        }
    }
}
