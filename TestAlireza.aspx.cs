using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parsetv91._1
{
    public partial class TestAlireza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            string WhoisServer = "whois.geektools.com";
            TcpClient objTCPC = new TcpClient(WhoisServer, 43);
            string strDomain = Request["DomainName"] + "\r\n";
            byte[] arrDomain = Encoding.ASCII.GetBytes(strDomain);

            Stream objStream = objTCPC.GetStream();
            objStream.Write(arrDomain, 0, strDomain.Length);
            StreamReader objSR = new StreamReader(objTCPC.GetStream(),
            Encoding.ASCII);
            lblResponse.Text = "<b>" + Request.Form["DomainName"] +
            "</b><br><br>" + Regex.Replace(objSR.ReadToEnd(),"\n","<br>");

            objTCPC.Close();
            }
            catch(Exception ex)
            {
            lblResponse.Text = ex.ToString();
            }

        }

        protected void btnPayCost_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}