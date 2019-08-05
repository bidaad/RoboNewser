<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="Khabardaan.Web.UI.UserControls.KeywordList" CodeBehind="KeywordList.ascx.cs" %>
<h2>Keywords</h2>
<div class="RoundBorder1 ">
    <asp:Panel ID="pnlBriefKeywords" CssClass="cVisible" runat="server">
    </asp:Panel>
    <asp:Panel ID="pnlAllKeywords" CssClass="MIKeywords" runat="server">
        <asp:Repeater ID="rptAllKeywords" EnableViewState="false" runat="server">
            <ItemTemplate>
                <div>
                    <asp:HyperLink runat="server" NavigateUrl='<%#"~/K/" + Tools.ReplaceSpaceWithUnderline(Eval("Name")) + ".html"%>'><%#DataBinder.Eval(Container.DataItem, "Name")%></asp:HyperLink></div>
            </ItemTemplate>
        </asp:Repeater>
    </asp:Panel>
</div>

