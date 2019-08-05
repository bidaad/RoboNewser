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
using RoboNewser.Code.DAL;

public partial class UserControls_SendMessage : System.Web.UI.UserControl
{
    private UpdatePanel _upanel;
    public UpdatePanel UpPanel
    {
        set
        {
            _upanel = value;
        }
        get
        {
            return _upanel;
        }
    }
    public string Caption
    {
        set
        {
            txtSMToUser.Text = value;
        }
    }
    //public string PhotoUrl
    //{
    //    set
    //    {
    //        imgPhoto.ImageUrl = value;
    //    }
    //}
    public int ToUserCode
    {
        set
        {
            pnlSendMessage.Visible = true;
            txtMessageSubject.Text = "";
            txtMessageContent.Text = "";
            ViewState["ToUserCode"] = value;
        }
        get
        {
            return Convert.ToInt32(ViewState["ToUserCode"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnCancelSendMessage_Click(object source, EventArgs e)
    {
        pnlSendMessage.Visible = false;
    }

    protected void btnSendMessage_Click(object source, EventArgs e)
    {
        string UserImageUrl;
        int UserCode = (int)Session["UserCode"];
        UsersDataContext dc = new UsersDataContext();
        UserMessages NewMessage = new UserMessages();
        NewMessage.HCStatusCode = 2;
        NewMessage.Message = txtMessageContent.Text;
        NewMessage.FromUserCode = UserCode;
        NewMessage.SendDate = DateTime.Now;
        NewMessage.Title = txtMessageSubject.Text;
        NewMessage.ID = Tools.GetRandID();
        NewMessage.ToUserCode = ToUserCode;
        dc.UserMessages.InsertOnSubmit(NewMessage);
        dc.SubmitChanges();



        string jsScript = @"$('#divSendMessage').modal('hide');";
        ScriptManager.RegisterStartupScript(_upanel, _upanel.GetType(), "divSendMessage", jsScript, true);

        #region Send Email
        UtilDataContext dcUtil = new UtilDataContext();
        Users ToUser = dc.Users.SingleOrDefault(p => p.Code.Equals(ToUserCode));
        EmailTemplates CurTemplate = dcUtil.EmailTemplates.SingleOrDefault(p => p.Title.Equals("SendMessage"));
        if (Tools.GetValue(ToUser.ISendMessage))
        {
            if (CurTemplate != null)
            {
                string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
                Users FromUser = dc.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
                Tools tools = new Tools();
                string MsgBody = CurTemplate.Template;
                string MessageUrl = SiteDomain + "Users/Messages.aspx?ID=" + NewMessage.ID;
                if (FromUser.PicFile == null || FromUser.PicFile == "")
                    UserImageUrl = SiteDomain + "Files/Users/man_icon.gif";
                else
                    UserImageUrl = SiteDomain + "Files/Users/" + FromUser.PicFile;
                string RemoveEmailUrl = SiteDomain + "Users/Setting.aspx";

                MsgBody = MsgBody.Replace("[UserFullName]", Session["FirstName"].ToString() + " " + Session["LastName"].ToString());
                MsgBody = MsgBody.Replace("[UserEmail]", FromUser.Email);
                MsgBody = MsgBody.Replace("[MessageUrl]", MessageUrl);
                MsgBody = MsgBody.Replace("[ImageUrl]", UserImageUrl);
                MsgBody = MsgBody.Replace("[RemoveEmailUrl]", RemoveEmailUrl);

                MsgBody = MsgBody.Replace("[RecFirstName]", ToUser.FirstName);
                MsgBody = MsgBody.Replace("[UserUrl]", SiteDomain + "Users/Profile.aspx?ID=" + FromUser.ID);
                MsgBody = MsgBody.Replace("[UserFirstName]", FromUser.FirstName);

                int FriendCount = dc.UserFriends.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                int PhotoCount = dc.vUserAlbumPhotos.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                MsgBody = MsgBody.Replace("[FriendCount]", FriendCount.ToString());
                MsgBody = MsgBody.Replace("[PhotoCount]", PhotoCount.ToString());


                string MsgSubject = Session["FirstName"].ToString() + " " + Session["LastName"].ToString() + " برای شما یک پیام در پارست ارسال کرده است";
                bool SendResult = tools.SendEmail(MsgBody, MsgSubject, "<noreply@RoboNewser.com>", ToUser.Email, "bidaad@gmail.com", "");
            }
        }
        #endregion



        pnlSendMessage.Visible = false;
    }
}
