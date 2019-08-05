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
using Parsetv91._1.Code.DAL;


public partial class EntityKeywords_EditEntityKeywords : EditForm<EntityKeywords>
{
    public string SavedBaseID
    {
        get
        {
            if (ViewState["_SavedBaseID"] == null)
            {
                try
                {
                    return ViewState["_SavedBaseID"].ToString();
                }
                catch
                {
                    return null;
                }
            }
            else
                return ViewState["_SavedBaseID"].ToString();
        }
        set
        {
            ViewState["_SavedBaseID"] = value;
        }
    }
    protected bool ValidateInputs()
    {
        return true;
    }
    protected override object LoadData(int DetailCode)
    {
        EntityKeywords ObjBaseID = BOLClass.GetDetails(DetailCode);
        Tools tools = new Tools();
        tools.AccessList = tools.GetAccessList("EntityKeywords");
        if (ObjBaseID != null)
        {
            tools.ShowControl("EntityKeywords.KeywordCode", lkpKeywordCode, ObjBaseID.KeywordCode, BOLClass);
            //tools.ShowControl("EntityKeywords.HCEntityTypeCode", cboHCEntityTypeCode, ObjBaseID.HCEntityTypeCode, BOLClass);
            //tools.ShowControl("EntityKeywords.EntityCode", lkpEntityCode, ObjBaseID.EntityCode, BOLClass);
            hflEntityCode.Value = ObjBaseID.EntityCode.ToString();
            hflHCEntityTypeCode.Value = ObjBaseID.HCEntityTypeCode.ToString();
        }
        return ObjBaseID;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string RealBaseID;
        BOLClass = new BOLEntityKeywords();

        Label MasterPageTitle = (Label)Master.FindControl("lblTitle");
        MasterPageTitle.Text = BOLClass.PageLable;

        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;

//            cboHCEntityTypeCode.DataSource = new BOLHardCode().GetHCDataTable("HCEntities");

            RealBaseID = Request["BaseID"];
            SavedBaseID = RealBaseID;
            if (!NewMode)
            {
                LoadData((int)Code);
            }
            else
            {
                int MasterCode = Convert.ToInt32( Request["MasterCode"]);
                hflEntityCode.Value = MasterCode.ToString();

                RealBaseID = RealBaseID.Replace("Keywords", "");
                if (!RealBaseID.EndsWith("s"))
                {
                    if(RealBaseID.EndsWith("y"))
                        RealBaseID = RealBaseID.Substring(0,RealBaseID.Length - 1) + "ies";
                    else if (RealBaseID.EndsWith("es"))
                        RealBaseID = RealBaseID.Substring(0, RealBaseID.Length - 2) + "es";
                    else
                        RealBaseID = RealBaseID + "s";
                }
                if (RealBaseID == "Thesis")
                    RealBaseID = "Thesises";
                BOLHardCode HardCodeBOL = new BOLHardCode();
                SearchFilterCollection sfc = new SearchFilterCollection();
                sfc.Add(new SearchFilter("Name", SqlOperators.Equal, RealBaseID));
                HardCodeBOL.TableOrViewName = "HCEntities";
                DataTable dt = HardCodeBOL.GetDataSource(sfc,"Code", 10, 1);
                if(dt.Rows.Count > 0)
                    hflHCEntityTypeCode.Value = dt.Rows[0]["Code"].ToString();

            }
        }


    }
    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        if (!ValidateInputs())
            return;

        BOLEntityKeywords CurObj = new BOLEntityKeywords();
        if (!NewMode) CurObj.Code = Convert.ToInt32(Code);

        CurObj.KeywordCode = Convert.ToInt32( lkpKeywordCode.Code);
        //CurObj.HCEntityTypeCode = (int)cboHCEntityTypeCode.Value;
        //CurObj.EntityCode = (int)lkpEntityCode.Code;
        CurObj.HCEntityTypeCode = Convert.ToInt32( hflHCEntityTypeCode.Value);
        CurObj.EntityCode = Convert.ToInt32( hflEntityCode.Value);
        CurObj.SaveChanges(NewMode);

        GoToList(null, null);
    }
    protected void GoToList(object sender, ImageClickEventArgs e)
    {
        Tools.CloseWin(Page, Master, SavedBaseID, ViewState["InstanceName"].ToString());
    }
}
