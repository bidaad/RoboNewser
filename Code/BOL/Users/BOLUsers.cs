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
using RoboNewser.Code.DAL;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;

/// <summary>
/// Summary description for BOLUsers
/// </summary>
public partial class BOLUsers : BaseBOLUsers, IBaseBOL<Users>
{
    public Users GetDataByUsername(string Username)
    {
        Users ValidUser = dataContext.Users.SingleOrDefault(p => p.Email.Equals(Username));
        return ValidUser;
    }

    public System.Linq.IQueryable<vUserAccess> GetUserAccess(int Code)
    {
        var AccList = from u in dataContext.vUserAccesses
                      where u.UserCode.Equals(Code)
                      select u;
        return AccList;
    }


    public System.Linq.IQueryable<vUserAccess> GetUserAccessByBaseID(int Code,string BaseID)
    {
        if(BaseID != null)
        return from u in dataContext.vUserAccesses
                      where u.UserCode.Equals(Code) && u.ResName.StartsWith(BaseID)
                      select u;
        else
            return from u in dataContext.vUserAccesses
                   where u.UserCode.Equals(Code) && (u.TypeCode.Equals(1) || u.TypeCode.Equals(2))
                   select u;

    }

    public IList CheckBusinessRules()
    {
        var messages = new List<string>();
        //Business rules here

        if (false)
            messages.Add("");

        return messages;
    }




    public Users GetUserByID(string ID)
    {
        UsersDataContext dc = new UsersDataContext();
        Users CurUser = dc.Users.SingleOrDefault(p => p.ID.Equals(ID));
        return CurUser;
    }

    public void ActivateUser(int Code)
    {
        UsersDataContext dc = new UsersDataContext();
        Users CurUser = dc.Users.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurUser != null)
        {
            CurUser.Active = true;
            dc.SubmitChanges();
        }
    }

    public bool EmailExists(string Email)
    {
        IQueryable<Users> Result = dataContext.Users.Where(p => p.Email.Equals(Email));
        if (Result.Count() > 0)
            return true;
        else
            return false;
    }

    public object GetList(int StartIndex, int PageSize)
    {
        int SkipCount = (StartIndex - 1) * PageSize;
        return dataContext.vUsers.OrderByDescending(p => p.Code).Skip(SkipCount).Take(PageSize);
    }

    internal int GetBalanace(int UserCode)
    {

        AccessLevelDataContext dataContext = new AccessLevelDataContext();
        int? Balance = dataContext.fnGetUserBalance(UserCode);
        if (Balance != null)
            return (int)Balance;
        else
            return 0;
    }

    internal void DeleteFriend(int UserCode, int FriendCode)
    {
        try
        {
            UsersDataContext dataContext = new UsersDataContext();
            UserFriends CurRelation = dataContext.UserFriends.SingleOrDefault(p => p.UserCode.Equals(UserCode) && p.FriendCode.Equals(FriendCode));
            dataContext.UserFriends.DeleteOnSubmit(CurRelation);
            dataContext.SubmitChanges();

            CurRelation = dataContext.UserFriends.SingleOrDefault(p => p.UserCode.Equals(FriendCode) && p.FriendCode.Equals(UserCode));
            dataContext.UserFriends.DeleteOnSubmit(CurRelation);
            dataContext.SubmitChanges();
        }
        catch
        {
        }

    }

    internal int GetBalance(int UserCode)
    {
        int? UserBalance = dataContext.fnGetUserBalance(UserCode);
        if (UserBalance == null)
            UserBalance = 0;
        return (int)UserBalance;
    }

    internal int GetUserBalance(int UserCode)
    {
        int? Result = dataContext.fnGetUserBalance(UserCode);
        if (Result == null)
            return 0;
        else
            return (int)Result;
    }

    internal static void UpdateLastLoginTime(int Code)
    {
        try
        {
            UsersDataContext dc = new UsersDataContext();
            Users CurUser = dc.Users.SingleOrDefault(p => p.Code.Equals(Code));
            CurUser.LastLoginTime = DateTime.Now;
            dc.SubmitChanges();
        }
        catch
        {
        }
    }
}
