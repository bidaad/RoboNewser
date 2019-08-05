<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/RootNoCol.master" CodeBehind="URNewsByResource.aspx.cs" Inherits="RoboNewser.News.URNewsByResource" %>

<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>

<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>
<%@ Register Src="~/UserControls/UCMostVisitedNews.ascx" TagName="UCMostVisitedNews" TagPrefix="UCMVN" %>


<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <UCNCats:UCNewsCats ID="UCNewsCats1" runat="server"></UCNCats:UCNewsCats>


    <div class="row">
        <div class="col-md-10">
            <div class="row">

                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">

                    <div class="WinRadiusGray">
                        <UCMVN:UCMostVisitedNews runat="server" />
                    </div>
                        <UCResources:Resources runat="server" ID="Resources"></UCResources:Resources>
                    <div class="WinRadiusGray">
                        <UCNewsFeed:UCNewsFeedTool ID="UCNewsFeedTool1" runat="server" />
                    </div>
                    <div class="WinRadiusGray">
                        <Wth:Weather ID="Weather1" runat="server" />
                    </div>
                </div>
                <div class="col-lg-8 col-md-8 col-sm-8 col-xs-12">
                    <div class="panel">
                        
                            <div class="heading">
                                
                                    <asp:Literal ID="lblResourceTitle" runat="server"></asp:Literal>
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
            </div>
        </div>
        <div class="col-md-2">
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

    </div>
</asp:Content>
