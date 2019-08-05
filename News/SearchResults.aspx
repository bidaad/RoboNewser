<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Root1.master"
    CodeBehind="SearchResults.aspx.cs" Inherits="RoboNewser.News.SearchResults" %>

<%@ Register Src="~/UserControls/TextNewsList.ascx" TagName="TextNewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>


<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="WinRadiusGray">
        <NL:NewsList runat="server" PageSize="10" ID="NewsList1">
        </NL:NewsList>
        <div class="MoreLeft">
            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/News/AllNews.aspx" Target="_blank"
                runat="server">Archive »</asp:HyperLink>
        </div>
        <div class="clear">
        </div>
    </div>


</asp:Content>
