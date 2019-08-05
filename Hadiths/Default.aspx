<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Root1.master" CodeBehind="Default.aspx.cs" Inherits="Parset.Hadiths.Default" %>



<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/RandAlbum.ascx" TagName="RandAlbum" TagPrefix="RAL" %>

<%@ Register Src="~/UserControls/SmallRandPro.ascx" TagName="SmallRandPro" TagPrefix="SRP" %>
<%@ Register Src="~/UserControls/RandUsers.ascx" TagName="RandUsers" TagPrefix="RND" %>
<%@ Register Src="~/UserControls/TextLinks.ascx" TagName="TextLinks" TagPrefix="UCTextLinks" %>
<%@ Register Src="~/UserControls/RandIKid.ascx" TagName="RandIKid" TagPrefix="UCRandIKid" %>
<%@ Register Src="~/UserControls/Weather.ascx" TagName="Weather" TagPrefix="Wth" %>
<%@ Register Src="~/UserControls/TextNewsList.ascx" TagName="TextNewsList" TagPrefix="NL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="InnerBarWrap">
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnSearch" Text="جستجو" CssClass="btnSearch" runat="server" OnClick="btnSearch_Click" />
                </td>
                <td>
                    <asp:TextBox ID="txtKeyword" CssClass="txtKeyword" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="جستجو در احادیث : "></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div class="LeftCol">
        <AKP:MsgBox ID="msgText" runat="server" />
        <div class="ParsetList">
            <div class="Marginer1">
                <div class="Marginer1">
                    <div class="CoolWin">
                        <asp:HyperLink ID="hplHelpSMS" NavigateUrl="~/Help/SMSHelp.aspx" Target="_blank"
                            runat="server">
                        از این پس میتوانید متن احادیث را مستقیما به موبایل خود ارسال کنید
                        </asp:HyperLink>
                    </div>
                </div>
                <div class="Box3">
                    <div>
                        <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="گروه های اس ام اس"></asp:Label>
                    </div>
                    <div class="Clear">
                    </div>
                    <div>
                        <asp:DataList ID="dtlSMSCats" CssClass="tblSMSCats" RepeatColumns="2" RepeatDirection="Horizontal" EnableViewState="false" runat="server">
                            <ItemTemplate>
                                <asp:HyperLink ID="hplSMSCat" NavigateUrl='<%#"http://www.parset.com/SMS/ShowCat.aspx?Code=" + Eval("Code") %>' runat="server">اس ام اس&nbsp;<%#Eval("Name") %></asp:HyperLink>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                    <div class="Box3Toolbar">
                        <Tlb:Toolbar ID="tlb1" runat="server" />
                    </div>
                    
                    <div class="Clear">
                    </div>
                </div>
                <div class="MidPageBanner">
                   <UCBanner:Banner ID="Banner2" positioncode="11" runat="server" />
                </div>
                <div class="Clear">
                </div>
                <div>
                    <UCTextLinks:TextLinks ID="TextLinks1" runat="server" />
                </div>
            </div>
        </div>
        <div class="Clear">
        </div>
        <div style="direction: ltr; text-align: left;">
           <UCBanner:Banner ID="Banner1" PositionCode="16" runat="server" />
        </div>
        <div class="Clear">
        </div>
    </div>
    <div class="RightCol">
        <Mnu:Menu ID="Menu1" runat="server" />
        <div>
            <NL:TextNewsList runat="server" PageSize="50" NewsType="MostVisited" ID="TextNewsList1">
            </NL:TextNewsList>
        </div>
        <div>
            <UCProCats:ProductCats ID="ProductCats1" runat="server"></UCProCats:ProductCats>
        </div>
        <div>
            <RND:RandUsers runat="server" ID="RandUsers1" PositionCode="1" />
        </div>
        <div>
            <SRP:SmallRandPro ID="SmallRandPro1" runat="server" />
        </div>
        <div>
            <RAL:RandAlbum runat="server" ID="RandAlbum"></RAL:RandAlbum>
        </div>
        <div class="RightBanner">
           <UCBanner:Banner ID="Banner5" PositionCode="6" runat="server" />
        </div>
        <div>
            <Wth:Weather ID="Weather1" runat="server" />
        </div>
    </div>
    <div class="Clear">
    </div>
</asp:Content>
