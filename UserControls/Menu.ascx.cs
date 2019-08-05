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

public partial class UserControls_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string ShowEngRoboNewser()
    {
        /*
        Tools tools = new Tools();
        if (!tools.IsIranianIP())
        {
            string EngRoboNewserItem = @"<li class=""NewStar""><a target-'_blank' href='http://en.RoboNewser.com'>اخبار انگلیسی<a></li>";
            return EngRoboNewserItem;
        }
        else
            return "";
         * */
        return "";

    }
}
