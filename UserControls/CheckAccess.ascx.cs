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

public partial class UserControls_CheckAccess : System.Web.UI.UserControl
{
    protected string _fieldName;
    public string FieldName
    {
        get
        {
            return _fieldName;
        }
        set
        {
            _fieldName = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        bool HasAccess = false;

        if (Session["ReadAccess"] != null && Session["RWAccess"] != null)
        {
            string[] ReadArray = Session["ReadAccess"].ToString().Split(';');
            for (int i = 0; i < ReadArray.Length; i++)
            {
                if (ReadArray[i].ToLower() == _fieldName.ToLower())
                {
                    HasAccess = true;
                    break;
                }
            }

            string[] ReadWriteArray = Session["RWAccess"].ToString().Split(';');
            for (int i = 0; i < ReadWriteArray.Length; i++)
            {
                if (ReadWriteArray[i].ToLower() == _fieldName.ToLower())
                {
                    HasAccess = true;
                    break;
                }
            }
        }

        //if (!HasAccess)
        //    Response.Redirect("~/GeneralView.aspx");


    }
}
