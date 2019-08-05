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
using System.Collections;
using System.Collections.Generic;
using RoboNewser.Code.DAL;

public class BOLUserComments : BaseBOLUserComments, IBaseBOL<UserComments>
{
    public BOLUserComments(params int[] MCodes)
        : base(MCodes)
    {

    }
    public IList CheckBusinessRules()
    {
        var messages = new List<string>();

        #region Business Rules
        //Example
        //if (string.IsNullOrEmpty(this.FirstName))
        //    messages.Add("Please fill FirstName.");

        #endregion
        return messages;
    }

    public object GetByItemCode(int ItemCode, int HCSiteSectionCode)
    {
        UsersDataContext dc = new UsersDataContext();
        return dc.vUserComments.Where(p => p.ItemCode.Equals(ItemCode) && p.HCSiteSectionCode.Equals(HCSiteSectionCode)).OrderByDescending(d => d.CommentDate);
    }
    public int Insert(int UserCode, int HCSiteSectionCode, int ItemCode, string Comment, DateTime CommentDate, bool Active)
    {
        UsersDataContext dc = new UsersDataContext();
        UserComments NewRecord = new UserComments();
        dc.UserComments.InsertOnSubmit(NewRecord);
        NewRecord.UserCode = UserCode;
        NewRecord.HCSiteSectionCode = HCSiteSectionCode;
        NewRecord.ItemCode = ItemCode;
        NewRecord.Comment = Comment;
        NewRecord.CommentDate = CommentDate;
        NewRecord.Active = Active;
        dc.SubmitChanges();

        return NewRecord.Code;

    }
}
