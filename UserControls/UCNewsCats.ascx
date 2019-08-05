<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsCats.ascx.cs"
    Inherits="RoboNewser.UserControls.UCNewsCats" %>
<div class="NewsCatCont">
    
    <div class="ActualNewsCatContainer">
    <ul class="NewsCats"><li><asp:HyperLink  NavigateUrl="~/News/Default.aspx" runat="server">صفحه اول خبرها</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=1" runat="server">اجتماعي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=2" runat="server">اقتصادي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=3" runat="server">سياسي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=4" runat="server">ورزشي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=5" runat="server">علمي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=6" runat="server">فرهنگي</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=7" runat="server">ادب و هنر</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=8" runat="server">بين‌الملل</asp:HyperLink></li><li><asp:HyperLink  NavigateUrl="~/News/NewsByCatCode.aspx?Code=9" runat="server">حوادث</asp:HyperLink></li></ul>
    </div>
</div>
