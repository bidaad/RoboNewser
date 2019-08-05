using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using RoboNewser.Code.DAL;
using System.Linq;

public partial class UserControls_Banner : System.Web.UI.UserControl
{
    const int CachingTime = 120;


    protected string _positionCode;
    public string PositionCode
    {
        get
        {
            return _positionCode;
        }
        set
        {
            _positionCode = value;
        }
    }

    protected int GetRandRow(int Count)
    {
        try
        {
            Random rnd = new Random();
            double val = rnd.NextDouble();
            int RandVal = Convert.ToInt32((Count * val));
            if (RandVal > 0)
                RandVal--;
            return RandVal;
        }
        catch (Exception err)
        {
            return 0;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            //return;
            IQueryable<vRandBanners> BannerList;
            HttpContext context = HttpContext.Current;
            if (context.Cache["Banners" + _positionCode] == null)
            {
                BOLBanners bolBanners = new BOLBanners();
                BannerList = bolBanners.GetRandBannersByPositionCode(_positionCode);
                context.Cache.Insert("Banners" + _positionCode, BannerList, null, DateTime.Now.AddMinutes(CachingTime), TimeSpan.Zero);
            }
            BannerList = (IQueryable<vRandBanners>)context.Cache["Banners" + _positionCode];


            //int BannerCount = BannerList.Count();
            if (BannerList.Any())
            {
                //int RandVal = GetRandRow(BannerCount);
                string FileName;
                vRandBanners CurBanner = BannerList.First(); //(BannerList.Skip(RandVal).Take(1)).Single();
                FileName = CurBanner.BanFile;
                if (CurBanner.HCTypeCode == 1)
                {
                    if (CurBanner.TargetUrl != "")
                        hlBanner.NavigateUrl = "http://" + CurBanner.TargetUrl;
                    imgBanner.ImageUrl = "https://static.robonewser.com/Files/Banners/" + FileName;// ResolveUrl("~/") + string.Format("Imager.aspx?ImgFilePath={0}&StaticWidth={1}&StaticHeight={2}", Server.UrlEncode(Tools.Encode("Files/Banners/" + FileName)), CurBanner.Width, CurBanner.Height);
                    imgBanner.AlternateText = CurBanner.Text;
                    //hlBanner.Width = (int)CurBanner.Width;
                    //hlBanner.Height = (int)CurBanner.Height;
                }
                else if (CurBanner.HCTypeCode == 2)
                {
                    ltrFlash.Visible = true;
                    ltrFlash.Text = @"<OBJECT classid=""clsid:D27CDB6E-AE6D-11cf-96B8-444553540000""
                                     codebase=""http://active.macromedia.com/flash2/cabs/swflash.cab#version=4,0,0,0""
                                     ID=awards WIDTH=" + CurBanner.Width + " HEIGHT=" + CurBanner.Height + @">
                                     <PARAM NAME=movie VALUE=""" + ResolveClientUrl("~/Files/Banners/") + CurBanner.BanFile + @"""> 
                                     <PARAM NAME=quality VALUE=high> <PARAM NAME=bgcolor VALUE=#> 
                                     <EMBED src="""  + ResolveUrl("~/Files/Banners/") + CurBanner.BanFile + @""" quality=high bgcolor=# WIDTH=" + CurBanner.Width + " HEIGHT=" + CurBanner.Height + @" TYPE=""application/x-shockwave-flash"" PLUGINSPAGE=""http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash""></EMBED>
                                    </OBJECT>";
                    hlBanner.Visible = false;
                }
                else if (CurBanner.HCTypeCode == 3)
                {
                    ltrFlash.Visible = false;
                    hlBanner.Visible = false;
                    ltrText.Visible = true;
                    if(CurBanner.Width != null && CurBanner.Height != null)
                        ltrText.Text = "<div style=\"width:" + CurBanner.Width + "px;height:" + CurBanner.Height + ";\">" + CurBanner.Text + "</div>";
                    else
                        ltrText.Text = CurBanner.Text;
                }
            }
            else
            {
                hlBanner.Visible = false;
            }
        }
        catch (Exception rr)
        {
        }
        //Random rnd = new Random();
        //rnd.

    }
}
