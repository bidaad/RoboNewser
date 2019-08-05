<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMostVisitedNews.ascx.cs" Inherits="RoboNewser.UserControls.UCMostVisitedNews" %>
    <div class="CatHeaderCont">
        <h3 class="CatHeader">
            <asp:Label ID="lblCatTitle" Text="Most Viewed"
                runat="server"></asp:Label>
        </h3>
    </div>
    <div class="clear"></div>

<div class="Padder10 MostVisited">
    <asp:Repeater ID="rptMVNews12h" EnableViewState="false" runat="server">
        <ItemTemplate>
            <div>
                <asp:HyperLink runat="server" CssClass="cTitle" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>' NavigateUrl='<%#"~/News/" + Eval("Code") + ".html" %>'><%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"), 35)%></asp:HyperLink>&nbsp;</div>
        </ItemTemplate>
    </asp:Repeater>
</div>

