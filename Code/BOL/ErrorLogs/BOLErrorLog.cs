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

public class BOLErrorLogs : BaseBOLErrorLogs, IBaseBOL<ErrorLogs>
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
    public void Insert(string ErrorDesc, System.Nullable<System.DateTime> DateTime, string AbsolutePath, string SectionName)
    {
        try
        {
            ErrorLogs NewObj = new ErrorLogs();
            dataContext.ErrorLogs.InsertOnSubmit(NewObj);
            NewObj.ErrorDesc = ErrorDesc;
            NewObj.ErrorTime = DateTime;
            NewObj.SectionName = SectionName;
            dataContext.SubmitChanges();

            //Tools tools = new Tools();
            //string MailBody = "ERROR:<br />SectionName=" + SectionName + "<br />AbsolutePath=" + AbsolutePath + "<br />ErrorDesc=" + ErrorDesc;
            //bool SendResult = tools.SendEmail(MailBody, "خطا در پارست", "info@RoboNewser.com", "bidaad@gmail.com", "", "");

        }
        catch (Exception err)
        {
            int aa = 1;
        }
    }

}
