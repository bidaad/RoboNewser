<%@ Control Language="C#" AutoEventWireup="true" Inherits="GBN.Web.UI.UserControls.Resources" Codebehind="Resources.ascx.cs" %>
<div class="panel ">
    <div class="heading">
        <asp:Label ID="lblTitle" runat="server" Text="سایتهای خبری تحت پوشش"></asp:Label>
    </div>
    <div class="content Padder5">
        <asp:DataList ID="rptReasources" CssClass="tblRandResources" RepeatColumns="2" RepeatDirection="Horizontal"
            EnableViewState="false" runat="server">
            <ItemTemplate><div><asp:HyperLink runat="server" NavigateUrl='<%#"~/NR" + Eval("Code") + "_" + Tools.ReplaceSpaceWithUnderline(Eval("Name")) + ".html"%>'><%#DataBinder.Eval(Container.DataItem, "Name")%></asp:HyperLink></div></ItemTemplate>
            <FooterTemplate>
                
            </FooterTemplate>
        </asp:DataList>
    </div>
    
</div>
