<%@ Page Title="" Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" CodeBehind="URNewsByKeywordByName.aspx.cs" Inherits="RoboNewser.News.URNewsByKeywordByName" %>
<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>

<%@ Register Src="~/UserControls/RelatedNews.ascx" TagName="RelatedNews" TagPrefix="RNews" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>
<%@ Register Src="~/UserControls/UCMostVisitedNews.ascx" TagName="UCMostVisitedNews" TagPrefix="UCMVN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="panel">
        <h2>
            <asp:Literal ID="lblTitle" runat="server"></asp:Literal>
        </h2>
        <div class="Clear">
        </div>
        <div>
            <NL:NewsList runat="server" PageSize="30" ID="NewsList1">
            </NL:NewsList>
        </div>
        <h2>Other Keywords</h2>
        <div class="RoundBorder1">
        <div class="KeywordList">
            <asp:DataList ID="dtlOtherKeywords" CssClass="tblTags" RepeatColumns="4" runat="server">
                <ItemTemplate>
                    <div><asp:HyperLink NavigateUrl='<%#"~/K/" + Tools.ReplaceSpaceWithUnderline(Eval("Name")) + ".html"%>' runat="server"><%#Eval("Name") %></asp:HyperLink></div>
                </ItemTemplate>
            </asp:DataList>

        </div>
            </div>
        <div class="ByRoboNewser">
            All news has been gathered by <a href="https://www.robonewser.com/Crawler">RoboNews Crawler</a><br />
        </div>
    </div>
</asp:Content>
