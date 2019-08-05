using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class UserControls_RandUsers : System.Web.UI.UserControl
{
    const int CachingTime = 15;

    protected int _randNum = 4;
    public int RandNum
    {
        set
        {
            _randNum = value;
            dtlUsers.RepeatColumns = value / 3;
        }
        get
        {
            return _randNum;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            IQueryable<vRandUsers> Result;

            HttpContext context = HttpContext.Current;
            if (context.Cache["RandUsers"] == null)
            {
                UsersDataContext dc = new UsersDataContext();
                Result = dc.vRandUsers.Take(_randNum);
                context.Cache.Insert("RandUsers", Result, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
            }
            Result = (IQueryable<vRandUsers>)context.Cache["RandUsers"];


            dtlUsers.DataSource = Result;
            dtlUsers.DataBind();
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCRandUsers::Load");
        }

    }
    public string ShowPic(Object obj, Object objGender)
    {
        string Result = "";
        if (obj != null)
        {
            Result = "<img src='" + ResolveUrl("~/Files/Users/" + obj.ToString()) + "' />";
        }
        else if (objGender != null)
        {
            if (Convert.ToInt32(objGender) == 1)
                Result = "<div class='Man'></div>";
            else
                Result = "<div class='Woman'></div>";
        }

        return Result;
    }


}
