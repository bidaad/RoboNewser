<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="F2EContent.aspx.cs" Inherits="Parsetv91._1.Admin.Translate.F2EContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input, textarea {
            font-family: Tahoma;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtTitle" onclick="this.select()" Width="500" runat="server"></asp:TextBox></td>
                                <td>عنوان</td>

                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtContent" onclick="this.select()" EnableViewState="false" TextMode="MultiLine" Width="500" Height="400" runat="server"></asp:TextBox></td>
                                <td>متن</td>

                            </tr>

                        </table>

                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtEngTitle" Width="500" runat="server"></asp:TextBox></td>
                                <td>Title</td>

                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtEngText" EnableViewState="false" TextMode="MultiLine" Width="500" Height="400" runat="server"></asp:TextBox></td>
                                <td>Content</td>

                            </tr>

                        </table>

                    </td>

                </tr>


            </table>
            <table>


                <tr>
                    <td >
                        <asp:Button ID="btnTranslate" runat="server" Text="Translate" OnClick="btnTranslate_Click" />

                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/F2E.aspx" runat="server">بازگشت</asp:HyperLink>

                    </td>

                </tr>

            </table>
        </div>
    </form>
</body>
</html>
