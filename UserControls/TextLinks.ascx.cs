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

public partial class UserControls_TextLinks : System.Web.UI.UserControl
{
    string[] ColorArray = { "FF00FF", "800000", "EF5311", "008000", "6600FF", "FF0000", "000000" };
    int Counter = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    BOLProducts ProductsBOL = new BOLProducts();
        //    IQueryable<vRandProducts> ProductList = ProductsBOL.GetRandProduct();
        //    if (ProductList.Count() == 0)
        //        this.Visible = false;
        //    foreach (var CurProduct in ProductList)
        //    {
        //        hplTitle.Text = CurProduct.Title;
        //        hplTitle.NavigateUrl = "~/Shop/ShowProduct.aspx?Code=" + CurProduct.Code;
        //        lblPrice.Text = Tools.ChangeEnc(Tools.FormatCurrency(CurProduct.Price.ToString()));

        //        hplPicFile.ImageUrl = "~/Files/Products/" + CurProduct.PicFile;
        //        hplPicFile.NavigateUrl = "~/Shop/ShowProduct.aspx?Code=" + CurProduct.Code;
        //    }
        //}

        try
        {
            BOLUserADSs UserADSsBOL = new BOLUserADSs();
            rptTextAds.DataSource = UserADSsBOL.GetRandAds(null);
            rptTextAds.DataBind();
        }
        catch
        {
        }


    }
    public string GetColor()
    {
        Counter++;
        if (Counter > ColorArray.Length - 1)
            Counter = 0;
        return ColorArray[Counter];
    }
}
