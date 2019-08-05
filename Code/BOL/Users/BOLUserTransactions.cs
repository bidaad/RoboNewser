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

public class BOLUserTransactions : BaseBOLUserTransactions, IBaseBOL<UserTransactions>
{

    public BOLUserTransactions(params int[] MCodes) : base(MCodes)
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


    public int InsertRecord(int? UserCode, int HCPayMethodCode, DateTime ChargeDate, int HCTransStatusCode, string BankName, string BankState, string Comment, string FishNo, DateTime? PayDate, string UserIP, string DigitalSignature, int? BankCode, string Authority)
    {
        UserTransactions NewTransaction = new UserTransactions();
        dataContext.UserTransactions.InsertOnSubmit(NewTransaction);
        NewTransaction.UserCode = UserCode;
        NewTransaction.HCPayMethodCode = HCPayMethodCode;
        NewTransaction.ChargeDate = ChargeDate;
        NewTransaction.HCTransStatusCode = 1;
        NewTransaction.BankName = BankName;
        NewTransaction.BankState = BankState;
        NewTransaction.Comment = Comment;
        NewTransaction.FishNo = FishNo;
        NewTransaction.DigitalSignature = DigitalSignature;
        if(BankCode != null)
            NewTransaction.BankCode = BankCode;
        NewTransaction.Authority = Authority;
        if (PayDate != null)
            NewTransaction.PayDate = (DateTime)PayDate;
        NewTransaction.UserIP = UserIP;
        dataContext.SubmitChanges();
        return NewTransaction.Code;
    }

    public vUserTransactions GetTransByAuthority(string Authority)
    {
        return dataContext.vUserTransactions.SingleOrDefault(p => p.Authority.Equals(Authority));
    }

    public vUserTransactions GetTransByFactorNo(int BuyCode)
    {
        return dataContext.vUserTransactions.SingleOrDefault(p => p.Code.Equals(BuyCode));
    }

    public void ChangeStatus(int Code, int HCTransStatusCode)
    {
        UserTransactions CurTrans = dataContext.UserTransactions.SingleOrDefault(p => p.Code.Equals(Code));
        CurTrans.HCTransStatusCode = HCTransStatusCode;
        dataContext.SubmitChanges();
    }

    public void UpdateTrans(int Code, string Authority, string BankName, string BankState, string Comment, string DigitalSignature,
        string FishNo, string UserIP, int? BankCode, int? HCPayMethodCode, int? HCTransStatusCode, DateTime? ChargeDate, DateTime? PayDate)
    {
        UserTransactions CurTrans = dataContext.UserTransactions.SingleOrDefault(p => p.Code.Equals(Code));
        CurTrans.Authority = Authority;
        CurTrans.BankName = BankName;
        CurTrans.Comment = Comment;
        CurTrans.DigitalSignature = DigitalSignature;
        CurTrans.FishNo = FishNo;
        CurTrans.UserIP = UserIP;
        CurTrans.BankCode = BankCode;
        CurTrans.HCPayMethodCode = (int)HCPayMethodCode;
        CurTrans.HCTransStatusCode = HCTransStatusCode;
        CurTrans.ChargeDate = (DateTime)ChargeDate;
        CurTrans.PayDate = PayDate;

        dataContext.SubmitChanges();

    }

    internal int Insert(int? UserCode, DateTime? ChargeDate, int HCTransStatusCode, int? HCPayMethodCode, string UserIP, int Amount, int HCPayReasonCode,int? BankCode)
    {
        try
        {

            UserTransactions NewRecord = new UserTransactions();
            dataContext.UserTransactions.InsertOnSubmit(NewRecord);
            if (UserCode != null)
                NewRecord.UserCode = (int)UserCode;
            if (ChargeDate != null)
                NewRecord.ChargeDate = (DateTime)ChargeDate;
            NewRecord.HCTransStatusCode = HCTransStatusCode;
            NewRecord.UserIP = UserIP;
            NewRecord.Amount = Amount;
            NewRecord.BankCode = BankCode;
            NewRecord.PayDate = ChargeDate;
            if (HCPayMethodCode != null)
                NewRecord.HCPayMethodCode = (int)HCPayMethodCode;
            NewRecord.HCPayReasonCode = (int)HCPayReasonCode;
            dataContext.SubmitChanges();

            return NewRecord.Code;
        }
        catch(Exception err)
        {
            //HttpContext.Current.Response.Write(err.Message);
            return -1;
        }
    }

    internal int Insert(int? UserCode, DateTime? ChargeDate, int HCTransStatusCode, int? HCPayMethodCode, string UserIP, int Amount, int HCPayReasonCode, int? BankCode, string Name, string Email, string Comment)
    {
        try
        {
            UserTransactions NewRecord = new UserTransactions();
            dataContext.UserTransactions.InsertOnSubmit(NewRecord);
            if (UserCode != null)
                NewRecord.UserCode = (int)UserCode;
            if (ChargeDate != null)
                NewRecord.ChargeDate = (DateTime)ChargeDate;
            NewRecord.HCTransStatusCode = HCTransStatusCode;
            NewRecord.UserIP = UserIP;
            NewRecord.Amount = Amount;
            NewRecord.BankCode = BankCode;
            NewRecord.PayDate = ChargeDate;

            NewRecord.Name = Name;
            NewRecord.Email = Email;
            NewRecord.Comment = Comment;

            if (HCPayMethodCode != null)
                NewRecord.HCPayMethodCode = (int)HCPayMethodCode;
            NewRecord.HCPayReasonCode = (int)HCPayReasonCode;
            dataContext.SubmitChanges();

            return NewRecord.Code;
        }
        catch (Exception err)
        {
            //HttpContext.Current.Response.Write(err.Message);
            return -1;
        }
    }


    internal object GetUserTrans(int UserCode)
    {
        return dataContext.vUserTransactions.Where(p => p.UserCode.Equals(UserCode) && (p.HCTransStatusCode.Equals(2) || (p.HCTransStatusCode.Equals(1) && p.HCPayReasonCode.Equals(1)))).OrderByDescending(p => p.Code);
    }
}
