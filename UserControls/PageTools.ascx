<%@ Control Language="C#" AutoEventWireup="true" Inherits="DMS.Web.UI.UserControls.PageTools" Codebehind="PageTools.ascx.cs" %>
<%--<%@ Register Src="~/UserControls/Stars.ascx" TagName="Stars" TagPrefix="UCStars" %>--%>

<!--[if gte IE 5]> <style type="text/css"> #blanket {filter:alpha(opacity=65);}</style><![endif]--> 
<div class="PageTools">
    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <div id="blanket" style="display:none;"></div> 
            
            <ul>
                <li>
                    <div class="SendToFiendsButton" onclick="popup('<%=pnlSendEmail.ClientID %>')">
                    <asp:HyperLink ID="HyperLink1" ToolTip="ارسال این صفحه به دوستان" runat="server"></asp:HyperLink>
                    </div>
                </li>
                <li>
                     
                    <div class="PrintButton" onclick="PrintPage()" >
                        <asp:HyperLink ID="hplPrint" ToolTip="چاپ" runat="server"></asp:HyperLink></div>
                </li>
                <%--<li>
                    <UCStars:Stars runat="server" ID="Stars1"></UCStars:Stars>
                </li>--%>
            </ul>
            <asp:Panel ID="pnlSendEmail" CssClass="pnlSendMessage" style="display:none;" runat="server">
                <div> <AKP:MsgBox runat="server" ID="msg"></AKP:MsgBox> </div>
                <div class="Marginer1">
                    <div class="CloseBtn" onclick="popup('<%=pnlSendEmail.ClientID %>')"></div>
                    
                    <table class="tblSendTF" cellspacing="2">
                        <tr>
                            <th colspan="2">
                                <asp:Label ID="lblSendPage" runat="server" Text="ارسال صفحه"></asp:Label>
                            </th>
                        </tr>
                        <tr>
                            <td class="Green">
                                <asp:RequiredFieldValidator ValidationGroup="SendPage" ControlToValidate="txtFrom"
                                    ID="RFV9" Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                                    runat="server" ErrorMessage="نام خود را وارد کنید" ForeColor="Maroon"></asp:RequiredFieldValidator>
                                <AKP:ExTextBox ID="txtFrom" CssClass="cInput" Width="150" runat="server"></AKP:ExTextBox>
                            </td>
                            <td class="cSendLabel">
                                <asp:Label ID="Label2" runat="server" Text="نام شما"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Green">
                                <asp:RequiredFieldValidator ValidationGroup="SendPage" ControlToValidate="txtFrom"
                                    ID="RequiredFieldValidator1" Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                                    runat="server" ErrorMessage="ایمیل خود را وارد کنید" ForeColor="Maroon"></asp:RequiredFieldValidator>
                                <AKP:ExTextBox ID="txtFromEmail" CssClass="cEngInput" Width="150" SkinID="English" runat="server"></AKP:ExTextBox>
                            </td>
                            <td class="cSendLabel">
                                <asp:Label ID="Label5" runat="server" Text="ایمیل شما"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Green">
                                <asp:RequiredFieldValidator ValidationGroup="SendPage" ControlToValidate="txtFrom"
                                    ID="RequiredFieldValidator2" Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                                    runat="server" ErrorMessage="نام دوست خود را وارد کنید" ForeColor="Maroon"></asp:RequiredFieldValidator>
                                <AKP:ExTextBox ID="txtTo" CssClass="cInput" Width="150" runat="server"></AKP:ExTextBox>
                            </td>
                            <td class="cSendLabel">
                                <asp:Label ID="Label3" runat="server" Text="نام دوست شما"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Green">
                                <asp:RequiredFieldValidator ValidationGroup="SendPage" ControlToValidate="txtFrom"
                                    ID="RequiredFieldValidator3" Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                                    runat="server" ErrorMessage="ایمیل دوست خود را وارد کنید" ForeColor="Maroon"></asp:RequiredFieldValidator>
                                <AKP:ExTextBox ID="txtToEmail" CssClass="cEngInput" Width="150" SkinID="English" runat="server"></AKP:ExTextBox>
                            </td>
                            <td class="cSendLabel">
                                <asp:Label ID="Label1" runat="server" Text="ایمیل دوست شما"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="Green">
                                <AKP:ExTextBox ID="txtMessage" CssClass="cInput" Width="150" TextMode="MultiLine" Rows="5" runat="server"></AKP:ExTextBox>
                            </td>
                            <td class="cSendLabel">
                                <asp:Label ID="Label4" runat="server" Text="متن پیام"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <div style="padding: 5px;">
                        <table style="width:160px;" cellpadding="5" cellspacing="5">
                            <tr>
                                <td style="text-align: left">
                                    <asp:LinkButton ID="btnSend" ValidationGroup="SendPage" Text="ارسال" CssClass="button"
                                        runat="server" OnClick="btnSend_Click" />
                                </td>
                                <td style="text-align: right">
                                    <a class="button" href="javascript:popup('<%=pnlSendEmail.ClientID %>')">انصراف</a>
                                    
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </asp:Panel>
        <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
</div>
