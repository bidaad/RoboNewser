using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

namespace WebApp.Admin.Users
{
    public partial class UserProfiles : System.Web.UI.Page
    {
        public string strPageNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserCode"] == null)
                Response.Redirect("~/Admin/UserLogin.aspx");

            int SkipCount = 0;
            int PageNo = 1;
            int PageCount;
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
            SkipCount = 20 * (PageNo - 1);


            if (!Page.IsPostBack)
            {
                int PageSize = 20;
                UsersDataContext dc = new UsersDataContext();
                rptUsers.DataSource = dc.Users.Where(p => p.PicFile != "").OrderBy(p=> p.PicFile).OrderBy(p => p.UpdateTime).Skip(SkipCount).Take(PageSize);
                rptUsers.DataBind();
                int ResultCount = dc.Users.Where(p => p.PicFile != "").Count();
                PageCount = ResultCount / PageSize;
                if (ResultCount % PageSize > 0)
                    PageCount++;

                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.PageBind();
            }
        }
        public string GetStatusName(Object obj)
        {
            if (obj == null)
                return "";
            else if (obj.ToString() == "1")
                return "منتظر تایید";
            else
                return "تایید شده";
        }
        protected void HandleRepeaterCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "ActivatePic")
            {
                Button btnPic = (Button)e.Item.FindControl("btnPic");
                Label lblStatus = (Label)e.Item.FindControl("lblStatus");
                
                int UserCode = Convert.ToInt32(btnPic.Attributes["UserCode"]);
                BOLUsers UsersBOL = new BOLUsers();
                UsersDataContext dc = new UsersDataContext();
                RoboNewser.Code.DAL.Users CurUser = dc.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
                if (CurUser != null)
                {
                    CurUser.HCPicStatusCode = 2;
                    CurUser.UpdateTime = DateTime.Now;
                    dc.SubmitChanges();
                    lblStatus.Text = "فعال";
                }
            }

            if (e.CommandName == "DeletePic")
            {
                Button btnDelPic = (Button)e.Item.FindControl("btnDelPic");
                Label lblStatus = (Label)e.Item.FindControl("lblStatus");

                int UserCode = Convert.ToInt32(btnDelPic.Attributes["UserCode"]);
                BOLUsers UsersBOL = new BOLUsers();
                UsersDataContext dc = new UsersDataContext();
                RoboNewser.Code.DAL.Users CurUser = dc.Users.SingleOrDefault(p => p.Code.Equals(UserCode));
                if (CurUser != null)
                {
                    CurUser.HCPicStatusCode = 1;
                    CurUser.UpdateTime = DateTime.Now;
                    CurUser.PicFile = null;
                    CurUser.SmallPicFile = null;
                    dc.SubmitChanges();
                    lblStatus.Text = "حذف شد";
                }
            }

        }

    }
}