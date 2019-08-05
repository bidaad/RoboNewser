<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Root1.master" Title="کدهای تعبیر خواب" CodeBehind="TabirKhaab.aspx.cs" Inherits="Parsetv91._1.Codes.TabirKhaab" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/RandIKid.ascx" TagName="RandIKid" TagPrefix="UCRandIKid" %>
<%@ Register Src="~/UserControls/UCRelatedContents.ascx" TagName="UCRelatedContents"
    TagPrefix="UCRelCon" %>
<%@ Register Src="~/UserControls/ShareTools.ascx" TagName="ShareTools" TagPrefix="UCST" %>
<%@ Register Src="~/UserControls/UCRandWallpaper.ascx" TagName="UCRandWallpaper" TagPrefix="UCRW" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="WinRadiusGray">
        <UCBanner:Banner ID="Banner1" runat="server" PositionCode="11" />
    </div>
    <div class="WinRadiusGray">
        <div class="CatHeaderCont">
            <h3 class="CatHeader">
                <asp:Label ID="lblCatTitle" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;کدهای تعبیر خواب"
                    runat="server"></asp:Label>
            </h3>
        </div>
        <div class="clear">
        </div>
        <div class="InnerBarWrap">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnSearch" Text="جستجو" CssClass="btnSearch" runat="server" OnClick="btnSearch_Click" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtKeyword" CssClass="txtKeyword" runat="server"></asp:TextBox>
                    </td>
                    <td class="lbl">
                        <asp:Label ID="Label1" runat="server" Text="جستجو در تعابیر: "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <AKP:MsgBox ID="msgText" runat="server" />
            <div class="ParsetList">
                <div class="TabirCodes">
                <table width="100%" height="1740" bordercolor="#CCCCCC" border="1" bgcolor="#FFFFFF" bordercolorlight="#6C948F" bordercolordark="#35586B" id="table1">
	<tbody><tr>
		<td height="316" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="142" height="200" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/05.jpg"></a><br>
		<br>
		<font style="font-size: 9pt"><br>
		</font>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs141" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/05.jpg" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt; </textarea></span></td>
		<td height="316" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="153" height="203" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/02.jpg"></a><br>
		<br>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs142" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/02.jpg" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt; </textarea></span></td>
	</tr>
	<tr>
		<td height="207" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="150" height="90" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/06.png"></a><br>
		<br>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs140" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/06.png" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt;
 </textarea></span></td>
		<td height="207" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="150" height="90" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/01.jpg"></a><br>
		<br>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs139" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/01.jpg" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt; </textarea></span></td>
	</tr>
	<tr>
		<td height="269" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="180" height="125" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/03.jpg"></a><br>
		<br>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs144" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/03.jpg" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt; </textarea></span></td>
		<td height="269" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="186" height="72" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/07.png"></a><br>
		<span style="FONT-SIZE: 7pt">
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<textarea name="LinkUs145" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a title="تعبیر خواب" href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/07.png" width="186" height="72" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt;
 </textarea></span></td>
	</tr>
	<tr>
		<td height="594" align="center">
		
		<font face="Tahoma" color="#164e8d" style="font-size: 8pt">
		<p style="MARGIN: 0px; COLOR: #ffffff">
		<img width="160" height="120" border="0" src="http://static.parset.com/images/Tabir/3.gif"></p>
		<div style="width: 160px; font-style: normal; font-variant: normal; font-weight: normal; font-size: 11px; font-family: tahoma; border-bottom: 1px solid #20c0c8; padding-bottom: 3px; background: url('http://nightmelody.com/blogcode/sms/bg.gif') repeat-y">
			<table width="160" border="0">
				<tbody><tr>
					<td width="80"><font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a7" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">الف</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a8" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ب</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%be" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">پ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%aa" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ت</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ac" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ث</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ج</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">چ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ad" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ح</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ae" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">خ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%af" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">د</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b0" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ذ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b1" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ر</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b2" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ز</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%98" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ژ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b3" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">س</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b4" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ش</font></a></td>
					<td width="80"><font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b5" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ص</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b6" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ض</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b7" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ط</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b8" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ظ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b9" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ع</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ba" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">غ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%81" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ف</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%82" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ق</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%ef%ae%8e" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ک</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%af" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">گ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%84" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ل</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%85" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">م</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%86" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ن</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%88" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">و</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%87" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ه</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%db%8c" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ی</font></a></td>
				</tr>
			</tbody></table>
			</div>
&nbsp;</font><p><font face="Tahoma" color="#164e8d" style="font-size: 8pt">
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs147" cols="19" rows="1" class="text" dir="ltr" >&lt;CENTER&gt;
		&lt;font style="font-size: 8pt" color="#164e8d" face="Tahoma"&gt;
		&lt;p style="MARGIN: 0px; COLOR: #ffffff"&gt;
		&lt;a href="http://www.parset.com/fun/tabir" target="_blank"&gt;
		&lt;img border="0" src="http://static.parset.com/images/Tabir/3.gif" width="160" height="120" alt="تعبیر خواب"&gt;&lt;/a&gt;&lt;/p&gt;
		&lt;div style="width: 160px; font-style: normal; font-variant: normal; font-weight: normal; font-size: 11px; font-family: tahoma; border-bottom: 1px solid #20c0c8; padding-bottom: 3px; background: url('http://nightmelody.com/blogcode/sms/bg.gif') repeat-y"&gt;
			&lt;table border="0" width="160"&gt;
				&lt;tr&gt;
					&lt;td width="80"&gt;&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a7"&gt;
					&lt;font color="#000000" size="2"&gt;الف&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a8"&gt;
					&lt;font color="#000000" size="2"&gt;ب&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%be"&gt;
					&lt;font color="#000000" size="2"&gt;پ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%aa"&gt;
					&lt;font color="#000000" size="2"&gt;ت&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ac"&gt;
					&lt;font color="#000000" size="2"&gt;ث&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86"&gt;
					&lt;font color="#000000" size="2"&gt;ج&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86"&gt;
					&lt;font color="#000000" size="2"&gt;چ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ad"&gt;
					&lt;font color="#000000" size="2"&gt;ح&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ae"&gt;
					&lt;font color="#000000" size="2"&gt;خ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%af"&gt;
					&lt;font color="#000000" size="2"&gt;د&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b0"&gt;
					&lt;font color="#000000" size="2"&gt;ذ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b1"&gt;
					&lt;font color="#000000" size="2"&gt;ر&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b2"&gt;
					&lt;font color="#000000" size="2"&gt;ز&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%98"&gt;
					&lt;font color="#000000" size="2"&gt;ژ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b3"&gt;
					&lt;font color="#000000" size="2"&gt;س&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b4"&gt;
					&lt;font color="#000000" size="2"&gt;ش&lt;/font&gt;&lt;/a&gt;&lt;/td&gt;
					&lt;td width="80"&gt;&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b5"&gt;
					&lt;font color="#000000" size="2"&gt;ص&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b6"&gt;
					&lt;font color="#000000" size="2"&gt;ض&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b7"&gt;
					&lt;font color="#000000" size="2"&gt;ط&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b8"&gt;
					&lt;font color="#000000" size="2"&gt;ظ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b9"&gt;
					&lt;font color="#000000" size="2"&gt;ع&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ba"&gt;
					&lt;font color="#000000" size="2"&gt;غ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%81"&gt;
					&lt;font color="#000000" size="2"&gt;ف&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%82"&gt;
					&lt;font color="#000000" size="2"&gt;ق&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%ef%ae%8e"&gt;
					&lt;font color="#000000" size="2"&gt;ک&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%af"&gt;
					&lt;font color="#000000" size="2"&gt;گ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%84"&gt;
					&lt;font color="#000000" size="2"&gt;ل&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%85"&gt;
					&lt;font color="#000000" size="2"&gt;م&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%86"&gt;
					&lt;font color="#000000" size="2"&gt;ن&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%88"&gt;
					&lt;font color="#000000" size="2"&gt;و&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%87"&gt;
					&lt;font color="#000000" size="2"&gt;ه&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%db%8c"&gt;
					&lt;font color="#000000" size="2"&gt;ی&lt;/font&gt;&lt;/a&gt;&lt;/td&gt;
				&lt;/tr&gt;
			&lt;/table&gt;
			&lt;a target="_blank" href="http://pichak.net/blogcod/tabir"&gt;
			&lt;span style="text-decoration: none"&gt;دریافت کد تعبیر خواب&lt;/span&gt;&lt;/a&gt;&lt;/div&gt;
&nbsp;&lt;/font&gt;&nbsp;
&lt;/CENTER&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;
 </textarea></span></font></p></td>
		<td height="594" align="center">
		
		<font face="Tahoma" color="#164e8d" style="font-size: 8pt">
		<p style="MARGIN: 0px; COLOR: #ffffff">
		<img width="160" height="120" border="0" src="http://static.parset.com/images/Tabir/2.gif"></p>
		<div style="width: 160px; font-style: normal; font-variant: normal; font-weight: normal; font-size: 11px; font-family: tahoma; border-bottom: 1px solid #20c0c8; padding-bottom: 3px; background: url('http://nightmelody.com/blogcode/sms/bg.gif') repeat-y">
			<table width="160" border="0">
				<tbody><tr>
					<td width="80"><font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a7" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">الف</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a8" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ب</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%be" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">پ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%aa" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ت</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ac" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ث</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ج</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">چ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ad" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ح</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ae" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">خ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%af" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">د</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b0" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ذ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b1" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ر</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b2" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ز</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%98" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ژ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b3" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">س</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b4" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ش</font></a></td>
					<td width="80"><font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b5" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ص</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b6" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ض</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b7" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ط</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b8" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ظ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b9" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ع</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ba" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">غ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%81" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ف</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%82" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ق</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%ef%ae%8e" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ک</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%af" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">گ</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%84" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ل</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%85" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">م</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%86" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ن</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%88" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">و</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%87" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ه</font></a><br>
					<font size="2" color="#000000">
					<img style="border: medium none" src="http://static.parset.com/images/Tabir/f.png">
					</font>
					<a href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%db%8c" target="_blank" style="color: #161a1b; text-decoration: none">
					<font size="2" color="#000000">ی</font></a></td>
				</tr>
			</tbody></table>
			</div>
&nbsp;</font><p><font face="Tahoma" color="#164e8d" style="font-size: 8pt">
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs146" cols="19" rows="1" class="text" dir="ltr" >&lt;CENTER&gt;
		&lt;font style="font-size: 8pt" color="#164e8d" face="Tahoma"&gt;
		&lt;p style="MARGIN: 0px; COLOR: #ffffff"&gt;
		&lt;a href="http://www.parset.com/fun/tabir" target="_blank"&gt;
		&lt;img border="0" src="http://static.parset.com/images/Tabir/2.gif" width="160" height="120" alt="تعبیر خواب"&gt;&lt;/a&gt;&lt;/p&gt;
		&lt;div style="width: 160px; font-style: normal; font-variant: normal; font-weight: normal; font-size: 11px; font-family: tahoma; border-bottom: 1px solid #20c0c8; padding-bottom: 3px; background: url('http://nightmelody.com/blogcode/sms/bg.gif') repeat-y"&gt;
			&lt;table border="0" width="160"&gt;
				&lt;tr&gt;
					&lt;td width="80"&gt;&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a7"&gt;
					&lt;font color="#000000" size="2"&gt;الف&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%a8"&gt;
					&lt;font color="#000000" size="2"&gt;ب&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%be"&gt;
					&lt;font color="#000000" size="2"&gt;پ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%aa"&gt;
					&lt;font color="#000000" size="2"&gt;ت&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ac"&gt;
					&lt;font color="#000000" size="2"&gt;ث&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86"&gt;
					&lt;font color="#000000" size="2"&gt;ج&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%86"&gt;
					&lt;font color="#000000" size="2"&gt;چ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ad"&gt;
					&lt;font color="#000000" size="2"&gt;ح&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ae"&gt;
					&lt;font color="#000000" size="2"&gt;خ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%af"&gt;
					&lt;font color="#000000" size="2"&gt;د&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b0"&gt;
					&lt;font color="#000000" size="2"&gt;ذ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b1"&gt;
					&lt;font color="#000000" size="2"&gt;ر&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b2"&gt;
					&lt;font color="#000000" size="2"&gt;ز&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%98"&gt;
					&lt;font color="#000000" size="2"&gt;ژ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b3"&gt;
					&lt;font color="#000000" size="2"&gt;س&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b4"&gt;
					&lt;font color="#000000" size="2"&gt;ش&lt;/font&gt;&lt;/a&gt;&lt;/td&gt;
					&lt;td width="80"&gt;&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b5"&gt;
					&lt;font color="#000000" size="2"&gt;ص&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b6"&gt;
					&lt;font color="#000000" size="2"&gt;ض&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b7"&gt;
					&lt;font color="#000000" size="2"&gt;ط&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b8"&gt;
					&lt;font color="#000000" size="2"&gt;ظ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%b9"&gt;
					&lt;font color="#000000" size="2"&gt;ع&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d8%ba"&gt;
					&lt;font color="#000000" size="2"&gt;غ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%81"&gt;
					&lt;font color="#000000" size="2"&gt;ف&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%82"&gt;
					&lt;font color="#000000" size="2"&gt;ق&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%ef%ae%8e"&gt;
					&lt;font color="#000000" size="2"&gt;ک&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%da%af"&gt;
					&lt;font color="#000000" size="2"&gt;گ&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%84"&gt;
					&lt;font color="#000000" size="2"&gt;ل&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%85"&gt;
					&lt;font color="#000000" size="2"&gt;م&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%86"&gt;
					&lt;font color="#000000" size="2"&gt;ن&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%88"&gt;
					&lt;font color="#000000" size="2"&gt;و&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%d9%87"&gt;
					&lt;font color="#000000" size="2"&gt;ه&lt;/font&gt;&lt;/a&gt;&lt;br&gt;
					&lt;font color="#000000" size="2"&gt;
					&lt;img src="http://static.parset.com/images/Tabir/f.png" style="border: medium none"&gt;
					&lt;/font&gt;
					&lt;a style="color: #161a1b; text-decoration: none" target="_blank" href="http://www.parset.com/Fun/Tabir/ShowNames/?FirstChar=%db%8c"&gt;
					&lt;font color="#000000" size="2"&gt;ی&lt;/font&gt;&lt;/a&gt;&lt;/td&gt;
				&lt;/tr&gt;
			&lt;/table&gt;
			&lt;a target="_blank" href="http://www.parset.com/Codes/TabirKhaab.aspx"&gt;
			&lt;span style="text-decoration: none"&gt;دریافت کد تعبیر خواب&lt;/span&gt;&lt;/a&gt;&lt;/div&gt;
&nbsp;&lt;/font&gt;&nbsp;
&lt;/CENTER&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;
 </textarea></span></font></p></td>
	</tr>
	<tr>
		<td height="340" align="center">
		
		<a target="_blank" href="http://www.parset.com/fun/tabir">
		<img width="120" height="240" border="0" alt="تعبیر خواب آنلاین" src="http://static.parset.com/images/Tabir/04.jpg"></a><br>
		<br>
		<span style="FONT-SIZE: 7pt">
		<textarea name="LinkUs143" cols="19" rows="1" class="text" dir="ltr" >&lt;p align="center"&gt;&lt;a href="http://www.parset.com/fun/tabir" target="_blank"&gt;&lt;img src="http://static.parset.com/images/Tabir/04.jpg" border="0" alt="تعبیر خواب آنلاین"&gt;&lt;/a&gt;&lt;li&gt;&lt;a title='تعبیر خواب' href='http://www.parset.com/fun/tabir/'&gt;تعبیر خواب&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;&lt;/div&gt;&lt;/p&gt; </textarea></span></td>
		<td height="340" align="center">
		
		&nbsp;</td>
	</tr>
	</tbody></table>            
                    </div>
                <div class="Clear">
                </div>
            </div>
        </div>
    </div>
    <div class="WinRadiusGray">
        <UCST:ShareTools ID="ShareTools1" runat="server"></UCST:ShareTools>
    </div>
    
    <UCRW:UCRandWallpaper id="UCRandWallpaper1" runat="server" />
    <div class="WinRadiusGray">
        <UCBanner:Banner ID="Banner2" positioncode="11" runat="server" />
    </div>
    <div class="Clear">
    </div>
    
</asp:Content>

