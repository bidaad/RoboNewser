using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class EngPopup : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {


        try
        {
            BOLLogs LogsBOL = new BOLLogs();
            int? Result = 1;
            string UserCode = "";
            if (Session["UserCode"] != null)
                UserCode = Session["UserCode"].ToString();

            bool HCReqTypeCode = false;
            if (Request.UserAgent == "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)")
                HCReqTypeCode = true;

            Result = LogsBOL.InsertLog(Request.UserAgent, Request.QueryString.ToString(), UserCode, Request.UserHostAddress, Request.Url.AbsolutePath, Tools.GetIranDate(), Page.Request.ServerVariables["http_referer"], HCReqTypeCode, ref Result);
            if (Result == 0)
                Response.End();
        }
        catch (Exception err)
        {
        }


        #region Load Scripts
        HtmlGenericControl script0 = new HtmlGenericControl("script");
        script0.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.min.js"));
        script0.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script0);

        HtmlGenericControl script1 = new HtmlGenericControl("script");
        script1.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery-ui.js"));
        script1.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script1);

        HtmlGenericControl script10 = new HtmlGenericControl("script");
        script10.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.easing.min.1.3.js"));
        script10.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script10);

        HtmlGenericControl script11 = new HtmlGenericControl("script");
        script11.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/jquery.jcontent.0.8.min.js"));
        script11.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script11);

        HtmlGenericControl script12 = new HtmlGenericControl("script");
        script12.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/hoverIntent.js"));
        script12.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script12);

        HtmlGenericControl script13 = new HtmlGenericControl("script");
        script13.Attributes.Add("src", this.ResolveClientUrl("~/Scripts/superfish.js"));
        script13.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script13);

        HtmlGenericControl script = new HtmlGenericControl("script");
        script.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/mainv1.2.js"));
        script.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script);

        HtmlGenericControl script2 = new HtmlGenericControl("script");
        script2.Attributes.Add("src", this.ResolveClientUrl("https://static.robonewser.com/Scripts/farsi.js"));
        script2.Attributes.Add("type", "text/javascript");
        Page.Header.Controls.Add(script2);
        #endregion
    }
}
