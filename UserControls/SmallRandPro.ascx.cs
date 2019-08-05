using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RoboNewser.Code.DAL;

public partial class UserControls_SmallRandPro : System.Web.UI.UserControl
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
            rptTextAds.DataSource = UserADSsBOL.GetRandAds(5);
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
