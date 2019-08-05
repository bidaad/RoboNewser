using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1.Admin.Translate
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string SourceText = txtSource.Text;
            //ReqUtils Utils = new ReqUtils();
            //string Url = "https://www.googleapis.com/language/translate/v2?key=AIzaSyADgVmgF4U_HWdHMWMQLEPIrnCk7a8SIyA&q=" + Server.UrlEncode(SourceText) + "&source=fa&target=en";
            //string Result = Utils.GetHTML(Url, System.Text.Encoding.UTF8);


            string SourceText = txtSource.Text;
            string Url = "https://www.googleapis.com/language/translate/v2";

            string postData = "key=AIzaSyADgVmgF4U_HWdHMWMQLEPIrnCk7a8SIyA&q=" + Server.UrlEncode(SourceText) + "&source=fa&target=en";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Headers["X-HTTP-Method-Override"] = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            WebResponse response = request.GetResponse();
            //Console.WriteLine("Service Status Code:"+((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            JObject obj = JObject.Parse(responseFromServer);
            JToken translated = obj.SelectToken("data.translations[0].translatedText");

            
            int gg = 1;
            ltrResult.Text = HttpUtility.UrlDecode(translated.ToString());
        }
    }
}