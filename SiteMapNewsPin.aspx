<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SiteMapNewsPin.aspx.cs" Inherits="RoboNewser.SiteMapNewsPin" %>
<urlset xmlns="http://www.google.com/schemas/sitemap/0.84">
<asp:Repeater runat="server" ID="rptNews" EnableViewState="False">
<ItemTemplate>
    <url>
        <loc>https://www.robonewser.com/News/<%#Eval("Code")%>.html</loc>
    </url>
</ItemTemplate>
</asp:Repeater>
</urlset>
