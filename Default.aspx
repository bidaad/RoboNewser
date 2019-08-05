<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="True" Inherits="_Default"
    Title="RoboNewser" CodeBehind="Default.aspx.cs" %>

<%@ Register Src="~/UserControls/NewsList.ascx" TagName="List" TagPrefix="News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div style="margin-bottom:10px;margin-top:10px;">
        <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
<!-- RoboNewser RES 1 -->
<ins class="adsbygoogle"
     style="display:block"
     data-ad-client="ca-pub-6817401274208407"
     data-ad-slot="8374384436"
     data-ad-format="auto"
     data-full-width-responsive="true"></ins>
<script>
    (adsbygoogle = window.adsbygoogle || []).push({});
</script>
    </div>
    <div>
        <h2>Headlines
        </h2>
        <div class="RoundBorder1">
            <asp:Repeater ID="rptHeadlines" runat="server" OnItemDataBound="rptHeadlines_ItemDataBound">
                <ItemTemplate>
                    <article>
                        <div class="row">
                            <div class="col-lg-9 col-md-9 col-sm-9 ">
                                <h4>
                                    <asp:HyperLink NavigateUrl='<%# "~/News/" + Eval("Code") + ".html" %>' runat="server"><%#Eval("Title") %></asp:HyperLink></h4>
                                <div class="clearfix"></div>
                                <div class="ResourceName"><span><%#Eval("ResourceSite") %></span></div>
                                <div class="DotSeperator">.</div>
                                <time datetime="<%#((DateTime) Eval("NewsDate")).ToString("yyyy-MM-dd HH':'mm':'ss") %>"><%# Tools.GetPrettyDate(Convert.ToDateTime( Eval("NewsDate"))) %></time>
                                <div class="DotSeperator">.</div>
                                <div class="RelatedNews">
                                    <asp:HiddenField ID="hfRelatedNews" Value='<%#Eval("Code") %>' runat="server" />
                                    <asp:HyperLink ID="hplRelatedNews" runat="server"></asp:HyperLink>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-3 col-md-3 d-none d-sm-block ">
                                <figure class="Newsfig d-none d-sm-block">
                                    <asp:HiddenField ID="hfPic" Value='<%# Eval("PicName") %>' runat="server" />
                                    <asp:Image runat="server" ToolTip='<%#Eval("Title") %>' AlternateText='<%#Eval("Title") %>' ID="imgNews" CssClass="" ImageUrl='<%# "//static.robonewser.com/Files/News/" + Eval("PicName") %>' />
                                </figure>
                            </div>
                        </div>
                    </article>
                    <div class="clearfix"></div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
    
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="WorldNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="BusinessNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="TechnologyNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="EntertainmentNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="SportsNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="ScienceNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>
    <div>

        <div class="">
            <News:List id="HealthNews" ShowPager="false" runat="server" />

        </div>
    </div>
    <div class="Clear">
    </div>

</asp:Content>
