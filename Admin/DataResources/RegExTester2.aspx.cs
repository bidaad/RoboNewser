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
using System.Text.RegularExpressions;

public partial class DataResources_RegExTester2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ViewState["Counter"] == null)
            ViewState["Counter"] = 1;
    }
    void GenExp()
    {
        int Counter = 0;
        if (ViewState["Counter"] != null)
            Counter = Convert.ToInt32(ViewState["Counter"]);
        string _pattern = txtRegEx.Text;
        string Result = txtstr.Text;

        Regex r = new Regex(_pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline );
        Match m = r.Match(Result);
        int GroupCount;

        int Index1 = Convert.ToInt32(txtIndex1.Text);

        int c = 0;
        txtExp1.Text = "";

        while (m.Success)
        {
            c++;
            if (c > Counter)
                break;
            txtExp1.Text = m.Groups[Index1].Captures[0].ToString();
            m = m.NextMatch();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ViewState["Counter"] = 1;
        GenExp();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ViewState["Counter"] = Convert.ToInt32(ViewState["Counter"]) + 1;
        GenExp();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ViewState["Counter"] = Convert.ToInt32(ViewState["Counter"]) - 1;
        GenExp();
    }

}
