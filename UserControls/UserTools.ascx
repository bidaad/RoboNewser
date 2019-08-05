<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_UserTools" Codebehind="UserTools.ascx.cs" %>
<div class="Marginer1">
    <div class="BlueHeader">
        <asp:Label ID="Label1" runat="server" Text="ابزارهای کاربر"></asp:Label>
    </div>
    <div class="UserTools">
    <div class="MyBuys">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Users/UserBuys.aspx" runat="server">خریدهای من</asp:HyperLink>
    </div>
    <div class="MyBuys">
        <asp:HyperLink ID="HyperLink5" NavigateUrl="~/Users/AdvCode.aspx" runat="server">دریافت کد</asp:HyperLink>
    </div>
    <div class="ChangeInfo">
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Users/Profile.aspx" runat="server">تغییر مشخصات</asp:HyperLink>
    </div>
    <div class="ChangePass">
        <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Users/ChangePassword.aspx" runat="server">تغییر کلمه عبور</asp:HyperLink>
    </div>
    <div class="Logout">
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Users/Logout.aspx" runat="server">خروج</asp:HyperLink>
    </div>
    </div>
</div>
