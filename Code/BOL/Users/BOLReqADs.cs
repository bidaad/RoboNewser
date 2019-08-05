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

public class BOLReqADs : BaseBOLReqADs, IBaseBOL<ReqADs>
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

    public int Insert(string Name, int HCAccountBankNameCode, string FishNo, string TextADS, string Link, string Title, int UserCode)
    {
        try{
        ReqADs NewRecord = new ReqADs();
        dataContext.ReqADs.InsertOnSubmit(NewRecord);
        NewRecord.Name = Name;
        NewRecord.HCAccountBankNameCode = HCAccountBankNameCode;
        NewRecord.FishNo = FishNo;
        NewRecord.ADSText = TextADS;
        NewRecord.Link = Link;
        NewRecord.Title = Title;
        NewRecord.UserCode = UserCode;
        dataContext.SubmitChanges();
        return NewRecord.Code;
        }
        catch
        {
            return -1;
        }
    }
}
