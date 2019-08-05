<%@ Control Language="C#" AutoEventWireup="True" Inherits="Khabardaan.Web.UI.UserControls.RelatedNews"
    CodeBehind="RelatedNews.ascx.cs" %>
<div class="Marginer1">
    <div class="lblRelatedNews">
        <h2>Related News
        </h2>
    </div>
    <asp:Panel ID="pnlBriefNews" CssClass="RoundBorder1" runat="server">
        <div class="BriefNews">
            <asp:Repeater ID="rptNews" EnableViewState="false" runat="server" >
                <ItemTemplate>
                    <div class="RelNews">
                        <article>
                            <div class="ArticleText">
                            <asp:HyperLink NavigateUrl='<%# "~/News/" +  Eval("Code")  + ".html" %>' runat="server"><%#Eval("Title") %></asp:HyperLink>
                            <div class="clearfix"></div>
                            
                        </article>

                        <div class="clearfix"></div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="MoreLeft">
                <asp:HyperLink runat="server" ID="MoreLink" CssClass="cMore2">
        All related news »</asp:HyperLink>
            </div>
            <div class="clear"></div>
        </div>
    </asp:Panel>
</div>
