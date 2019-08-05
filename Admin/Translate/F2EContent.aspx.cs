using Parsetv91._1.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Admin.Translate
{
    public partial class F2EContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string CatCode = Request["CatCode"];
                ViewState["CatCode"] = CatCode;

                string strCode = Request["Code"];
                int Code;
                Int32.TryParse(strCode, out Code);
                if (Code != 0)
                {
                    ContentsDataContext dc = new ContentsDataContext();
                    Parsetv91._1.Code.DAL.Contents CurRecord = dc.Contents.SingleOrDefault(p => p.Code.Equals(Code));
                    txtTitle.Text = CurRecord.Title;
                    txtContent.Text = CurRecord.ContentText;

                    txtEngText.Text = CurRecord.EngText;
                    txtEngTitle.Text = CurRecord.EngTitle;
                    ViewState["Code"] = Code;
                }
            }
        }

        protected void btnTranslate_Click(object sender, EventArgs e)
        {
            if (ViewState["Code"] == null)
                return;
            int Code = Convert.ToInt32(ViewState["Code"]);
            ContentsDataContext dc = new ContentsDataContext();
            Parsetv91._1.Code.DAL.Contents CurRecord = dc.Contents.SingleOrDefault(p => p.Code.Equals(Code));
            CurRecord.EngTitle = txtEngTitle.Text;
            CurRecord.EngText = txtEngText.Text;
            CurRecord.Translated = true;
            dc.SubmitChanges();
            Response.Redirect("~/F2E.aspx?CatCode=" + ViewState["CatCode"]);

        }
    }
}