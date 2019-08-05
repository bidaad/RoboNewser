using RoboNewser.Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.Postback
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Url = Request.Url.Host.Trim().ToLower();
                string HTTP_REFERER = Request.ServerVariables["HTTP_REFERER"];
                if (HTTP_REFERER != null && HTTP_REFERER.IndexOf(Url) != -1)
                {
                    string input = Request.Form["i"];
                    switch (input)
                    {
                        case "1":
                            GetRelatedPics();
                            break;

                    }
                }
            }
            catch
            {

            }
        }

        public void GetRelatedPics()
        {
            string newsCode = Request["Code"];
            int NewsCode;
            Int32.TryParse(newsCode, out NewsCode);
            if (NewsCode != 0)
            {
                op_result _op_result = new op_result();

                NewsDataContext dataContext = new NewsDataContext();
                var Result = (from p in dataContext.vRelatedNews
                              where p.EntityCode.Equals(NewsCode) && p.PicName != null && p.PicName != ""
                              select new { p.Code, p.Title, p.ImgUrl }).Take(16);

                string strResult = "";
                foreach (var item in Result)
                {
                    strResult += "<li><a href='https://www.robonewser.com/News/" + item.Code  + ".html' ><img class='img-fluid' title='" + item.Title + "' alt='" + item.Title + "' src='" + item.ImgUrl + "'/></a></li>";
                }

                _op_result.result = strResult;
                _op_result.success = "1";

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = serializer.Serialize((object)_op_result);
                Response.Write(json);
                Response.End();
            }
        }

    }
}