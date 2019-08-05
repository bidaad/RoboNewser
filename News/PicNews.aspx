<%@ Page Language="C#" AutoEventWireup="true" Title="تصاویر خبری" MasterPageFile="~/RootNoCol.master"
    CodeBehind="PicNews.aspx.cs" Inherits="EngRoboNewser.News.PicNews" %>

<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/TextNewsList.ascx" TagName="TextNewsList" TagPrefix="NL" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="CP1">
    <UCNCats:UCNewsCats ID="UCNewsCats1" runat="server"></UCNCats:UCNewsCats>

    <div class="rows">
        <div class="col-md-3">
            
            <div class="WinRadiusGray">
                <NL:TextNewsList runat="server" PageSize="50" NewsType="MostVisited" ID="tnMostVisited"></NL:TextNewsList>
            </div>
            <div class="WinRadiusGray">
                <UCNewsFeed:UCNewsFeedTool ID="UCNewsFeedTool1" runat="server" />
            </div>
            <div class="WinRadiusGray">
                <UCResources:Resources runat="server" ID="Resources"></UCResources:Resources>
            </div>
        </div>
        <div class="col-md-9">
            <div class="WinRadiusGray">
                <div class="CatHeaderCont">
                    <h3 class="CatHeader">
                        <asp:Label ID="lblCatTitle" Text="تصاویر خبری"
                            runat="server"></asp:Label>
                    </h3>
                </div>
                <div class="clear">
                </div>
                <div style="margin: 15px;">
                    <div>

                        <div>
                            <asp:Repeater ID="rptNewsList" EnableViewState="false"
                                runat="server">
                                <HeaderTemplate>
                                    <ul>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li>
                                        <div class="PicItem">
                                            <asp:HyperLink ID="HyperLink1" Target="_blank" ToolTip='<%#Eval("Title") %>' runat="server"
                                                CssClass="cTitle" NavigateUrl='<%#"https://www.robonewser.com/News/" +DataBinder.Eval(Container.DataItem, "Code")  + ".htm"%>'><%#ShowPic(DataBinder.Eval(Container.DataItem, "Title"),DataBinder.Eval(Container.DataItem, "PicName"))%></asp:HyperLink>
                                        </div>
                                    </li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul>

                                </FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                    <p>
                        <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
                    </p>
                </div>
                <div class="clear">
                </div>
            </div>
        </div>

    </div>

</asp:Content>
