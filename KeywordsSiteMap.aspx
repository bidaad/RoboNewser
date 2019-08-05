<%@ Page Language="C#" AutoEventWireup="true" Inherits="KeywordsSiteMap" Codebehind="KeywordsSiteMap.aspx.cs" %>
<?xml version="1.0" encoding="utf-8"?>
<urlset xmlns="http://www.google.com/schemas/sitemap/0.84">
<asp:Repeater runat="server" ID="rptKeywords" EnableViewState="False">
<ItemTemplate>
    <url>
        <loc>https://www.robonewser.com/K/<%#Tools.ReplaceSpaceWithUnderline(Eval("Name"))%>.html</loc>
        <lastmod>2011-01-01</lastmod>
        <changefreq>monthly</changefreq>
        <priority>0.8</priority>
    </url>
</ItemTemplate>
</asp:Repeater>
</urlset>
