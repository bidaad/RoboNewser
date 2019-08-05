using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.Admin.NewsFolder
{
    public partial class EditNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCode = Request["Code"];
            int Code = 0;
            Int32.TryParse(strCode, out Code);
            if (Code != 0)
            {
                NewsDataContext dc = new NewsDataContext();
                RoboNewser.Code.DAL.News CurNews = dc.News.Single(p => p.Code.Equals(Code));
                if (CurNews != null)
                {
                    ViewState["Code"] = Code;
                    txtTitle.Text = CurNews.Title;
                }

            }

        }

        protected void DoSave(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {
            }
        }

        protected void GoToList(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Admin/Main/?BaseID=News");
            }
            catch
            {
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (ViewState["Code"] != null)
            {
                int Code = Convert.ToInt32(ViewState["Code"]);
                NewsDataContext dc = new NewsDataContext();
                dc.spDeleteNews(Code);
                msgBox.Text = "خبر مورد نظر حذف شد";

            }
        }

    }
}