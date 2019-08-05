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


public partial class ResourceSites_EditResourceSites : EditForm<ResourceSites>
{
    private string BaseID = "ResourceSites";

    protected void Page_Load(object sender, EventArgs e)
    {
        string Tab1Click = "BrowseObj1.ShowDetail('ResourseSiteCats', '" + Code + "', true,'BrowseObj1')";
        if (!NewMode)
            Tools.SetClientScript(Page, "ResourseSiteCats", Tab1Click);

        BOLClass = new BOLResourceSites();

        hplSysName.Text = BOLClass.PageLable;
        hplSysName.NavigateUrl = "";//"~/" + BaseID;


        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            cboHCEncodingTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCEncodingTypes");
            cboLanguageCode.DataSource = new BOLHardCode().GetHCDataTable("Languages");
            cboHCEntityTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCEntities");
            cboZoneCode.DataSource = new BOLHardCode().GetHCDataTable("Zones");

            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;


            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }


    }
    protected void DoSave(object sender, EventArgs e)
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
