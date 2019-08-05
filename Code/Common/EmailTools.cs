using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RoboNewser.Code.DAL;
using System.Configuration;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for EmailTools
/// </summary>
public class EmailTools
{
	public EmailTools()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool SendAddFriendMessage(Users FromUser, Users ToUser)
    {
        bool SendResult = false;
        if (Tools.GetValue(ToUser.IAddMeAsFriend))
        {
            UtilDataContext dcUtil = new UtilDataContext();
            UsersDataContext dcUser = new UsersDataContext();
            EmailTemplates CurTemplate = dcUtil.EmailTemplates.SingleOrDefault(p => p.Title.Equals("AddFriend"));
            if (CurTemplate != null)
            {
                string UserImageUrl;
                string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
                Tools tools = new Tools();
                string MsgBody = CurTemplate.Template;
                string MessageUrl = SiteDomain + "Default.aspx?AF=1";
                if (FromUser.PicFile == null || FromUser.PicFile == "")
                    UserImageUrl = SiteDomain + "Files/Users/man_icon.gif";
                else
                    UserImageUrl = SiteDomain + "Files/Users/" + FromUser.PicFile;
                string RemoveEmailUrl = SiteDomain + "Users/Setting.aspx";

                if (CurTemplate != null)
                {
                    int FriendCount = dcUser.UserFriends.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                    int PhotoCount = dcUser.vUserAlbumPhotos.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                    MsgBody = CurTemplate.Template;
                    MsgBody = MsgBody.Replace("[UserFullName]", FromUser.FirstName + " " + FromUser.LastName);
                    MsgBody = MsgBody.Replace("[UserFirstName]", FromUser.FirstName);
                    MsgBody = MsgBody.Replace("[UserEmail]", FromUser.Email);
                    MsgBody = MsgBody.Replace("[MessageUrl]", MessageUrl);
                    MsgBody = MsgBody.Replace("[RecFirstName]", ToUser.FirstName);
                    MsgBody = MsgBody.Replace("[UserUrl]", SiteDomain + "Users/Profile.aspx?ID=" + FromUser.ID);
                    
                    MsgBody = MsgBody.Replace("[ImageUrl]", UserImageUrl);
                    MsgBody = MsgBody.Replace("[RemoveEmailUrl]", RemoveEmailUrl);
                    MsgBody = MsgBody.Replace("[FriendCount]", FriendCount.ToString());
                    MsgBody = MsgBody.Replace("[PhotoCount]", PhotoCount.ToString());
                }

                string MsgSubject = FromUser.FirstName + " " + FromUser.LastName + " تقاضای دوستی با شما را دارد";
                SendResult = tools.SendEmail(MsgBody, MsgSubject, "noreply@RoboNewser.com", ToUser.Email, "", "");
                BOLEmails EmailsBOL = new BOLEmails();
                EmailsBOL.Insert(ToUser.Email, 3, MsgBody);
            }
        }
        return SendResult;

    }
    public bool SendInvitationMessage(Users FromUser, string Email)
    {
        bool SendResult = false;
        UtilDataContext dcUtil = new UtilDataContext();
        UsersDataContext dcUser = new UsersDataContext();
        EmailTemplates CurTemplate = dcUtil.EmailTemplates.SingleOrDefault(p => p.Title.Equals("Invitation"));
        if (CurTemplate != null)
        {
            string UserImageUrl;
            string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
            Tools tools = new Tools();
            string MsgBody = CurTemplate.Template;
            string MessageUrl = SiteDomain + "?Invited=1&Email=" + Email;
            if (FromUser.PicFile == null || FromUser.PicFile == "")
                UserImageUrl = SiteDomain + "Files/Users/man_icon.gif";
            else
                UserImageUrl = SiteDomain + "Files/Users/" + FromUser.PicFile;
            string RemoveEmailUrl = SiteDomain + "Users/Setting.aspx";

            if (CurTemplate != null)
            {
                MsgBody = CurTemplate.Template;
                MsgBody = MsgBody.Replace("[UserFullName]", FromUser.FirstName + " " + FromUser.LastName);
                MsgBody = MsgBody.Replace("[UserEmail]", FromUser.Email);
                MsgBody = MsgBody.Replace("[MessageUrl]", MessageUrl);
                MsgBody = MsgBody.Replace("[ImageUrl]", UserImageUrl);
                MsgBody = MsgBody.Replace("[RemoveEmailUrl]", RemoveEmailUrl);

                MsgBody = MsgBody.Replace("[UserUrl]", SiteDomain + "Users/Profile.aspx?ID=" + FromUser.ID);

                
                int FriendCount = dcUser.UserFriends.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                int PhotoCount = dcUser.vUserAlbumPhotos.Where(p => p.UserCode.Equals(FromUser.Code)).Count();
                MsgBody = MsgBody.Replace("[FriendCount]", FriendCount.ToString());
                MsgBody = MsgBody.Replace("[PhotoCount]", PhotoCount.ToString());
            }

            string MsgSubject = FromUser.FirstName + " " + FromUser.LastName + " برای شما یک پیام در پارست ارسال کرده است.";
            SendResult = tools.SendEmail(MsgBody, MsgSubject, "<noreply@RoboNewser.com>", Email, "", "");
            BOLEmails EmailsBOL = new BOLEmails();
            EmailsBOL.Insert(Email, 3, MsgBody);
        }
        return SendResult;

    }
    public bool SendEmailToFriends(int UserCode, string[] EmailArray)
    {
        try
        {
            bool AllSuccess = true;
            string CurEmail = "";
            Tools tools = new Tools();
            UsersDataContext dcUser = new UsersDataContext();
            for (int i = 0; i < EmailArray.Length; i++)
            {
                CurEmail = EmailArray[i].Trim();
                if (IsValidEmail(CurEmail))
                {
                    vActiveUsers ExistingUser = dcUser.vActiveUsers.SingleOrDefault(p => p.Email.Equals(CurEmail));
                    if (ExistingUser == null)
                    {
                        string RandKey = tools.GetRandString(50);
                        Invitations NewInvitation = dcUser.Invitations.SingleOrDefault(p => p.Email.Equals(CurEmail) && p.EmailRemoved.Equals(true));
                        if (NewInvitation == null)
                        {
                            #region Send email
                            NewInvitation = new Invitations();
                            NewInvitation.InviterUserCode = UserCode;
                            NewInvitation.Email = CurEmail;
                            NewInvitation.GenKey = RandKey;
                            NewInvitation.HCInvitationsStatusCode = 1;//Invitation sent
                            NewInvitation.EmailRemoved = false;
                            NewInvitation.SendDate = DateTime.Now;
                            dcUser.Invitations.InsertOnSubmit(NewInvitation);
                            dcUser.SubmitChanges();

                            EmailTools emailTools = new EmailTools();
                            Users CurUser = dcUser.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
                            bool SendResult = emailTools.SendInvitationMessage(CurUser, CurEmail);
                            if (!SendResult)
                            {
                                if (AllSuccess)
                                    AllSuccess = false;
                            }
                            #endregion
                        }
                    }
                    else
                    {
                        Users FromUser = dcUser.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
                        Users ToUser = dcUser.Users.SingleOrDefault(p => p.Code.Equals(ExistingUser.Code));
                        BOLUserMessages UserMessagesBOL = new BOLUserMessages();
                        UserMessagesBOL.SendAddFriendMessage(FromUser, ToUser, "");
                    }

                }
            }
            return AllSuccess;
        }
        catch
        {
            return false;
        }
    }
    public bool IsValidEmail(string CurEmail)
    {
        string _pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        Regex r = new Regex(_pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        Match m = r.Match(CurEmail);
        if (m.Success)
            return true;
        else
            return false;
    }
    public bool SendLikeMessage(Users UserWhoLikes,Users UserWhoCommented, string CommentID)
    {
        bool SendResult = false;
        UtilDataContext dcUtil = new UtilDataContext();
        UsersDataContext dcUser = new UsersDataContext();
        EmailTemplates CurTemplate = dcUtil.EmailTemplates.SingleOrDefault(p => p.Title.Equals("LikeComment"));
        if (CurTemplate != null)
        {
            string UserImageUrl;
            string CommentUrl = "";
            string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
            Tools tools = new Tools();
            string MsgBody = CurTemplate.Template;
            if (UserWhoLikes.PicFile == null || UserWhoLikes.PicFile == "")
                UserImageUrl = SiteDomain + "Files/Users/man_icon.gif";
            else
                UserImageUrl = SiteDomain + "Files/Users/" + UserWhoLikes.PicFile;

            CommentUrl = SiteDomain + "Users/Home.aspx?CommentID=" + CommentID;

            if (CurTemplate != null)
            {
                MsgBody = CurTemplate.Template;
                MsgBody = MsgBody.Replace("[RecFirstName]", UserWhoCommented.FirstName);
                MsgBody = MsgBody.Replace("[UserUrl]", SiteDomain + "Users/Profile.aspx?ID=" + UserWhoLikes.ID);
                MsgBody = MsgBody.Replace("[UserFullName]", UserWhoLikes.FirstName + " " + UserWhoLikes.LastName);
                MsgBody = MsgBody.Replace("[UserFirstName]", UserWhoLikes.FirstName);
                MsgBody = MsgBody.Replace("[UserEmail]", UserWhoLikes.Email);
                MsgBody = MsgBody.Replace("[ImageUrl]", UserImageUrl);
                MsgBody = MsgBody.Replace("[CommentUrl]", CommentUrl);
                int FriendCount = dcUser.UserFriends.Where(p => p.UserCode.Equals(UserWhoLikes.Code)).Count();
                int PhotoCount = dcUser.vUserAlbumPhotos.Where(p => p.UserCode.Equals(UserWhoLikes.Code)).Count();
                MsgBody = MsgBody.Replace("[FriendCount]", FriendCount.ToString());
                MsgBody = MsgBody.Replace("[PhotoCount]", PhotoCount.ToString());
            }

            string MsgSubject = UserWhoLikes.FirstName + " " + UserWhoLikes.LastName + " به مطلب ارسالی شما در پارست اظهار علاقه کرده است.";
            SendResult = tools.SendEmail(MsgBody, MsgSubject, "<noreply@RoboNewser.com>", UserWhoCommented.Email, "", "");
            BOLEmails EmailsBOL = new BOLEmails();
            EmailsBOL.Insert(UserWhoCommented.Email, 3, MsgBody);
        }
        return SendResult;

    }
   

    public string LoadTemplate(int Code)
    {
        UtilDataContext dc = new UtilDataContext();
        EmailTemplates CurTemplate = dc.EmailTemplates.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurTemplate != null)
            return CurTemplate.Template;
        else
            return null;
    }


    public string LoadTemplate(string Title)
    {
        UtilDataContext dc = new UtilDataContext();
        EmailTemplates CurTemplate = dc.EmailTemplates.SingleOrDefault(p => p.Title.Equals(Title));
        if (CurTemplate != null)
            return CurTemplate.Template;
        else
            return null;
    }
}
