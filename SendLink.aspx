<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendLink.aspx.cs" Inherits="RoboNewser.SendLink" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ارسال لینک برای دوستان</title>
    <link id="Link2" runat="server" href="~/styles/main.css" rel="stylesheet"
        type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Marginer2">
            <AKP:MsgBox runat="server" ID="msg">
            </AKP:MsgBox>
            <div class="panel">
                <div class="heading">
                        <asp:Label ID="lblTitle" Text="ارسال لینک صفحه به دوستان" runat="server"></asp:Label>
                </div>
                
                <asp:Panel ID="pnlSendEmail" CssClass="content" runat="server">
                    <div class="Marginer1">
                        <table cellspacing="2">
                            <tr>
                                <td class="Green">
                                    <asp:RequiredFieldValidator ValidationGroup="SendPage" ControlToValidate="txtFrom"
                                        ID="RFV9" Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                                        runat="server" ErrorMessage="نام خود را وارد کنید" ForeColor="Maroon"></asp:RequiredFieldValidator>
                                    <asp:TextBox ID="txtFrom" Width="150" runat="server"></asp:TextBox>
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
                                    <asp:TextBox ID="txtFromEmail" Width="150" SkinID="English" CssClass="Eng" runat="server"></asp:TextBox>
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
                                    <asp:TextBox ID="txtTo" Width="150" runat="server"></asp:TextBox>
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
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ControlToValidate="txtToEmail" ValidationGroup="SendPage" ErrorMessage="ایمیل معتبر نیست"></asp:RegularExpressionValidator>
                                    <asp:TextBox ID="txtToEmail" Width="150" SkinID="English" CssClass="Eng" runat="server"></asp:TextBox>
                                </td>
                                <td class="cSendLabel">
                                    <asp:Label ID="Label1" runat="server" Text="ایمیل دوست شما"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="Green">
                                    <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="5" Width="300" runat="server"></asp:TextBox>
                                </td>
                                <td class="cSendLabel">
                                    <asp:Label ID="Label4" runat="server" Text="متن پیام"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <div style="padding: 5px;">
                            <table>
                                <tr>
                                    <td style="text-align: left">
                                        <asp:LinkButton ID="btnSend" ValidationGroup="SendPage" Text="ارسال" CssClass="button"
                                            runat="server" OnClick="btnSend_Click" />
                                    </td>
                                    <td style="text-align: right">
                                        <asp:LinkButton ID="btnCancel" Text="انصراف" CssClass="button" runat="server" OnClientClick="window.close()" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
