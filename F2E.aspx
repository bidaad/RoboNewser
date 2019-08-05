<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F2E.aspx.cs" Inherits="Parsetv91._1.F2E" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Item {
            direction:rtl;
            font-family:Tahoma;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CatCode:<asp:TextBox ID="txtCatCode" runat="server"></asp:TextBox>

        </div>
    <div>
        <asp:Repeater ID="rptContents" runat="server">
            <ItemTemplate>
                <div class="Item">
                <asp:HyperLink NavigateUrl='<%#"~/Admin/Translate/F2EContent.aspx?Code=" + Eval("Code") + "&CatCode=" + CatCode %>'  runat="server">
                    <%#Eval("Title") %>
                </asp:HyperLink>
                    </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
        <div class="Item">
            <h1>
                <asp:Literal ID="ltrCount" runat="server"></asp:Literal>
            </h1>
        </div>
    </form>
</body>
</html>
