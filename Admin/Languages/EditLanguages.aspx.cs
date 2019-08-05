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


public partial class Languages_EditLanguages : EditForm<Languages>
{
    private string BaseID = "Languages";
    IBaseBOL<Languages> BaseBOL;

    protected void Page_Load(object sender, EventArgs e)
    {
        BOLClass = new BOLLanguages();
        hplSysName.Text = BOLClass.PageLable;
        hplSysName.NavigateUrl = "~/" + BaseID;


        if ((Code == null) && (!NewMode)) return;
        if (!Page.IsPostBack)
        {

            #region Fill Combo

            #endregion
            if (!NewMode)
            {
                LoadData((int)Code);
                //hplView.NavigateUrl = "#";
            }
        }


    }

    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (NewMode && ReturnCode != -1)
            {
                NewMode = false;
                Code = ReturnCode;
            }
        }
        catch
        {
        }
    }
}
