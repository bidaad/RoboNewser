using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace GBN.Web.UI.Admin.DataResources
{
    public partial class KeywordTester : System.Web.UI.Page
    {
        private void ExtractKeywords(string NewsContent)
        {
            Tools tools = new Tools();
            ArrayList OneLenList = tools.GenLenKeywords(1, 2, @"(\w+)(\w+)", NewsContent);
            ArrayList TwoLenList = tools.GenLenKeywords(2, 2, @"(\w+)(\w+)", NewsContent);
            ArrayList TreeLenList = tools.GenLenKeywords(3, 1, @"(\w+)(\w+)", NewsContent);
            ArrayList FourLenList = tools.GenLenKeywords(4, 1, @"(\w+)(\w+)", NewsContent);

            string[] OneLenListArray = (String[])OneLenList.ToArray(typeof(string));
            string[] TwoLenListArray = (String[])TwoLenList.ToArray(typeof(string));
            string[] TreeLenListArray = (String[])TreeLenList.ToArray(typeof(string));
            string[] FourLenListArray = (String[])FourLenList.ToArray(typeof(string));

            IEnumerable<String> FullKeyList;
            FullKeyList = OneLenListArray.Union(TwoLenListArray).Union(TreeLenListArray).Union(FourLenListArray);
            rptKeywords.DataSource = FullKeyList;
            rptKeywords.DataBind();
            //return Tools.GetkeywordCodes(FullKeyList);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGen_Click(object sender, EventArgs e)
        {
            ExtractKeywords(txtText.Text);

        }
    }
}
