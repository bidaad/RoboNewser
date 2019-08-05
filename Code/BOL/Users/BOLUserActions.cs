using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RoboNewser.Code.DAL;

/// <summary>
/// Summary description for BOLUserActions
/// </summary>
public class BOLUserActions
{
	public BOLUserActions()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void NewAction(int UserCode, string Comment, int HCActionTypeCode)
    {
        UsersDataContext dc = new UsersDataContext();
        UserActions NewAction = new UserActions();
        dc.UserActions.InsertOnSubmit(NewAction);
        NewAction.UserCode = UserCode;
        NewAction.HCActionTypeCode = HCActionTypeCode;
        NewAction.Comment = Comment;
        NewAction.ID = Tools.GetRandID();
        NewAction.ActionDate = DateTime.Now;
        dc.SubmitChanges();
    }

    public bool IsRecentAction(int UserCode, int HCActionTypeCode)
    {
        UsersDataContext dc = new UsersDataContext();
        //check to see this acction has taken in less than 1 day.
        if (dc.UserActions.Where(p => p.UserCode.Equals(UserCode) && p.HCActionTypeCode.Equals(HCActionTypeCode) && ((DateTime)p.ActionDate).AddDays(1).CompareTo(DateTime.Now) > 0).Count() > 0)
            return true;
        else
            return false;
    }
}
