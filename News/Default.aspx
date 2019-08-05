<%@ Page Language="C#" MasterPageFile="~/RootNoCol.master" Title="جستجوگر هوشمند خبری پارست"
    AutoEventWireup="true" Inherits="News_Default" CodeBehind="Default.aspx.cs" %>

<%@ Register Src="~/UserControls/TextNewsList.ascx" TagName="TextNewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/NewsList.ascx" TagName="NewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/UCRandSmallContent.ascx" TagName="UCRandSmallContent"
    TagPrefix="UCRSC" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>
<%@ Register Src="~/UserControls/UCMostVisitedNews.ascx" TagName="UCMostVisitedNews" TagPrefix="UCMVN" %>
<%@ Register Src="~/UserControls/UCTopNewBox.ascx" TagName="TopNewBox" TagPrefix="UC" %>
<%@ Register Src="~/UserControls/UCLatestNewsBox.ascx" TagName="LatestNewsBox" TagPrefix="UC" %>


<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <UCNCats:UCNewsCats ID="UCNewsCats1" runat="server"></UCNCats:UCNewsCats>
   
    <div class="row">

        <div class="col-md-10">
            <div class="row RTL">
                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">

                    <div>
                        <div>
                                    <UC:LatestNewsBox runat="server" />

                                </div>
                        <div class="WinRadiusGray">
                            <UCMVN:UCMostVisitedNews runat="server" />
                        </div>
                        <div class="WinRadiusGray">
                            <UCNewsFeed:UCNewsFeedTool ID="UCNewsFeedTool1" runat="server" />
                        </div>
                        <UCResources:Resources runat="server" ID="Resources"></UCResources:Resources>
                    </div>
                </div>
                <div class="col-lg-8 col-md-8 col-sm-8 col-xs-12">
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="1" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="2" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="3" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="4" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="5" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="6" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="7" runat="server" />
                    </div>
                    <div class="WinRadiusGray Padder5">
                        <UC:TopNewBox CatCode="8" runat="server" />
                    </div>



                    <div class="panel">
                        <div class="heading">
                            تصاویر خبری
                        </div>
                        <div class="PicNewsFirst" id="PicNews">

                            <asp:Repeater ID="rptRoboNewserPicNews" Visible="false" EnableViewState="false" runat="server">
                                <HeaderTemplate>
                                    <div class="PicNews">
                                </HeaderTemplate>
                                <ItemTemplate>

                                    <div class="PicItem">
                                        <asp:HyperLink ID="HyperLink5" Target="_blank" runat="server" CssClass="cEngTitle"
                                            NavigateUrl='<%#"https://www.robonewser.com/News/" +DataBinder.Eval(Container.DataItem, "Code")  + ".htm"%>'>
                                            <asp:Image ID="Image1" ImageUrl='<%#"//static.robonewser.com/Files/News/" + Eval("PicName") %>' ToolTip='<%#Eval("Title") %>'
                                                runat="server" />
                                        </asp:HyperLink>
                                    </div>

                                </ItemTemplate>
                                <FooterTemplate></div></FooterTemplate>
                            </asp:Repeater>

                            <div class="MoreLeft">
                                <asp:HyperLink ID="HyperLink3" NavigateUrl="~/News/PicNews.aspx" Target="_blank"
                                    runat="server">بیشتر »</asp:HyperLink>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                    </div>
                    <div class="WinRadiusGray">
                        <NL:NewsList runat="server" PageSize="10" ID="NewsList1">
                        </NL:NewsList>
                        <div class="MoreLeft">
                            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/News/AllNews.aspx" Target="_blank"
                                runat="server">آرشیو »</asp:HyperLink>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </div>


            </div>
        </div>
        <div class="col-md-2">
            <div class="WinRadiusGray">
                <UCBanner:Banner ID="Banner1" runat="server" PositionCode="7" />
            </div>
            <div class="WinRadiusGray">
                <UCRSC:UCRandSmallContent runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
