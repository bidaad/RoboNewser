using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser
{
    public partial class Mobile1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLLogs LogsBOL = new BOLLogs();
            LogsBOL.LogRequest();

        }
    }
}