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
using System.Text;


public partial class Users_EditUsers : EditForm<Users>
{

    private string ConvertToAscii(string Unistr)
    {
        Encoding ascii = Encoding.UTF32;
        Byte[] b = ascii.GetBytes(Unistr);
        return ascii.GetString((b));
    }

    protected bool ValidateInputs()
    {
        return true;
    }
    //protected void LoadData(int DetailCode)
    //{
    //    Users ObjBaseID = BOLClass.GetDetails(DetailCode);
    //    Tools tools = new Tools();
    //    if (ObjBaseID != null)
    //    {
    //        tools.ShowControl("Users.FirstName", txtFirstName, ObjBaseID.FirstName, BOLClass);
    //        tools.ShowControl("Users.LastName", txtLastName, ObjBaseID.LastName, BOLClass);
    //        tools.ShowControl("Users.Username", txtUsername, ObjBaseID.Username, BOLClass);
    //        tools.ShowControl("Users.Password", txtPassword, ObjBaseID.Password, BOLClass);
    //        tools.ShowControl("Users.Active", chkActive, ObjBaseID.Active, BOLClass);
    //        hfPassword.Value = ObjBaseID.Password;
    //        txtPassword.Attributes.Add("value", ObjBaseID.Password);

    //    }
    //}

    protected void Page_Load(object sender, EventArgs e)
    {

        BOLClass = new BOLUsers();

        hplSysName.Text = BOLClass.PageLable;
        hplSysName.NavigateUrl = "~/" + BaseID;

        string Tab2Click = "BrowseObj1.ShowDetail('UserLogs', '" + Code + "', true,'BrowseObj1')";
        Tab2.Attributes.Add("onclick", Tab2Click);

        if (Code == null)
            if (!NewMode)
                return;
        if (!NewMode)
            Tools.SetClientScript(this, "ActiveTab1", "BrowseObj1.ShowDetail('UserGroups', '" + Code + "',true,'BrowseObj1')");
        if (!Page.IsPostBack)
        {
            RadMultiPage1.SelectedIndex = 0;

            string InstanceName = Request["InstanceName"];
            ViewState["InstanceName"] = InstanceName;


            if (!NewMode)
            {
                Users CurUser = (Users)LoadData((int)Code);
                if (CurUser != null)
                    hfPassword.Value = CurUser.Password;
                txtPassword.Attributes.Add("value", txtPassword.Text);
            }
        }


    }

    protected void DoSave(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (NewMode || hfPassword.Value != txtPassword.Text)
            {
                txtPassword.Text = Tools.GetHashString(txtPassword.Text);
            }
            int ReturnCode = SaveControls("~/Main/Default.aspx?BaseID=" + BaseID);
            if (NewMode && ReturnCode != -1)
            {
                NewMode = false;
                Code = ReturnCode;
                //ShowDetails();
            }
        }
        catch
        {
        }
    }

    //protected void DoSave(object sender, ImageClickEventArgs e)
    //{
    //    if (!ValidateInputs())
    //        return;

    //    BOLUsers CurObj = new BOLUsers();
    //    if (!NewMode) CurObj.Code = Convert.ToInt32(Code);
    //    CurObj.FirstName = txtFirstName.Text;
    //    CurObj.LastName = txtLastName.Text;
    //    CurObj.Username = txtUsername.Text;
    //    if (NewMode || hfPassword.Value != txtPassword.Text)
    //    {
    //        CurObj.Password = Tools.GetHashString(txtPassword.Text);
    //    }
    //    else
    //        CurObj.Password = hfPassword.Value;
    //    CurObj.Active = chkActive.Checked;

    //    CurObj.SaveChanges(NewMode);

    //    GoToList(null, null);
    //}

}
