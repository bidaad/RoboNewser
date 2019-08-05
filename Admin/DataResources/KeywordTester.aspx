<%@ Page Language="C#" AutoEventWireup="true" Inherits="GBN.Web.UI.Admin.DataResources.KeywordTester" Codebehind="KeywordTester.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Content:"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="txtText" TextMode="MultiLine" Width="700" Height="400" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnGen" OnClick="btnGen_Click" runat="server" Text="Generate" />
    </div>
    <div>
        <asp:Repeater ID="rptKeywords" runat="server">
            <ItemTemplate>
                <%#DataBinder.Eval(Container.DataItem, "Keyword")%>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
