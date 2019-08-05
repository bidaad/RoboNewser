<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="News3Col.ascx.cs" Inherits="RoboNewser.UserControls.News3Col" %>
<ul class="news-3-col">
    <asp:Repeater ID="rptNews61" runat="server">
        <ItemTemplate>
            <li>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>'  NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                        <asp:Image runat="server" ID="imgNews" CssClass="imgNews3Col" ToolTip='<%#Eval("Title") %>' ImageUrl='<%# Eval("ImgUrl") %>' />
                    </asp:HyperLink>
                </div>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                    <%#Eval("Title") %>&nbsp;.&nbsp;<span class="resource"><%#Eval("ResourceSite") %></span>
                    </asp:HyperLink>
                </div>
            </li>
        </ItemTemplate>
    </asp:Repeater>

</ul>
<div class="clearfix"></div>
<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- RoboNewser RES3 -->
<ins class="adsbygoogle"
     style="display:block"
     data-ad-client="ca-pub-6817401274208407"
     data-ad-slot="8542782078"
     data-ad-format="auto"
     data-full-width-responsive="true"></ins>
<script>
(adsbygoogle = window.adsbygoogle || []).push({});
</script>
<div class="clearfix"></div>
<ul class="news-2-col">
    <asp:Repeater ID="rptNews41" runat="server">
        <ItemTemplate>
            <li>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                        <asp:Image runat="server" ID="imgNews" CssClass="imgNews3Col" ToolTip='<%#Eval("Title") %>' ImageUrl='<%# Eval("ImgUrl") %>' />
                    </asp:HyperLink>
                </div>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                    <%#Eval("Title") %>&nbsp;.&nbsp;<span class="resource"><%#Eval("ResourceSite") %></span>
                    </asp:HyperLink>
                </div>
            </li>
        </ItemTemplate>
    </asp:Repeater>

</ul>
<ul class="news-3-col">
    <asp:Repeater ID="rptNews62" runat="server">
        <ItemTemplate>
            <li>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                        <asp:Image runat="server" ID="imgNews" CssClass="imgNews3Col" ToolTip='<%#Eval("Title") %>' ImageUrl='<%# Eval("ImgUrl") %>' />
                    </asp:HyperLink>
                </div>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                    <%#Eval("Title") %>&nbsp;.&nbsp;<span class="resource"><%#Eval("ResourceSite") %></span>
                    </asp:HyperLink>
                </div>
            </li>
        </ItemTemplate>
    </asp:Repeater>

</ul>
<div class="clearfix"></div>
<ul class="news-2-col">
    <asp:Repeater ID="rptNews42" runat="server">
        <ItemTemplate>
            <li>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                        <asp:Image runat="server" ID="imgNews" CssClass="imgNews3Col" ToolTip='<%#Eval("Title") %>' ImageUrl='<%# Eval("ImgUrl") %>' />
                    </asp:HyperLink>
                </div>
                <div>
                    <asp:HyperLink ToolTip='<%#Eval("Title") %>' Target="_blank" NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                    <%#Eval("Title") %>&nbsp;.&nbsp;<span class="resource"><%#Eval("ResourceSite") %></span>
                    </asp:HyperLink>
                </div>
            </li>
        </ItemTemplate>
    </asp:Repeater>

</ul>