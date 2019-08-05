using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser
{
    public partial class Roles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BOLHardCode HardcodeBOL = new BOLHardCode();
            rptKeywords.DataSource = HardcodeBOL.GetHCDataTable("HCKeywordTypes");
            rptKeywords.DataBind();
        }
    }
}