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


public partial class Keywords_EditKeywords : EditForm<Keywords>
{
    private string BaseID = "Keywords";
    IBaseBOL<Keywords> BOLClass;

    #region Properties
    public int? Code
    {
        get
        {
            if (ViewState["_Code"] == null)
            {
                try
                {
                    int intCode = Int32.Parse(Request["Code"]);
                    ViewState["_Code"] = intCode;
                    return intCode;
                }
                catch
                {
                    return null;
                }
            }
            else
                return Int32.Parse(ViewState["_Code"].ToString());
        }
        set
        {
            ViewState["_Code"] = value;
        }
    }
    public bool NewMode
    {
        get
        {
            if (ViewState["_NewMode"] == null)
            {
                if (Code == null)
                    ViewState["_NewMode"] = true;
                else
                    ViewState["_NewMode"] = false;
            }

            return (bool)ViewState["_NewMode"];
        }

        set
        {
            ViewState["_NewMode"] = value;
        }
    }
    #endregion
    protected bool ValidateInputs()
    {
        return true;
    }
    protected void LoadData(int DetailCode)
    {
        Keywords ObjBaseID = BOLClass.GetDetails(DetailCode);
        Tools tools = new Tools();
        tools.AccessList = tools.GetAccessList(BaseID);
        if (ObjBaseID != null)
        {
            tools.ShowControl("Keywords.Name", txtName, ObjBaseID.Name, BOLClass);
            tools.ShowControl("Keywords.EngName", txtEngName, ObjBaseID.EngName, BOLClass);
            tools.ShowControl("Keywords.Description", txtDescription, ObjBaseID.Description, BOLClass);

        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        BOLClass = new BOLKeywords();

        hplSysName.Text = BOLClass.PageLable;
        hplSysName.NavigateUrl = "";//"~/" + BaseID;


        if (Code == null)
            if (!NewMode)
                return;
        if (!Page.IsPostBack)
        {
            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;


            if (!NewMode)
            {
                LoadData((int)Code);
            }
        }


    }
    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        if (!ValidateInputs())
            return;

        BOLKeywords CurObj = new BOLKeywords();
        if (!NewMode)
            CurObj.Code = Convert.ToInt32(Code);
        else
        {
            BOLKeywords KeywordsBOL = new BOLKeywords();
            Keywords Key = KeywordsBOL.GetDataByKeyword(txtName.Text);
            if (Key != null)
            {
                msgBox.Text = "این کلید واژه قبلا وارد شده است";
                return;
            }
        }
        CurObj.Name = txtName.Text;
        CurObj.EngName = txtEngName.Text;
        CurObj.Description = txtDescription.Text;

        CurObj.SaveChanges(NewMode);

        GoToList(null, null);
    }

}
