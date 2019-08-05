using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;
using System.Configuration;
using System.Text.RegularExpressions;

public partial class UserControls_InviteByEmail : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInviteFriends_Click(object sender, EventArgs e)
    {
        int UserCode = Convert.ToInt32(Session["UserCode"]);
        string FriendList = txtFriendList.Text.Trim().Replace("\n","");
        if (FriendList.Trim() == "")
        {
            msg.Text = "لطفا ایمیل دوستتان را وارد کنید";
            return;
        }
        else
        {
            string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
            Tools tools = new Tools();
            UtilDataContext dc = new UtilDataContext();
            UsersDataContext dcUser = new UsersDataContext();
            Users CurUser = dcUser.Users.SingleOrDefault(p => p.Code.Equals(UserCode));

            string[] FriendListArray = FriendList.Split(',');
            EmailTools emailTools = new EmailTools();
            bool SendResult = emailTools.SendEmailToFriends(CurUser.Code, FriendListArray);
            if (SendResult)
            {
                //btnInviteFriends.Visible = false;
                if (FriendListArray.Length > 1)
                    msg.Text = "تمام ایمیلها با موف ارسال شدند";
                else
                    msg.Text = "ایمیل با موفقیت ارسال شد.";
            }
            else
                msg.Text = "هنگام ارسال ایمیل خطایی رخ داده است.";
        }


    }

}
