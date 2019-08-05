<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" CodeBehind="Keywords.aspx.cs" Inherits="RoboNewser.KeywordsFolder" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div>
        <h2>
            <asp:Literal ID="ltrHeader" runat="server"></asp:Literal>
        </h2>
        <div class="RoundBorder1">
            <div class="KeywordList">
            <asp:Repeater ID="rptKeywords" runat="server">
                <ItemTemplate>
                    <div>
                        <asp:HyperLink NavigateUrl='<%#"~/K/" + Tools.ReplaceSpaceWithUnderline( Eval("Name")) + ".html" %>' runat="server"><%#Eval("Name") %></asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            </div>
        </div>
    </div>
   
    <div class="Clear">
    </div>
    <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />

</asp:Content>
