using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.News
{
    public partial class Activate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strID = Request["ID"];
            if (strID != null)
            {
                strID = strID.Replace("'", "");
                BOLNews NewsBOL = new BOLNews();
                if (NewsBOL.NewsEmailIDExists(strID))
                {
                    NewsBOL.ActivateNewsEmailID(strID);
                    lblMessage.Text = "عضویت شما در خبرنامه با موفقیت تکمیل شد";
                }
                else
                    lblMessage.Text = "لینک معتبر نیست";
            }
            else
                lblMessage.Text = "لینک معتبر نیست";


        }
    }
}