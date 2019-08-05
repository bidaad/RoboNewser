using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;
using System.Configuration;

public partial class UserControls_CommentLikes : System.Web.UI.UserControl
{
    int UserCode;
    public string TitleLink;
    protected int _hCItemTypeCode;
    public int HCItemTypeCode
    {
        get
        {
            return _hCItemTypeCode;
        }
        set
        {
            _hCItemTypeCode = value;
        }
    }
    protected int _itemCode;
    public int ItemCode
    {
        get
        {
            return _itemCode;
        }
        set
        {
            _itemCode = value;
        }
    }
    protected string _params;
    public string Params
    {
        get
        {
            return _params;
        }
        set
        {
            _params = value;
        }
    }
    protected int _ownerUserCode;
    public int OwnerUserCode
    {
        get
        {
            return _ownerUserCode;
        }
        set
        {
            _ownerUserCode = value;
        }
    }

    protected bool _loadOnPostBack = false;
    public bool LoadOnPostBack
    {
        get
        {
            return _loadOnPostBack;
        }
        set
        {
            _loadOnPostBack = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["UserCode"] == null)
                this.Visible = false;
            UserCode = Convert.ToInt32(Session["UserCode"]);
            if (!Page.IsPostBack)
            {
                LoadComments(rptComments, _itemCode);
                UtilDataContext dc = new UtilDataContext();
                if (dc.UserItemLikes.Where(p => p.UserCode.Equals(UserCode) && p.ItemCode.Equals(_itemCode)).Count() == 1)
                    btnLike.ImageUrl = "~/images/dislike.png";
                else
                    btnLike.ImageUrl = "~/images/like.png";
            }
            else if (_loadOnPostBack)
                LoadComments(rptComments, _itemCode);
        }
        catch (Exception exp)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(exp.Message, DateTime.Now, Request.Url.AbsolutePath, "CommentLiks::Load");
        }


    }
    public bool ShowDelVisibility(object obj)
    {
        if (obj == null)
            return false;
        int CommenterCode = Convert.ToInt32(obj);
        if (UserCode == CommenterCode)
            return true;
        else
            return false;
    }
    public string ShowPic(Object obj)
    {
        string Result = "";
        if (obj != null)
        {
            Result = ResolveUrl("~/Files/Users/" + obj.ToString());
        }
        else
            Result = ResolveUrl("~/Files/Users/man_icon.gif");
        return Result;
    }
    protected void HandleRepeaterCommand(object source, RepeaterCommandEventArgs e)
    {
        string CommentID = "";
        UtilDataContext dc = new UtilDataContext();
        LinkButton btnDeleteComment = (LinkButton)e.Item.Controls[1].FindControl("btnDeleteComment");

        int UserCode = Convert.ToInt32(Session["UserCode"]);
        LinkButton hplTitle = (LinkButton)e.Item.Controls[1].FindControl("hplTitle");


        #region DeleteComment
        if (e.CommandName == "DeleteComment")
        {
            CommentID = btnDeleteComment.Attributes["CommentID"];
            UserItemComments CurItemComment = dc.UserItemComments.SingleOrDefault(p => p.ID.Equals(CommentID));
            if (CurItemComment != null)
            {
                dc.UserItemComments.DeleteAllOnSubmit(dc.UserItemComments.Where(p => p.Code.Equals(CurItemComment.Code)));
                dc.SubmitChanges();

                LoadComments((Repeater)source, (int)CurItemComment.ItemCode);
            }
        }
        #endregion


    }

    protected void btnSendComment_Click(object sender, EventArgs e)
    {
        UtilDataContext dc = new UtilDataContext();
        UserItemComments NewComment = new UserItemComments();
        dc.UserItemComments.InsertOnSubmit(NewComment);
        NewComment.ItemCode = _itemCode;
        NewComment.UserCode = UserCode;
        NewComment.HCItemTypeCode = _hCItemTypeCode;
        NewComment.Comment = txtComment.Text;
        NewComment.CommentDate = DateTime.Now;
        NewComment.ID = Tools.GetRandID();
        dc.SubmitChanges();
        txtComment.Text = "";

        string SiteDomain = ConfigurationSettings.AppSettings["SiteDomain"];
        if (_hCItemTypeCode == 3)//Photos
        {
            UsersDataContext dcUser = new UsersDataContext();
            Users OwnerUser = dcUser.Users.SingleOrDefault(p => p.Code.Equals(_ownerUserCode));
            string OwnerUserFullName = OwnerUser.FirstName + " " + OwnerUser.LastName;

            if (OwnerUser != null)
            {
            }
            BOLUserActions UserActionsBOL = new BOLUserActions();
            UserActionsBOL.NewAction(UserCode, "<a href='" + SiteDomain + "Users/Profile.aspx?ID=" + Session["UserID"] + "'>" + Session["FirstName"] + " " + Session["LastName"] + "</a> نظر جدیدی روی عکس <a href='" + SiteDomain + "Users/Profile.aspx?ID=" + OwnerUser.ID + "'>" + OwnerUserFullName + "</a> <a href='Users/ShowPhoto.aspx?ID=" + _params + "'>" + " ارسال کرده است.</a>", 7);
        }

        LoadComments(rptComments, _itemCode);
    }

    protected void btnComment_Click(object sender, EventArgs e)
    {
        LoadComments(rptComments, _itemCode);
        if (!pnlLikes.Visible)
        {
            txtComment.Visible = true;
            pnlLikes.Visible = true;
            btnSendComment.Visible = true;
        }
        else
        {
            pnlLikes.Visible = false;
        }
    }
    protected void btnLike_Click(object sender, EventArgs e)
    {
        UserCode = Convert.ToInt32(Session["UserCode"]);

        UtilDataContext dc = new UtilDataContext();
        UserItemLikes NewLike = new UserItemLikes();
        NewLike = new UserItemLikes();
        NewLike.UserCode = UserCode;
        NewLike.HCItemTypeCode = _hCItemTypeCode;
        NewLike.ItemCode = _itemCode;
        if (btnLike.ImageUrl == "/images/like.png")
        {
            dc.UserItemLikes.InsertOnSubmit(NewLike);
            lblLikeCaption.Text = "شما به این مطلب اطعار علاقه کرده اید";
            btnLike.ImageUrl = "~/images/dislike.png";
            pnlLikes.Visible = true;
        }
        else
        {
            dc.UserItemLikes.DeleteAllOnSubmit(dc.UserItemLikes.Where(p => p.ItemCode.Equals(_itemCode) && p.UserCode.Equals(UserCode)));
            lblLikeCaption.Text = "";
            btnLike.ImageUrl = "~/images/like.png";
            pnlLikes.Visible = false;
        }
        dc.SubmitChanges();
    }


    protected void LoadComments(Repeater rptComments, int ItemCode)
    {
        UtilDataContext dc = new UtilDataContext();
        rptComments.DataSource = dc.vUserItemComments.Where(p => p.ItemCode.Equals(ItemCode) && p.HCItemTypeCode.Equals(_hCItemTypeCode));
        rptComments.DataBind();
    }
}
