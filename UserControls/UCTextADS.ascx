<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_UCTextADS" Codebehind="UCTextADS.ascx.cs" %>
<div class="RootTextADS">
    <asp:DataList ID="rptTextAds" RepeatColumns="4" CssClass="tblRootTextADS" EnableViewState="false"
        runat="server">
        <HeaderTemplate>
            <div class="cUserADTopHead">
                تبلیغات
            </div>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="UserTextAD">
                <a onmouseover="window.status='http://' + '<%#DataBinder.Eval(Container.DataItem, "Link")%>';"
                    onmousedown="window.status=''" href="http://<%#DataBinder.Eval(Container.DataItem, "Link")%>"
                    target="_blank" onclick="GoToPage('<%#DataBinder.Eval(Container.DataItem, "Code")%>')">
                    <div class="ADHead" style="color: #<%#GetColor()%>">
                        <%#DataBinder.Eval(Container.DataItem, "Title")%></div>
                </a>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            <div class="UserTextADSFooter">
                <asp:HyperLink ID="HyperLink13" runat="server" ToolTip="با پرداخت 10000 تومان در ماه 10000 بار در هر روز دیده شوید"
                    NavigateUrl="~/Advertise.aspx">
                محل تبلیغ شما
                </asp:HyperLink>
            </div>
        </FooterTemplate>
    </asp:DataList>
</div>
