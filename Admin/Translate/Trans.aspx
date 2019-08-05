<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Trans.aspx.cs" Inherits="Parsetv91._1.Admin.Translate.Trans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtSource" Width="500" SkinID="None" Height="400" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Literal ID="ltrResult" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
