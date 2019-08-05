<%@ Page Language="C#" AutoEventWireup="true" Inherits="GBN.Web.UI.Admin.DataResources.TestKeyword" Codebehind="TestKeyword.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rptKeywords" EnableViewState="false" runat="server">
            <ItemTemplate>
                <div><%# Container.DataItem %></div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:TextBox ID="TextBox1" TextMode="MultiLine" Width="600" Height="400" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnGenKeywords" runat="server" Text="Generate Keywords" 
            onclick="btnGenKeywords_Click" />
    </div>
    <div>
    </div>
    </form>
</body>
</html>
