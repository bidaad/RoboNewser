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
using RoboNewser.Code.DAL;

public class BOLUserCharges : BaseBOLUserCharges, IBaseBOL<UserCharges>
{
    public BOLUserCharges(params int[] MCodes)
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

    public bool Insert(int UserCode, int? TransactionCode, int Amount, int HCChargeReasonCode, string CouponID)
    {
        try
        {
            UserCharges NewCharge = new UserCharges();
            dataContext.UserCharges.InsertOnSubmit(NewCharge);
            NewCharge.UserCode = UserCode;
            NewCharge.TransactionCode = TransactionCode;
            NewCharge.Amount = Amount;
            NewCharge.HCChargeReasonCode = HCChargeReasonCode;
            NewCharge.CouponID = CouponID;

            dataContext.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    internal object GetUserTrans(int UserCode)
    {
        return dataContext.vUserCharges.Where(p => p.UserCode.Equals(UserCode)).OrderByDescending(p => p.Code);
    }
}
