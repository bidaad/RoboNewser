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

namespace Khabardaan.Web.UI.UserControls
{
    public partial class RelatedNews : System.Web.UI.UserControl
    {
        protected string _newsCode;
        public string NewsCode
        {
            set
            {
                ViewState["_newsCode"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int NewsCode = Convert.ToInt32(ViewState["_newsCode"]);
                //BOLNews NewsBOL = new BOLNews();
                //rptNews.DataSource = NewsBOL.GetSmallRelatedNews(NewsCode, 3);
                //rptNews.DataBind();

                //int RelatedCount = NewsBOL.GetRelatedNewsCount(NewsCode);
                //if (RelatedCount == 0)
                //    this.Visible = false;
                //else if (RelatedCount > 3)
                //{
                //    MoreLink.Text = "All " + RelatedCount.ToString() + " related news... ";
                //    MoreLink.NavigateUrl = "~/News/RelatedNews.aspx?Code=" + NewsCode;
                //}
                //else
                //    MoreLink.Visible = false;

                MoreLink.Text = "All related news... ";
                MoreLink.NavigateUrl = "~/News/RelatedNews.aspx?Code=" + NewsCode;

            }
            catch (Exception exp)
            {
               // BOLErrorLogs ErrorLogsBOL = new BOLErrorLogs();
               // ErrorLogsBOL.Insert(exp.Message, DateTime.Now, Request.Url.AbsolutePath, "UCRelatedNews");
            }


        }
        public string ShowText(Object obj)
        {
            int SelectLen = 180;
            try
            {

                if (obj != null)
                {
                    string str = obj.ToString();
                    try
                    {
                        ReqUtils Utils = new ReqUtils();
                        str = Utils.RemoveTags(str);
                        
                    }
                    catch
                    {
                    }

                    if (str.Length > SelectLen)
                        str = str.Substring(0, SelectLen) + "...";

                    return str;
                }
                else
                    return "";
            }
            catch
            {
                return obj.ToString();
            }

        }

        protected void rptNews_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            try
            {
                BOLNews NewsBOL = new BOLNews();
                if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    HiddenField hfPic = (HiddenField)e.Item.FindControl("hfPic");
                    Image imgNews = (Image)e.Item.FindControl("imgNews");
                    string PicName = hfPic.Value;
                    if (string.IsNullOrEmpty(PicName))
                        imgNews.Visible = false;

                }
            }
            catch
            {

            }
        }
    }
}