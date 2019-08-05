<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Parsetv91._1.Admin.Tabir.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:button id="btnCorrectYa" runat="server" onclick="btnCorrectYa_Click" text="CorrectYa" />

        </div>
        <div>
            <asp:label id="lblMessage" runat="server"></asp:label>
        </div>
        <div>
            <asp:button id="btnRemoveDuplicates" runat="server" onclick="btnRemoveDuplicates_Click" text="RemoveDuplicates" />
        </div>
        <div>
                &nbsp;<asp:Button ID="btnakairan" runat="server" OnClick="btnakairan_Click" Text="akairan" />
        </div>
    </form>
</body>
</html>
