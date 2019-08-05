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

public partial class Sites_SearchSites_Default : System.Web.UI.Page
{
    public string strPageNo;
    public string FirstChar;
    public string Keyword;
    public int Counter = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        return;

        if (!Page.IsPostBack)
        {
            SitesDataContext dc = new SitesDataContext();
            int SkipCount = 0;
            int PageNo = 1;
            int PageCount;

            strPageNo = Request["PageNo"];
            Keyword = Request["Keyword"];
            string ConcatUrl = "&Keyword=" + Keyword;
            PageNo = Convert.ToInt32(strPageNo);
            if (PageNo == 0)
                PageNo = 1;
            SkipCount = 20 * (PageNo - 1);


            txtKeyword.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + btnSearch.ClientID + "').click();return false;}} else {return true}; ");
            dlSites.DataSource = dc.SiteCatNames.Where(p => p.Parent.Equals(0));
            dlSites.DataBind();

            if (Keyword != null && Keyword != "")
            {
                IQueryable<AllSites> ItemList;
                int PageSize = 20;
                rptItems.DataSource = dc.AllSites.Where(p => p.Active.Equals(1) && (p.SiteName.Contains(Keyword) || p.Description.Contains(Keyword) || p.Url.Contains(Keyword))).OrderBy(p => p.ViewerCount).Skip(SkipCount).Take(PageSize);
                rptItems.DataBind();
                int ResultCount = dc.AllSites.Where(p => p.Active.Equals(1) && (p.SiteName.Contains(Keyword) || p.Description.Contains(Keyword) || p.Url.Contains(Keyword))).Count();
                PageCount = ResultCount / PageSize;
                if (ResultCount % PageSize > 0)
                    PageCount++;

                pgrToolbar.PageNo = PageNo;
                pgrToolbar.PageCount = PageCount;
                pgrToolbar.ConcatUrl = ConcatUrl;
                pgrToolbar.PageBind();

                if (ResultCount > 0)
                {
                    lblHeader.Text = " جستجو در سایتهای ایرانی ";
                    Page.Title = " سایتهای ایرانی::نتایج جستجو برای " + Keyword + " صفحه " + Tools.ConvertToUnicode(PageNo);

                    string Message = "";
                    if (ResultCount >= 500)
                        Message = " بیش از " + Tools.ConvertToUnicode(ResultCount) + " نتیجه برای <b>" + Keyword + "</b> پیدا شد";
                    else
                        Message = Tools.ConvertToUnicode(ResultCount) + " نتیجه برای <b>" + Keyword + "</b> پیدا شد";
                    msgText.Text = Message;
                    msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.OK;
                }
            }
            else
            {
                msgText.Text =  "کلمه جستجو خالی است";
                msgText.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;

            }
        }


    }
    public string GetClass()
    {
        Counter++;
        if (Counter % 2 == 0)
            return "NRow3";
        else
            return "AltRow3";
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Keyword = txtKeyword.Text.Trim();
        SearchByKeyword(Keyword);
    }
    private void SearchByKeyword(string Keyword)
    {
        Response.Redirect("~/Sites/SearchSites/?Keyword=" + Keyword);
    }
    protected void HandleRepeater(object source, RepeaterCommandEventArgs e)
    {
        LinkButton btnEditLink = (LinkButton)e.Item.FindControl("btnEditLink");
        string SiteID = Convert.ToString(btnEditLink.Attributes["SiteID"]);
        SitesDataContext dc = new SitesDataContext();
        AllSites CurSite = dc.AllSites.SingleOrDefault(p => p.ID.Equals(SiteID));
        if (CurSite != null)
        {
            txtTitle.Text = CurSite.SiteName;
            txtDescription.Text = CurSite.Description;
            pnlEditLink.CssClass = "EditLinkArea";
            //string JSCommand = "pageScroll();";
            //ScriptManager.RegisterStartupScript(this.UpdatePanel1, typeof(string), "AdjustScript", JSCommand, true);
            hfSiteID.Value = SiteID;
        }

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (!RadCaptcha1.IsValid)
        {
            msgBox.Text = "کد امنیتی اشتباه است";
            msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
            return;
        }
        string NewTitle = txtTitle.Text;
        string NewDescription = txtDescription.Text;
        string SenderEmail = txtEmail.Text;
        string SenderName = txtSenderName.Text;
        string ErrorDesc = "";
        for (int i = 0; i < chkListErrors.Items.Count; i++)
        {
            if (chkListErrors.Items[i].Selected)
                ErrorDesc += chkListErrors.Items[i].Value + "\n<BR>";
        }
        Tools tools = new Tools();
        string MailBody = "<b>" + NewTitle + "</b><BR>";
        MailBody += "فرستنده:" + SenderName + "<BR>";
        MailBody += SenderEmail + "<BR><BR>";
        MailBody += "ID:" + hfSiteID.Value + "<BR><BR>";

        MailBody += NewDescription + "<BR><BR>";
        MailBody += NewDescription + "<BR><BR>";
        MailBody += ErrorDesc + "<BR>";

        bool SendResult = tools.SendEmail(MailBody, "گزارش لینک خراب", "DeadLink@RoboNewser.com", "bidaad@gmail.com", "", "");
        pnlMessage.Visible = true;
        if (SendResult)
        {
            pnlEditLink.CssClass = "EditLinkAreaHidden";
            lblMessage.Text = "پیام شما به مدیر سایت ارسال شد و در اسرع وقت ترتیب اثر داده میشود.";
        }
        else
            lblMessage.Text = "خطا در ارسال پیام";

    }

}
