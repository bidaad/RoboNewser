using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboNewser.UserControls
{
    public partial class SuggestSite : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Session["FirstName"] != null)
                {
                    txtFromName.Text = Session["FirstName"].ToString() + " " + Session["LastName"].ToString();
                }
            }
        }
        protected void btnSendToFriend_Click(object sender, EventArgs e)
        {

            string Referer = Page.Request.ServerVariables["http_referer"];
            if (!Referer.StartsWith("https://www.robonewser.com/") && !Referer.StartsWith("http://RoboNewser.com/"))
                return;


            string FromName = txtFromName.Text;
            string ToEmail = txtEmail.Text;
            if (ToEmail.Trim() == "")
                return;

            string MailBody = @"<div id="":1vh"" class=""ii gt"">
	<table style=""border: 1px solid rgb(151, 184, 84); padding: 0pt; border-collapse: collapse;"" width=""500"" border=""0"" cellpadding=""0"" cellspacing=""0"">
		<tr>
			<td width=""100%"">&nbsp;</td>
		</tr>
		<tr>
			<td style width=""100%"">
			<p dir=""rtl"" align=""center"">&nbsp;</p>
			<p dir=""rtl"" align=""center"">
				<div style=""padding:8px;"">
					<p dir=""rtl"" align=""right"">
					<font size=""2"" color=""#627e45"" face=""Tahoma"">دوست عزیز</font></p>
					<p dir=""rtl"" align=""justify""><span lang=""fa"">
					<font size=""2"" color=""#546e98"" face=""Tahoma"">سايت پارست 
					سايتي در زمينه اطلاع رسان&#1740; مي باشد. كه داراي قسمتها&#1740; زير 
					است:</font></span></p>
					<p dir=""rtl"" align=""justify""><span lang=""fa"">
					<font size=""2"" color=""#546e98"" face=""Tahoma"">340000 بيت شعر 
					فارس&#1740;<br>
					فرهنگ لغات 6 زبانه<br>
					آدرس و تلفن 26000 واحد تجار&#1740;<br>
					سايت ايران&#1740; طبقه بند&#1740; شده<br>
					متن کامل قرآن و نهج البلاغه<br>
					طالع بين&#1740;<br>
					تقويم تاريخ و ...<br>
					&nbsp;</span></font></p>
					<p dir=""rtl"" align=""justify""><span lang=""fa"">
					<font size=""2"" color=""#546e98"" face=""Tahoma"">از شما دعوت 
					ميكنيم از سايت ما ديدن نماييد&nbsp; تا هم از امكانات سايت 
					بتوانيد استفاده نماييد و هم هميشه جديدترين اخبار&nbsp; و ... 
					را براي شما ارسال كنيم.</font></span></p>
					<p dir=""rtl"" align=""justify""><span lang=""fa"">
					<font size=""2"" color=""#546e98"" face=""Tahoma"">ما منتظر شما در 
					&quot;پارست&quot; هستيم.</font></span></p>
					<p dir=""rtl"" align=""center""><span lang=""fa"">
					<font size=""2"" color=""#546e98"" face=""Tahoma"">
					<a style=""text-decoration: none;"" target=""_blank"" href=""http://www.RoboNewser.com"">
					<font color=""#ff9900"">براي بازديد از سايت اينجا را كليك 
					نماييد</font></a></font></span></p>
					&nbsp;</div>
			
			</p>
			<p dir=""rtl"" align=""center"">&nbsp;</td>
		</tr>
		<tr>
			<td width=""100%"" bgcolor=""#ccff66"">
			<p align=""center"">
			<a href=""http://www.RoboNewser.com"" style=""text-decoration: none""><b>
			<font face=""Verdana"" size=""1"" color=""#546E98"">P</font></b></a><b><font size=""1"" color=""#546e98"" face=""Verdana""><a style=""text-decoration: none;"" target=""_blank"" href=""http://www.RoboNewser.com""><font color=""#546e98"">arset 
			WebSite</font></a>&nbsp; - Copyright 2012</font></b></td>
		</tr>
	</table>
</div>";
            BOLEmails EmailsBOL = new BOLEmails();
            string SenderIP = Request.UserHostAddress;
            EmailsBOL.Insert(ToEmail, 3, "", SenderIP);

            Tools tools = new Tools();
            bool SendResult = tools.SendEmail(MailBody, "دعوتنامه از طرف " + FromName, "invite@RoboNewser.com", ToEmail, "", "");
            if (SendResult)
            {
                pnlSedInvitation.Visible = false;
                lblInvSent.Visible = true;
            }
        }

    }
}