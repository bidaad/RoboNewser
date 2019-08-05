using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.SessionState;
using RoboNewser.Code.DAL;

public class BOLUserMessages : BaseBOLUserMessages, IBaseBOL<UserMessages>
{

    public int GetMessageCountByStatusCode(int UserCode, int StatusCode)
    {
        return (from m in dataContext.UserMessages
                    .Where(u => u.ToUserCode.Equals(UserCode) && u.HCStatusCode.Equals(StatusCode))
                select m
                    ).Count();
    }

    public IQueryable<vUserMessages> GetUserReceivedMessages(int UserCode,int SkipCount,int PageSize)
    {
        return (from m in dataContext.vUserMessages
            .Where(u => u.ToUserCode.Equals(UserCode) && (u.HCStatusCode.Equals(2) || u.HCStatusCode.Equals(3)))
            .OrderByDescending(u => u.Code)
                select m
            ).Skip(SkipCount).Take(PageSize);
    }
    public int GetUserReceivedMessagesCount(int UserCode, int SkipCount, int PageSize)
    {
        return (from m in dataContext.vUserMessages
            .Where(u => u.ToUserCode.Equals(UserCode) && (u.HCStatusCode.Equals(2) || u.HCStatusCode.Equals(3)))
            .OrderByDescending(u => u.Code)
                select m
            ).Count();
    }
    public IQueryable<vUserMessages> GetUserSentMessages(int UserCode, int SkipCount, int PageSize)
    {
        return (from m in dataContext.vUserMessages
            .Where(u => u.FromUserCode.Equals(UserCode) && (u.HCStatusCode.Equals(2) || u.HCStatusCode.Equals(3)))
            .OrderByDescending(u => u.Code)
                select m
                ).Skip(SkipCount).Take(PageSize);
    }
    public int GetUserSentMessagesCount(int UserCode, int SkipCount, int PageSize)
    {
        return (from m in dataContext.vUserMessages
            .Where(u => u.FromUserCode.Equals(UserCode) && (u.HCStatusCode.Equals(2) || u.HCStatusCode.Equals(3)))
            .OrderByDescending(u => u.Code)
                select m
                ).Count();
    }
    public UserMessages ChangeMessageStatus(int Code, int NewStatus)
    {
        UserMessages UMessage = dataContext.UserMessages.Single(m => m.Code.Equals(Code));
        UMessage.HCStatusCode = NewStatus;
        dataContext.SubmitChanges();
        return UMessage;
    }
    public int ChangeAllUserMessageStatus(int UserCode, int NewStatus)
    {
        IQueryable<UserMessages> UMessage = dataContext.UserMessages.Where(p => p.ToUserCode.Equals(UserCode));
        foreach (var item in UMessage)
        {
            item.HCStatusCode = NewStatus;
        }
        dataContext.SubmitChanges();
        return UMessage.Count();
    }
    public object GetAddFrendReqMessage(int UserCode)
    {
        return (from m in dataContext.vUserMessages
                .Where(u => u.ToUserCode.Equals(UserCode) && u.HCStatusCode.Equals(4))
                .OrderByDescending(u => u.Code)
                select m
                );
    }
    public bool FriendshipRequestSentBefore(int FromUserCode, int ToUserCode)
    {
        UsersDataContext dc = new UsersDataContext();
        var ItemList = from u in dc.UserMessages
                       .Where(u => (u.FromUserCode.Equals(FromUserCode) && u.ToUserCode.Equals(ToUserCode)) &&
                                   (u.HCStatusCode.Equals(4) || u.HCStatusCode.Equals(5)))
                       select u;
        if (ItemList.Count() == 0)
            return false;
        else
            return true;
    }
    public object GetUserHistory(int FromUserCode, int ToUserCode)
    {
        return (from u in dataContext.vUserMessages
            .Where
            (u => (u.HCStatusCode.Equals(1) || u.HCStatusCode.Equals(2)) &&
                   (
                   (u.FromUserCode.Equals(FromUserCode) && u.ToUserCode.Equals(ToUserCode)) ||
                   (u.ToUserCode.Equals(FromUserCode) && u.FromUserCode.Equals(ToUserCode))
                   ))
            .OrderByDescending(u => u.Code)
                select u
            );
    }
    public IQueryable<vUserMessages> GetUserFreindshipRequests(int UserCode)
    {
        return (from u in dataContext.vUserMessages
            .Where(u => (u.HCStatusCode.Equals(1) || u.HCStatusCode.Equals(5)) && u.ToUserCode.Equals(UserCode)).OrderByDescending(u => u.Code)
                select u
            );
    }

    public bool SendAddFriendMessage(Users FromUser, Users ToUser, string AddFriendMessage)
    {
        UsersDataContext dc = new UsersDataContext();
        UserMessages NewMessage = new UserMessages();
        NewMessage.HCStatusCode = 1;
        NewMessage.Message = AddFriendMessage;
        NewMessage.FromUserCode = FromUser.Code;
        NewMessage.SendDate = DateTime.Now;
        NewMessage.ID = Tools.GetRandID();

        NewMessage.Title = FromUser.FirstName + " " + FromUser.LastName + " تقاضای دوستی با شما را دارد.";
        NewMessage.ToUserCode = ToUser.Code;
        dc.UserMessages.InsertOnSubmit(NewMessage);
        dc.SubmitChanges();

        #region Send Email
        EmailTools emailTools = new EmailTools();
        return emailTools.SendAddFriendMessage(FromUser, ToUser);
        #endregion
    }

    internal int GetUserUnreadMessagesCount(int UserCode)
    {
        return dataContext.UserMessages.Where(p => p.ToUserCode.Equals(UserCode) && p.HCStatusCode.Equals(2)).Count();
    }
}
