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

public partial class Users_UserList : System.Web.UI.UserControl
{
    public string Keyword;
    public string strPageNo;
    int PageNo = 1;
    int PageSize = 20;
    public int Counter = 1;
    string ConcatUrl;
    public string GetClass()
    {
        Counter++;
        if (Counter % 2 == 0)
            return "NRow3";
        else
            return "AltRow3";
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
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Check user access
        Tools.CheckUserAccess();
        #endregion
    }
    public int PassedUserCode;
    public int ShowFriends(int UserCode)
    {
        int SkipCount = 0;

        Keyword = Request["Keyword"];
        strPageNo = Request["PageNo"];
        try
        {
            PageNo = Convert.ToInt32(strPageNo);
        }
        catch
        {
        }
        if (PageNo == 0)
            PageNo = 1;

        PassedUserCode = UserCode;
        UsersDataContext dc = new UsersDataContext();
        ConcatUrl = "&Keyword=" + Keyword + "&ID=" + Request["ID"];
        int ResultCount = 0;

        SkipCount = PageSize * (PageNo - 1);

        IQueryable<vUserFriends> ItemList;
        ItemList = dc.vUserFriends.Where(p => p.UserCode.Equals(UserCode)).Skip(SkipCount).Take(PageSize);
        
        ResultCount = dc.vUserFriends.Where(p => p.UserCode.Equals(UserCode)).Count();

        if (ItemList.Count() > 0)
        {
            string Message = "";
            Message = ResultCount + " نتیجه برای <b>" + Keyword + "</b> پیدا شد.";

            //msgBox.Text = Message;
            Page.Title =  "دوستان کاربر: " + Keyword + " صفحه " + PageNo;
            Users CurUser = dc.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
            if(CurUser != null)
                lblPageTitle.Text = " دوستان " +  CurUser.FirstName + " " + CurUser.LastName ;

            rptItems.DataSource = ItemList;
            rptItems.DataBind();

            int PageCount = ResultCount / PageSize;
            if (ResultCount % PageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();
        }
        else
        {
            if (Keyword != "" && Keyword != null)
                msgBox.Text = " هیجه ای برای <b>" + Keyword + " پیدا نشد </b>";
        }
        return ResultCount;

    }
    public int ShowMutualFriends(int UserCode,int FriendCode)
    {
        UsersDataContext dc = new UsersDataContext();
        ConcatUrl = "&Keyword=" + Keyword;
        int ResultCount = 0;

        int SkipCount = PageSize * (PageNo - 1);

        System.Data.Linq.ISingleResult<spGetMutualFriendsResult> ItemList;
        int LoggedUserCode = Convert.ToInt32(Session["UserCode"]);
        ItemList = dc.spGetMutualFriends(UserCode, FriendCode);

        ResultCount = dc.vUserFriends.Where(p => p.UserCode.Equals(UserCode)).Skip(SkipCount).Count();

        rptItems.DataSource = ItemList;
        rptItems.DataBind();

        if (rptItems.Items.Count > 0)
        {
            string Message = "";
            if (rptItems.Items.Count >= 500)
                Message = " بیشتر از 500 " +  " نتیجه برای <b>" + Keyword + " پیدا شد </b> ";
            else
                Message = ResultCount + " نتیجه برای <b>" + Keyword + " پیدا شد </b>";

            //msgBox.Text = Message;
            Page.Title = "دوستان مشترک:" + " سفحه " + PageNo;
            lblPageTitle.Text = "دوستان مشترک";


            int PageCount = ResultCount / PageSize;
            if (ResultCount % PageSize > 0)
                PageCount++;
            pgrToolbar.PageNo = PageNo;
            pgrToolbar.PageCount = PageCount;
            pgrToolbar.ConcatUrl = ConcatUrl;
            pgrToolbar.PageBind();
        }
        else
        {
            //msgBox.Text = " No results found for <b>" + Keyword + "</b>";
        }
        return ResultCount;

    }
    public int SearchByKeyword(string Keyword)
    {
        UsersDataContext dc = new UsersDataContext();
        ConcatUrl = "&Keyword=" + Keyword;
        int ResultCount = 0;

        if (Keyword == "")
        {
            //msgBox.Text = "Keyword is empty";
        }
        else
        {
            int SkipCount = PageSize * (PageNo - 1);

            string WhereClause = "";
            Keyword = Keyword.Trim();
            IQueryable<vActiveUsers> ItemList;
            string FirstNameSearch = "";
            string LastNameSearch = "";

            if (Keyword.IndexOf(" ") > 0)
            {
                string[] KeywordArray = Keyword.Split(' ');
                if (KeywordArray.Length == 2)
                {
                    FirstNameSearch = KeywordArray[0];
                    LastNameSearch = KeywordArray[1];
                }
                else
                {
                    string RemainKeyword = "";
                    for (int i = 1; i < KeywordArray.Length; i++)
                    {
                        RemainKeyword = RemainKeyword + KeywordArray[i];
                    }
                    FirstNameSearch = KeywordArray[0];
                    LastNameSearch = RemainKeyword;
                }
            }
            else
                LastNameSearch = Keyword;
            ItemList = dc.vActiveUsers.Where(p => p.FirstName.Contains(FirstNameSearch) && p.LastName.Contains(LastNameSearch)).Skip(SkipCount).Take(PageSize);
            ResultCount = dc.vActiveUsers.Where(p => p.FirstName.Contains(FirstNameSearch) && p.LastName.Contains(LastNameSearch)).Count();
            if (ItemList.Count() > 0)
            {
                string Message = "";
                if (ItemList.Count() >= 500)
                    Message = " بیشتر از 500 " +  " نتیجه برای <b>" + Keyword + " پیدا شد</b> ";
                else
                    Message = ResultCount + "  نتیجه برای <b>" + Keyword + " پیدا شد</b>";

                //msgBox.Text = Message;
                Page.Title = "نتایج جستجو برای " + Keyword + " صفحه " + PageNo;
                lblPageTitle.Text = " نتایج جستجو برای \"" + Keyword + "\"";

                rptItems.DataSource = ItemList;
                rptItems.DataBind();

                int PageCount = ResultCount / PageSize;
                if (ResultCount % PageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            else
            {
                msgBox.Text = " هیچ نتیجه ای برای <b>" + Keyword + " پیدا نشد</b>. لطفا نام و نام خانوادگی را وارد کنید";
            }
        }
        return ResultCount;
    }
    public int Search(string FirstName, string LastName, string HCGenderCode, string HCMarritalStatusCode, string HCEducationCode, string HCSmokeCode, string PicFile)
    {
        msgBox.Text = "";
        UsersDataContext dc = new UsersDataContext();
        ConcatUrl = String.Format("&FirstName={0}&LastName={1}&HCGenderCode={2}&HCMarritalStatusCode={3}&HCEducationCode={4}&HCSmokeCode={5}&PicFile={6}", FirstName, LastName, HCGenderCode, HCMarritalStatusCode, HCEducationCode, HCSmokeCode, PicFile);
        int ResultCount = 0;
        string strPageNo = Request["PageNo"];
        if (strPageNo != "" && strPageNo != null)
        {
            PageNo = Convert.ToInt32(strPageNo);
        }

        if (Keyword == "")
        {
            //msgBox.Text = "Keyword is empty";
        }
        else
        {
            int SkipCount = PageSize * (PageNo - 1);

            string WhereClause = "";
            IQueryable<vActiveUsers> ItemList;
            string FirstNameSearch = "";
            string LastNameSearch = "";


            ItemList = dc.vActiveUsers;
            if (FirstName != "")
                ItemList = ItemList.Where(p => p.FirstName.Contains(FirstName));
            if (LastName != "")
                ItemList = ItemList.Where(p => p.LastName.Contains(LastName));
            if (HCGenderCode != "")
                ItemList = ItemList.Where(p => p.HCGenderCode.Equals(HCGenderCode));
            if (HCMarritalStatusCode != "")
                ItemList = ItemList.Where(p => p.HCMarritalStatusCode.Equals(HCMarritalStatusCode));
            if (HCEducationCode != "")
                ItemList = ItemList.Where(p => p.HCEducationCode.Equals(HCEducationCode));
            if (HCSmokeCode != "")
                ItemList = ItemList.Where(p => p.HCSmokeCode.Equals(HCSmokeCode));
            if (PicFile == "1")
                ItemList = ItemList.Where(p => p.PicFile != "");

            ResultCount = ItemList.Count();
            ItemList = ItemList.OrderByDescending(p => p.LastLoginTime);
            ItemList = ItemList.Skip(SkipCount).Take(PageSize);
            //.Where(p => p.FirstName.Contains(FirstNameSearch) && p.LastName.Contains(LastNameSearch)).Skip(SkipCount).Take(PageSize);
            if (ItemList.Count() > 0)
            {
                string Message = "";
                if (ItemList.Count() >= 500)
                    Message = " بیشتر از 500 " + " نتیجه پیدا شد";
                else
                    Message = Tools.ChangeEnc(ResultCount.ToString()) + "  نتیجه پیدا شد";

                msgBox.Text = Message;
                Page.Title = "نتایج جستجو  " + " صفحه " + PageNo;
                lblPageTitle.Text = " نتایج جستجو  ";

                rptItems.DataSource = ItemList;
                rptItems.DataBind();

                int PageCount = ResultCount / PageSize;
                if (ResultCount % PageSize > 0)
                    PageCount++;
                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();
            }
            else
            {
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                msgBox.Text = " هیچ نتیجه ای پیدا نشد. ";
            }
        }
        return ResultCount;
    }
    protected void HandleRepeaterCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "AddFriend")
        {
            LinkButton btnAddFriend = (LinkButton)e.Item.FindControl("btnAddFriend");
            HyperLink hplUserImage = (HyperLink)e.Item.FindControl("hplUserImage");
            string UserImage = hplUserImage.ImageUrl;
            int FriendCode = Convert.ToInt32(btnAddFriend.Attributes["FriendCode"]);

            int LoggedUserCode = Convert.ToInt32(Session["UserCode"]);
            UsersDataContext dc = new UsersDataContext();
            if ( LoggedUserCode != FriendCode && dc.UserFriends.Where(p => p.UserCode.Equals(LoggedUserCode) && p.FriendCode.Equals(FriendCode)).Count() == 0)// User is not in user friends
            {
                AddFriend.Visible = true;
                AddFriend.UpPanel = UpdatePanel1;

                string FriendFirstName = Convert.ToString(btnAddFriend.Attributes["FirstName"]);
                string FriendLastName = Convert.ToString(btnAddFriend.Attributes["LastName"]);
                AddFriend.Caption = "اضافه کردن  " + FriendFirstName + " بعنوان دوست؟";
                AddFriend.PhotoUrl = UserImage;
                //AddFriend.WinTitle = FriendFirstName + " " + FriendLastName;
                AddFriend.ToUserCode = FriendCode;
                string jsShowAddFriendPanel = @"$(""#divSendMessage"").modal('hide');$(""#divAddFriendReq"").modal('show');";
                ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType()
                                                      , "ShowAddFriendPanel", jsShowAddFriendPanel, true);
            }
            else
            {
                btnAddFriend.Text = "همین الان هم دوست شماست !";
                btnAddFriend.CommandName = "";
            }
        }
        if (e.CommandName == "SendMessage")
        {
            SendMessage.Visible = true;
            LinkButton btnAddFriend = (LinkButton)e.Item.FindControl("btnAddFriend");
            HyperLink hplUserImage = (HyperLink)e.Item.FindControl("hplUserImage");
            string UserImage = hplUserImage.ImageUrl;
            int FriendCode = Convert.ToInt32(btnAddFriend.Attributes["FriendCode"]);
            string FriendFirstName = Convert.ToString(btnAddFriend.Attributes["FirstName"]);
            string FriendLastName = Convert.ToString(btnAddFriend.Attributes["LastName"]);
            //SendMessage.PhotoUrl = UserImage;
            SendMessage.Caption = FriendFirstName + " " + FriendLastName;
            SendMessage.ToUserCode = FriendCode;
//            string JSCommand = "AdjustBox('" + SendMessage.ClientID+ "')";
//            ScriptManager.RegisterStartupScript(UpdatePanel1, typeof(string), "alertScript", JSCommand, true);

            string jsShowAddFriendPanel = @"$(""#divAddFriendReq"").modal('hide');$(""#divSendMessage"").modal('show');";
            ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType()
                                                  , "SendMessage", jsShowAddFriendPanel, true);

        }
        if (e.CommandName == "ViewFriends")
        {
            LinkButton btnAddFriend = (LinkButton)e.Item.FindControl("btnAddFriend");
            int FriendCode = Convert.ToInt32(btnAddFriend.Attributes["FriendCode"]);
            UsersDataContext dc = new UsersDataContext();
            vUsers CurUser = dc.vUsers.SingleOrDefault(p => p.Code.Equals(FriendCode));
            if (CurUser != null)
            {
                Response.Redirect("~/Users/Friends.aspx?ID=" + CurUser.ID);
            }

        }
        if (e.CommandName == "DeleteFriend")
        {
            BOLUsers UsersBOL = new BOLUsers();
            int LoggedUserCode = Convert.ToInt32(Session["UserCode"]);
            LinkButton btnAddFriend = (LinkButton)e.Item.FindControl("btnAddFriend");
            int FriendCode = Convert.ToInt32(btnAddFriend.Attributes["FriendCode"]);
            UsersBOL.DeleteFriend(LoggedUserCode, FriendCode);
            msgBox.Text = "";
            e.Item.Visible = false;
        }
    }

    protected void rptItems_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (Session["UserCode"] == null)
            return;
        if (PassedUserCode.ToString() == Session["UserCode"].ToString())
        {
            LinkButton btnAddFriend = (LinkButton)((RepeaterItem)e.Item).FindControl("btnAddFriend");
            btnAddFriend.Visible = false;

        }

    }
}
