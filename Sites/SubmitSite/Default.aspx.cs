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

public partial class Sites_SubmitSite_Default : System.Web.UI.Page
{
    public string strPageNo;
    public string FirstChar;
    public string Keyword;
    public int Counter = 0;

    protected void Page_Load(object sender, EventArgs e)
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
            if (CatID == null || CatID == "" || CatID == "0")
            {
                ItemList = dc.SiteCatNames.Where(p => p.Parent.Equals(0));
                btnTopCat.Visible = false;
            }
            else
            {
                ItemList = dc.SiteCatNames.Where(p => p.Parent.Equals(CatID));
                btnTopCat.Visible = true;
            }

            dlSiteCats.DataSource = ItemList;
            dlSiteCats.DataBind();


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

    protected void HandleDataList(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ShowSubCats")
        {
            LinkButton btnCat = (LinkButton)e.Item.FindControl("btnCat");
            string CatID = Convert.ToString(btnCat.Attributes["CatID"]);
            SitesDataContext dc = new SitesDataContext();
            dlSiteCats.DataSource = dc.SiteCatNames.Where(p => p.Parent.Equals(CatID));
            dlSiteCats.DataBind();
            hfCatID.Value = CatID;
            btnTopCat.Visible = true;
            lblSelGroupLabel.Visible = true;
            lblSelectedGroup.Text = dc.SiteCatNames.SingleOrDefault(p => p.ID.Equals(CatID)).Name;

        }

    }

    private int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    private string GenNewID()
    {
        return RandomNumber(111111, 999999) + "" + RandomNumber(111111, 999999) ;
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        pnlMessage.Visible = true;

        try
        {
            if (!RadCaptcha1.IsValid)
            {
                msgBox.Text = "کد امنیتی اشتباه است";
                msgBox.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                return;
            }

            SitesDataContext dc = new SitesDataContext();

            string Title = txtTitle.Text;
            string Description = txtDescription.Text;
            string SenderEmail = txtEmail.Text;
            string SenderName = txtSenderName.Text;
            string CatID = hfCatID.Value;
            string Url = txtUrl.Text.Replace("http://", "");

            if (CatID == "")
            {
                lblMessage.Text = "لطفا گروه سایت را انتخاب کنید";
                return;
            }

            AllSites PreSite = dc.AllSites.SingleOrDefault(p => p.Url.Equals(Url));
            if (PreSite != null)
            {
                lblMessage.Text = "این سایت قبلا وارد شده است";
                return;
            }
            AllSites NewSite = new AllSites();
            NewSite.SiteName = Title;
            NewSite.Description = Description;
            NewSite.Cat =  Convert.ToInt32( CatID);
            NewSite.ID = GenNewID();
            NewSite.Active = 0;
            NewSite.VisitCount = 0;
            NewSite.Rating = 0;
            NewSite.ViewerCount = 0;
            NewSite.SumAll = 0;
            NewSite.SenderName = SenderName;
            NewSite.SenderEmail = SenderEmail;
            NewSite.Url = Url;
            dc.AllSites.InsertOnSubmit(NewSite);
            dc.SubmitChanges();

            lblMessage.Text = "درخواست شما برای افزودن سایت جدید ثبت شد. پس از تایید مدیر سایت ، لینک درخواستی شما ظاهر میشود.";
            btnSend.Visible = false;

        }
        catch
        {
            lblMessage.Text = "خطا در ثبت سایت";
        }

    }
    protected void btnTopCat_Click(object sender, EventArgs e)
    {
        string CatID = hfCatID.Value;
        SitesDataContext dc = new SitesDataContext();
        SiteCatNames CurParentCat = dc.SiteCatNames.SingleOrDefault(p => p.ID.Equals(CatID));
        if (CurParentCat != null)
        {
            dlSiteCats.DataSource = dc.SiteCatNames.Where(p => p.Parent.Equals(CurParentCat.Parent));
            dlSiteCats.DataBind();
            hfCatID.Value = CurParentCat.Parent.ToString();
            if (CurParentCat.Parent.ToString() == "0")
            {
                btnTopCat.Visible = false;
                lblSelGroupLabel.Visible = false;

            }
            else
            {
                btnTopCat.Visible = true;
                lblSelGroupLabel.Visible = true;

            }



        }
    }
}
