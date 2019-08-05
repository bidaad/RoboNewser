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

public class BOLUserADSs : BaseBOLUserADSs, IBaseBOL<UserADSs>
{
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

    public IQueryable<vRandUserADSs> GetRandAds(int? TakeCount)
    {
        UsersDataContext dc = new UsersDataContext();
        IQueryable<vRandUserADSs> Result;
        if(TakeCount != null)
            Result = dc.vRandUserADSses.Take((int)TakeCount);
        else
            Result = dc.vRandUserADSses;
        string CodeList = "";
        foreach (var item in Result)
        {
            if (CodeList == "")
                CodeList = item.Code.ToString();
            else
                CodeList = CodeList + "," + item.Code;
        }
        //if(CodeList != "")
        //    dataContext.spUpdateUserADSViewNum(CodeList);
        return Result;

    }

    public void IncrementClickNum(int Code)
    {
        UserADSs CurRecord = dataContext.UserADSses.SingleOrDefault(p => p.Code.Equals(Code));
        if (CurRecord != null)
        {
            if(CurRecord.ClickNum == null)
                CurRecord.ClickNum = 1;
            else
                CurRecord.ClickNum++;
            dataContext.SubmitChanges();
        }
    }

    public int Insert(int HCAccountBankNameCode, string FishNo, string TextADS, string Link, string Title, int UserCode)
    {
        try
        {
            UserADSs NewRecord = new UserADSs();
            dataContext.UserADSses.InsertOnSubmit(NewRecord);
            NewRecord.HCAccountBankNameCode = HCAccountBankNameCode;
            NewRecord.FishNo = FishNo;
            NewRecord.Description = TextADS;
            NewRecord.Link = Link;
            NewRecord.Title = Title;
            NewRecord.UserCode = UserCode;
            NewRecord.Active = false;

            dataContext.SubmitChanges();
            return NewRecord.Code;
        }
        catch
        {
            return -1;
        }
    }
}
