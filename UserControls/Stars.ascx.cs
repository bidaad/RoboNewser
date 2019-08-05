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

public partial class UserControls_Stars : System.Web.UI.UserControl
{
    protected int _starCount;
    public int StarCount
    {
        get
        {
            return _starCount;
        }
        set
        {
            _starCount = value;
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
    protected int _hCEntityCode;
    public int HCEntityCode
    {
        get
        {
            return _hCEntityCode;
        }
        set
        {
            _hCEntityCode = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BOLItemRates ItemRatesBOL = new BOLItemRates();
            ItemRates CurRate = ItemRatesBOL.GetDetail(_itemCode, _hCEntityCode);
            if (CurRate != null)
            {
                _starCount = Convert.ToInt32(CurRate.RateVal);
            }
            BindStars();
        }
    }

    private void BindStars()
    {
        DataTable dt = new DataTable();
        DataColumn dc = new DataColumn("Num");
        dt.Columns.Add(dc);
        DataRow dr;

        DataTable dt2 = new DataTable();
        DataColumn dc2 = new DataColumn("Num");
        dt2.Columns.Add(dc2);
        DataRow dr2;
        int SCount = Convert.ToInt32(_starCount);

        for (int j = 1; j <= SCount; j++)
        {
            dr = dt.NewRow();
            dr["Num"] = j;
            dt.Rows.Add(dr);
        }
        rptStars.DataSource = dt;
        rptStars.DataBind();

        for (int j = SCount + 1; j <= 5; j++)
        {
            dr2 = dt2.NewRow();
            dr2["Num"] = j;
            dt2.Rows.Add(dr2);
        }
        rptOffstars.DataSource = dt2;
        rptOffstars.DataBind();
    }

    protected void HandleRepeaterCommand(object source, RepeaterCommandEventArgs e)
    {
        string NewSavedRates = "";

        if (Request.Cookies["RoboNewser"] != null)
        {
            string SavedRates = Request.Cookies["RoboNewser"]["Rate"];
            if (SavedRates != "" && SavedRates != null)
            {
                string[] SavedRatesArray = SavedRates.Split(',');
                if (((IList)SavedRatesArray).Contains(_itemCode + "|" + _hCEntityCode))
                {
                    msgMessage.MessageTextMode = AKP.Web.Controls.Common.MessageMode.Error;
                    msgMessage.Text = "شما قبلا به این مطلب رای داده اید.";
                    return;
                }
                else
                {
                    if (SavedRates == "")
                        NewSavedRates = _itemCode + "|" + _hCEntityCode;
                    else
                        NewSavedRates = SavedRates + "," + _itemCode + "|" + _hCEntityCode;
                }
            }
            else
            {
                if (SavedRates == "")
                    NewSavedRates = _itemCode + "|" + _hCEntityCode;
                else
                    NewSavedRates = SavedRates + "," + _itemCode + "|" + _hCEntityCode;
            }

        }
        Response.Cookies["RoboNewser"].Expires = DateTime.Now.AddDays(365);
        Response.Cookies["RoboNewser"]["Rate"] = NewSavedRates;

        decimal NewRateVal = 0;
        ImageButton btnStar = (ImageButton)e.Item.FindControl("btnStar");
        decimal RateVal = Convert.ToDecimal(btnStar.Attributes["Val"]);

        BOLItemRates ItemRatesBOL = new BOLItemRates();
        ItemRates CurRate = ItemRatesBOL.GetDetail(_itemCode, _hCEntityCode);
        decimal CurrentAvg = 0;
        int CurrentCount = 0;
        if (CurRate != null)
        {
            CurrentAvg = (decimal)CurRate.RateVal;
            CurrentCount = (int)CurRate.RateCount;
        }

        //if (e.CommandName == "HalfStar")
        //{
        //    RateVal = RateVal + rptStars.Items.Count;
        //}

        NewRateVal = (RateVal + (CurrentAvg * CurrentCount)) / (CurrentCount + 1);

        ItemRatesBOL.UpdateVal(_itemCode, _hCEntityCode, NewRateVal, CurrentCount + 1);

        string JSCommand = "";
        msgMessage.Text = "رای شما با موفقیت ثبت شد.";
        //JSCommand += " $(\"#" + msgMessage.ClientID + "\").fadeTo(\"slow\",0.9);";
        //ScriptManager.RegisterStartupScript(this.UpdatePanel1, typeof(string), "SelectMediaRow", JSCommand, true);
        _starCount = Convert.ToInt32(NewRateVal);
        BindStars();
    }
}
