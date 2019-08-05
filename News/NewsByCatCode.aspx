<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true"
    Inherits="News_NewsByCatCode" CodeBehind="NewsByCatCode.aspx.cs" %>

<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>


<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div>
        <h2>
            <asp:Literal ID="ltrHeader" runat="server"></asp:Literal>
        </h2>
    </div>

    <NL:NewsList runat="server" ID="NewsList1">
    </NL:NewsList>
    <div class="clear">
    </div>
</asp:Content>
