<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinyPagerToolbar.ascx.cs" Inherits="RoboNewser.UserControls.TinyPagerToolbar" %>
<div class="PagerContainer">
    <div class="pager">
        <ul>
            <li>
                <asp:HyperLink ID="hplFirstPage" runat="server" Text=" صفحه اول "></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="hplPrePage" runat="server" Text=" صفحه قبل "></asp:HyperLink></li>
            
            <li>
                <asp:HyperLink ID="hplNextPage" runat="server" Text=" صفحه بعد "></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="hplLastPage" runat="server" Text=" صفحه آخر "></asp:HyperLink></li>
        </ul>
    </div>
    <br />
</div>
