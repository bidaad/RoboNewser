<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_UserMenu" Codebehind="UserMenu.ascx.cs" %>
<table class="tblMainMenu">
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Users/Home.aspx" runat="server">صفحه من</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink6" NavigateUrl="~/Users/AccountCharge.aspx" runat="server">شارژ حساب</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink7" NavigateUrl="~/Users/UserTransList.aspx" runat="server">تراکنشها</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Users/" runat="server">جستجو</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Users/Friends.aspx" runat="server">دوستان</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink5" NavigateUrl="~/Users/Albums.aspx" runat="server">عکسها</asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="hplMessages" NavigateUrl="~/Users/Messages.aspx" runat="server">پیامها</asp:HyperLink>
        </td>
       
        
        <td>
            <asp:HyperLink ID="HyperLink14" NavigateUrl="~/Users/Settings.aspx" runat="server">تنظیمات</asp:HyperLink>
        </td>
    </tr>
</table>
