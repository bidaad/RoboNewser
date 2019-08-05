using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UCTextADS : System.Web.UI.UserControl
{
    public int RepeatColumns
    {
        set
        {
            rptTextAds.RepeatColumns = value;
        }
    }
    protected int _repeatColumns;

    string[] ColorArray = { "FF00FF", "800000", "EF5311", "008000", "6600FF", "FF0000", "000000" };
    int Counter = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        try{
        BOLUserADSs UserADSsBOL = new BOLUserADSs();
        rptTextAds.DataSource = UserADSsBOL.GetRandAds(12);
        rptTextAds.DataBind();
        }
        catch (Exception err)
        {
            BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
            ErrorLogsBOL.Insert(err.Message, DateTime.Now, Request.Url.AbsolutePath, "UCTextAds::Load");
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