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
using RoboNewser.Code.DAL;

public partial class UserControls_AddFreind : System.Web.UI.UserControl
{
    private UpdatePanel _upanel;
    public UpdatePanel UpPanel
    {
        set
        {
            _upanel = value;
        }
        get
        {
            return _upanel;
        }
    }

    public string Caption
    {
        set
        {
            lblAddFriend.Text = value;
        }
    }
    public string PhotoUrl
    {
        set
        {
            imgPhoto.ImageUrl = value;
        }
    }
    public string WinTitle
    {
        set
        {
            lblTitle.Text = value;
        }
    }

    public int ToUserCode
    {
        set
        {
            ViewState["ToUserCode"] = value;
        }
        get
        {
            return Convert.ToInt32(ViewState["ToUserCode"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (ToUserCode != 0)
        {
            UsersDataContext dc = new UsersDataContext();
            Users ToUser = dc.Users.SingleOrDefault(p => p.Code.Equals(ToUserCode));
            ltrHeader.Text = "ارسال تقاضای دوستی برای " + ToUser.FirstName + " " + ToUser.LastName;
        }

    }
    protected void btnAddFriend_Click(object source, EventArgs e)
    {
        try{
        //System.Threading.Thread.Sleep(3000);
        //this.Visible = false;
        //return;
        int UserCode = (int)Session["UserCode"];
        UsersDataContext dc = new UsersDataContext();
        Users FromUser = dc.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
        Users ToUser = dc.Users.SingleOrDefault(p => p.Code.Equals(ToUserCode));
        BOLUserMessages UserMessagesBOL = new BOLUserMessages();
        UserMessagesBOL.SendAddFriendMessage(FromUser, ToUser, txtAddFriendMessage.Text);

        this.Visible = false;
        string jsScript = @"$('#divAddFriendReq').modal('hide');";
        ScriptManager.RegisterStartupScript(_upanel, _upanel.GetType(), "ShowAddFriendPanel", jsScript, true);
            
        }
        catch (Exception exp)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(exp.Message, DateTime.Now, Request.Url.AbsolutePath, "AddFriends");
        }

    }
    protected void btnCancel_Click(object source, EventArgs e)
    {
        //AddFriend.ToUserCode = Convert.ToInt32(hfToUserCode.Value);
        this.Visible = false;
    }
}
