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


public partial class Sites_Default : System.Web.UI.Page
{
    public string strPageNo;
    public string FirstChar;
    public string Keyword;
    public int Counter = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            return;
            SitesDataContext dc = new SitesDataContext();
            int SkipCount = 0;
            int PageNo = 1;
            int PageCount;
            string CatID = Request["CatID"];

            strPageNo = Request["PageNo"];
            string ConcatUrl = "&CatID=" + CatID;
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
                txtKeyword.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + btnSearch.ClientID + "').click();return false;}} else {return true}; ");
                IQueryable<SiteCatNames> ItemList;
                if (CatID == null || CatID == "")
                {
                    ItemList = dc.SiteCatNames.Where(p => p.Parent.Equals(0));
                }
                else
                    ItemList = dc.SiteCatNames.Where(p => p.Parent.Equals(CatID));

                dlSites.DataSource = ItemList;
                dlSites.DataBind();

                if (dlSites.Items.Count == 0)
                    lblNoSubCat.Visible = true;

                if (CatID != null)
                {
                    int PageSize = 20;
                    rptItems.DataSource = dc.AllSites.Where(p => p.Cat.Equals(CatID) && p.Active.Equals(1)).OrderBy(p => p.ViewerCount).Skip(SkipCount).Take(PageSize);
                    rptItems.DataBind();
                    int ResultCount = dc.AllSites.Where(p => p.Cat.Equals(CatID) && p.Active.Equals(1)).Count();
                    PageCount = ResultCount / PageSize;
                    if (ResultCount % PageSize > 0)
                        PageCount++;

                    pgrToolbar.PageNo = PageNo;
                    pgrToolbar.PageCount = PageCount;
                    pgrToolbar.ConcatUrl = ConcatUrl;
                    pgrToolbar.PageBind();

                    string CatName = dc.SiteCatNames.SingleOrDefault(p => p.ID.Equals(CatID)).Name;
                    if (rptItems.Items.Count > 0)
                    {
                        lblHeader.Text = " فهرست سایتهای گروه " + CatName;
                        Page.Title = " سایتهای ایرانی :: فهرست سایتهای گروه " + CatName + " صفحه " + Tools.ConvertToUnicode(PageNo);
                    }
                }
                else
                    hplNav.Visible = false;
            }
        }
        catch (Exception err)
        {
            string MailBody = "Page: " + Request.FilePath + " Exception: " + err.Message;
            Tools tools = new Tools();
            bool SendResult = tools.SendEmail(MailBody, "پارست ::Error ", "bidaad@gmail.com", "", "", "");
        }

 

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

        bool SendResult = tools.SendEmail(MailBody, "گزارش لینک خراب", "DeadLink@RoboNewser.com", "bidaad@gmail.com","", "");
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
