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

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cookies["RoboNewser"].Expires = DateTime.Now;
        Response.Cookies["RoboNewser"]["RoboNewserUser"] = "";
        Response.Cookies["RoboNewser"].Expires = DateTime.Now;
        Response.Cookies["RoboNewser"]["RoboNewserPass"] = "";


        Session.Abandon();
        Response.Redirect("~/");

    }
}
