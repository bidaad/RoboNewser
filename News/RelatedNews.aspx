<%@ Page Title="" Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true"
    Inherits="News_RelatedNews" CodeBehind="RelatedNews.aspx.cs" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>


<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="WinRadiusGray">
        <AKP:MsgBox ID="msgText" runat="server" />
        
        <div class="Clear"></div>
        <div class="Padder1">
            <div class="Pan1">
                <div class="cn">
                    <div class="cMainNews">
                        <div>
                            <asp:Image ID="imgPic" CssClass="img-fluid" runat="server" />
                        </div>
                        <div class="cBullet">
                        </div>
                        <h2>
                            <asp:Literal ID="hplTitle" runat="server" ></asp:Literal>
                        </h2>
                        &nbsp;
                        <asp:Label ID="lblContents" runat="server"></asp:Label>
                        <span class="cResource">
                            <asp:HyperLink ID="hplResource" runat="server"></asp:HyperLink></span> <span class="cDate">
                                <asp:Label ID="lblDate" runat="server"></asp:Label></span><br />
                    </div>
                </div>
            </div>
        </div>
        <h2>Related News
        </h2>
        <div>
            <NL:NewsList runat="server" PageSize="30" ID="NewsList1">
            </NL:NewsList>
        </div>
        <div class="ByRoboNewser">
            All news has been gathered by <a href="https://www.robonewser.com/Crawler">RoboNews Crawler</a><br />

        </div>

    </div>

    <div class="Clear">
    </div>
</asp:Content>
