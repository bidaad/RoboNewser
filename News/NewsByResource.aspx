<%@ Page Title="" Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="True"
    Inherits="News_NewsByResource" CodeBehind="NewsByResource.aspx.cs" %>

<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>


<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
<UCNCats:UCNewsCats ID="UCNewsCats1" runat="server"></UCNCats:UCNewsCats>
   

    <div class="NewsCols">
        <div class="NewsColsLeft">
            <div class="WinRadiusGray">
                <UCBanner:Banner ID="Banner2" runat="server" PositionCode="7" />
            </div>
            <div class="WinRadiusGray">
                <UCBanner:Banner ID="Banner3" runat="server" PositionCode="8" />
            </div>
            <div class="WinRadiusGray">
                <UCRSC:UCRandSmallContent runat="server" />
            </div>
            <div class="WinRadiusGray">
                <UCBanner:Banner ID="Banner4" runat="server" PositionCode="9" />
            </div>
            <div class="WinRadiusGray">
                <UCBanner:Banner ID="Banner5" runat="server" PositionCode="10" />
            </div>
        </div>
        <div class="NewsColsRight">
            <div class="ActualMidCol">
                <div class="WinRadiusGray">
                <div class="Box3">
                    <div class="NHeader1">
                        <h3>
                        <asp:literal ID="lblResourceTitle" runat="server"></asp:literal></h3>
                    </div>
                    <div class="Clear">
                    </div>
                    <div>
                        <NL:NewsList runat="server" PageSize="30" ID="NewsList1">
                        </NL:NewsList>
                    </div>
                    <div class="ByKhabardaan">
                        گردآوری اخبار بوسیله ربات جستجوگر <a href="http://www.RoboNewser.com" target="_blank">پارست</a>
                    </div>
                    <div class="Box3Toolbar">
                        <Tlb:Toolbar ID="tlb1" runat="server" />
                    </div>
                </div>
                </div>
                <div class="WinRadiusGray">
                        
                    </div>
            </div>
            <div class="ActualRightCol">
                <div class="WinRadiusGray">
                        <MNU:Menu runat="server" />
                    </div>
                <div class="WinRadiusGray">
                    <UCMVN:UCMostVisitedNews runat="server" />
                </div>
                <div class="WinRadiusGray">
                    <UCResources:Resources runat="server" ID="Resources"></UCResources:Resources>
                </div>
                                <div class="WinRadiusGray">
                <UCNewsFeed:UCNewsFeedTool runat="server" />
                </div>

                
                <div class="WinRadiusGray">
                    <Wth:Weather ID="Weather1" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
