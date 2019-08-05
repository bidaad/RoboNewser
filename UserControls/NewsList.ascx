<%@ Control Language="C#" AutoEventWireup="True" Inherits="Khabardaan.Web.UI.UserControls.NewsList"
    CodeBehind="NewsList.ascx.cs" %>
<%@ Register Src="~/UserControls/KeywordList.ascx" TagName="KeywordList" TagPrefix="KL" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/RelatedNews.ascx" TagName="RelatedNews" TagPrefix="RNews" %>
<div class="cSpacer"></div>
<div class="Padder20">
    <h2 class="BoxHeader">
        <asp:Literal ID="lblMessage" runat="server" Text=""></asp:Literal>
    </h2>
    <div class="clear"></div>
    <div class="RoundBorder1 NewsList">
        <asp:Repeater ID="rptNewsList" runat="server" OnItemDataBound="rptNewsList_ItemDataBound">
            <ItemTemplate>
                <article>
                    <div class="row">
                        <div class="col-lg-9 col-md-9 col-sm-9 ">
                            <h4><asp:HyperLink ToolTip='<%#Eval("Title") %>' NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server"><%#Eval("Title") %></asp:HyperLink></h4>
                            <div class="clearfix"></div>
                            <div class="ResourceName"><span><%#Eval("ResourceName") %></span></div>
                            <div class="DotSeperator">.</div>
                            <time datetime="<%#((DateTime) Eval("NewsDate")).ToString("yyyy-MM-dd HH':'mm':'ss") %>"><%# Tools.GetPrettyDate(Convert.ToDateTime( Eval("NewsDate"))) %></time>
                            <div class="DotSeperator">.</div>
                            <div class="RelatedNews">
                                <asp:HiddenField ID="hfRelatedNews" Value='<%#Eval("Code") %>' runat="server" />
                                <asp:HyperLink ID="hplRelatedNews"  runat="server"></asp:HyperLink>
                            </div>
                            <div class="clearfix"></div>
                            <div class="text-justify">
                                <%#ShowText( Eval("Contents")) %>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-3 col-md-3 d-none d-sm-block ">
                            <figure class="Newsfig d-none d-sm-block">
                                <asp:HiddenField ID="hfPic" Value='<%# Eval("PicName") %>' runat="server" />
                                <asp:HyperLink ID="hplimgNews" ToolTip='<%#Eval("Title") %>' NavigateUrl='<%# "~/News/" + Eval("Code") +  ".html" %>' runat="server">
                                <asp:Image runat="server" ID="imgNews" AlternateText='<%#Eval("Title") %>' ToolTip='<%#Eval("Title") %>'  ImageUrl='<%# "//static.robonewser.com/Files/News/" + Eval("PicName") %>' />
                                    </asp:HyperLink>
                            </figure>
                        </div>
                    </div>


                </article>
                <div class="clearfix"></div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
<p>
    <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
    <div class="clear"></div>
