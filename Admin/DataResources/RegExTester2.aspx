<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false"
    Inherits="DataResources_RegExTester2" Codebehind="RegExTester2.aspx.cs" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Site Tester</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center">
            <table border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td align="right" style="width: 104px">
                        <asp:Label ID="Label1" runat="server" Text="Extracted Str:"></asp:Label>
                    </td>
                    <td align="left">
                        <AKP:ExTextBox jas="1" ID="txtExp1" runat="server" TextMode="MultiLine" Width="500px"/>
                    </td>
                    <td align="left">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 104px">
                        <asp:Label ID="Label4" runat="server" Text="String :"></asp:Label>
                    </td>
                    <td align="left">
                        <AKP:ExTextBox jas="1" ID="txtstr" runat="server" Height="281px" TextMode="MultiLine" Width="500px"/>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 104px">
                        <asp:Label ID="Label5" runat="server" Text="RegEx :"></asp:Label>
                    </td>
                    <td align="left">
                        <AKP:ExTextBox jas="1" ID="txtRegEx" runat="server" Width="500px" Height="103px" TextMode="MultiLine"/>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="2">
                        <div style="text-align: left">
                            <table border="0" cellpadding="2" cellspacing="0">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="Index:"></asp:Label>
                                    </td>
                                    <td>
                                        <AKP:ExTextBox jas="1" ID="txtIndex1" runat="server" Width="50px"/>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </td>
                    <td align="right" colspan="1">
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" />
                    </td>
                    <td align="center" colspan="1">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 104px">
                        <asp:Button ID="Button3" runat="server" Text="<<Back" OnClick="Button3_Click" />
                    </td>
                    <td align="left">
                        <asp:Button ID="Button2" runat="server" Text="Next>>" OnClick="Button2_Click" />
                    </td>
                    <td align="left">
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
