
<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="UserControls_SmallRandPro" Codebehind="SmallRandPro.ascx.cs" %>
<div class="SmallProPic">
    <%--UCBanner:Banner ID="Banner1" PositionCode="13" runat="server" />--%>
    <%--<asp:HyperLink runat="server" ID="hplPicFile" /></div>
<div>
    <asp:HyperLink ID="hplTitle" runat="server" Target="_blank" CssClass="cTitle"></asp:HyperLink>&nbsp;
     <asp:Label ID="lblPrice" runat="server" Target="_blank" CssClass="Price"></asp:Label>
            &nbsp;ریال--%>
    <asp:Repeater ID="rptTextAds" EnableViewState="false" runat="server">
        <HeaderTemplate>
            <div class="cUserADTopHead">
                تبلیغات
            </div>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="UserTextAD">
                
                    <div class="ADHead" style="color: #<%#GetColor()%>">
                        <a href="http://<%#DataBinder.Eval(Container.DataItem, "Link")%>"
                    target="_blank">
                        <%#DataBinder.Eval(Container.DataItem, "Title")%>
                            </a>
                    </div>
                    <div>
                        <%#DataBinder.Eval(Container.DataItem, "Description")%>
                    </div>
                
            </div>
        </ItemTemplate>
        <FooterTemplate>
            <div class="UserTextADSFooter">
                <asp:HyperLink runat="server" ToolTip="با پرداخت 10000 تومان در ماه 10000 بار در هر روز دیده شوید"
                    NavigateUrl="~/Advertise.aspx">
                محل تبلیغ شما
                </asp:HyperLink>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</div>
