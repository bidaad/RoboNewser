using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class UserControls_UserComments : System.Web.UI.UserControl
{
    protected int _hCSiteSectionCode;
    public int HCSiteSectionCode
    {
        set
        {
            _hCSiteSectionCode = value;
        }
    }

    protected string _headerTitle;
    public string HeaderTitle
    {
        set
        {
            _headerTitle = lblHeader.Text = value;
        }
    }
    public string TimeAgo(Object obj)
    {
        string Result = "";
        if (obj != null)
        {
            DateTime CommentDate = Convert.ToDateTime(obj);
            DateTime CurDateTime = DateTime.Now;
            TimeSpan DifDateTime = CurDateTime.Subtract(CommentDate);
            string SecDif = DifDateTime.Seconds.ToString();
            string MinDif = DifDateTime.Minutes.ToString();
            string HourDif = DifDateTime.Hours.ToString();
            string DayDif = DifDateTime.Days.ToString();
            if (MinDif == "0")
                Result = SecDif + " ثانیه ";
            else if (HourDif == "0")
            {
                Result += MinDif + " دقیقه ";
                if (SecDif != "0")
                    Result += "و " + SecDif + " ثانیه ";
            }
            else if (DayDif == "0")
            {
                Result += HourDif + " ساعت ";
                if (MinDif != "0")
                    Result += "و " + MinDif + " دقیقه ";
                if (SecDif != "0")
                    Result += "و " + SecDif + " ثانیه ";
            }
            else if (Convert.ToInt32(DayDif) > 365)
            {
                Result += " بیش از یکسال ";
            }
        }
        Result += " پیش ";
        Result = Tools.ConvertToUnicode(Result);
        return Result;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["Comment"] != null)
                txtComment.Text = Session["Comment"].ToString();
        }
        LoadComments();

    }

    private void LoadComments()
    {
        try
        {
            if (((HiddenField)Page.Master.FindControl("hfItemCode")).Value != "")
            {
                int ItemCode = Convert.ToInt32(((HiddenField)Page.Master.FindControl("hfItemCode")).Value);
                BOLUserComments UserCommentsBOL = new BOLUserComments(1);
                rptComments.DataSource = UserCommentsBOL.GetByItemCode(ItemCode, _hCSiteSectionCode);
                rptComments.DataBind();
            }
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCComments::LoadComments");
        }
    }
    protected void btnNewComment_Click(object sender, EventArgs e)
    {
        if (Session["UserCode"] == null)
        {
            Session["Comment"] = txtComment.Text;
            Response.Redirect("~/Users/Login.aspx");
        }
        else
        {

            if (txtComment.Text.Trim() == "")
            {
                lblMessage.Text = "نظر نباید خالی باشد";
                return;
            }
            if (((HiddenField)Page.Master.FindControl("hfItemCode")).Value != "")
            {
                int ItemCode = Convert.ToInt32(((HiddenField)Page.Master.FindControl("hfItemCode")).Value);
                int UserCode = Convert.ToInt32(Session["UserCode"]);
                BOLUserComments UserCommentsBOL = new BOLUserComments(UserCode);
                UserCommentsBOL.Insert(UserCode, _hCSiteSectionCode, ItemCode, txtComment.Text, DateTime.Now, true);
                lblMessage.Text = "نظر شما ثبت شد.";
                txtComment.Text = "";
                LoadComments();

            }
        }
    }
}
