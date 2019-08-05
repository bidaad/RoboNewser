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

public partial class DataResources_RegExTester : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        string str = txtString.Text;
        string pattern = txtRegEx.Text;
        Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        Match m = r.Match(str);
        if (m.Success)
        {
            lblResult.Text = "Matched. Count:" + m.Groups[1].Captures.Count;
            lblResult.ForeColor = System.Drawing.Color.Black;
            txtGroups.Text = m.Groups["URL"].Captures[0].Value;

            m = m.NextMatch();
            //txtGroups.Text = txtGroups.Text + "FFF" + m.Groups[0].Captures[0].Value;
        }
        else
        {
            lblResult.Text = "Didn't Matched !";
            lblResult.ForeColor = System.Drawing.Color.Maroon;
            txtGroups.Text = "";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ReqUtils gn = new ReqUtils();
        ArrayList NewList = gn.ExtractNewsLinks(txtString.Text, txtRegEx.Text, "");
        Response.Write(NewList.Count);

    }
}
