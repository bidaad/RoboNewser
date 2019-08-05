using Parsetv91._1.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1
{
    public partial class F2E : System.Web.UI.Page
    {
        public int CatCode = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCatCode = Request["CatCode"];
            Int32.TryParse(strCatCode, out CatCode);
            if (CatCode != 0)
                txtCatCode.Text = CatCode.ToString();

            ContentsDataContext dc = new ContentsDataContext();

            IQueryable<Parsetv91._1.Code.DAL.Contents> ResultList = dc.Contents.Where(p => p.Translated == false);
            if (CatCode != 0)
                ResultList = ResultList.Where(p => p.ContentCatCode.Equals(CatCode));
            rptContents.DataSource = ResultList.Take(10);
            rptContents.DataBind();

            ltrCount.Text = "تعداد ترجمه نشده " + dc.Contents.Where(p => p.Translated.Equals(false)).Count().ToString();
        }
    }
}