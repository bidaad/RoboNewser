<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCBannerList.ascx.cs"
    Inherits="Parsetv91._1.UserControls.UCBannerList" %>
<asp:Repeater ID="rptBanners" EnableViewState="false" runat="server">
    <ItemTemplate>
        <div class="SmallContentItem">
            <div class="SmallContentImg">
                <asp:HyperLink  Target="_blank" ImageUrl='<%#"http://static.parset.com/Files/Banners/" + Eval("BanFile") %>'
                    NavigateUrl='<%#"http://" + Eval("TargetUrl") %>' runat="server"></asp:HyperLink></div>
            <div>
                <asp:HyperLink CssClass="AContSmall" Target="_blank" NavigateUrl='<%#"http://" + Eval("TargetUrl") %>' Text='<%#Eval("Text") %>' runat="server"></asp:HyperLink></div>
        </div>
    </ItemTemplate>
</asp:Repeater>
