<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" Inherits="DataResources_RegExTester" Codebehind="RegExTester.aspx.cs" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Site Tester</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table style="width:100%;">
        <tr>
            <td align="right" width="50%">
                <asp:Label ID="Label1" runat="server" Text="Regular Expression: "></asp:Label>
            </td>
            <td>
                <AKP:ExTextBox jas="1" ID="txtRegEx" runat="server" Height="113px" TextMode="MultiLine" 
                    Width="297px"/>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label2" runat="server" Text="Test String: "></asp:Label>
            </td>
            <td>
                <AKP:ExTextBox jas="1" ID="txtString" runat="server" Height="218px" TextMode="MultiLine" 
                    Width="293px"/>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnCheck" runat="server" onclick="btnCheck_Click" 
                    Text="Test !" />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Test With Engine" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <AKP:ExTextBox jas="1" ID="txtGroups" runat="server" Height="333px" TextMode="MultiLine" 
                    Width="664px"/>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
