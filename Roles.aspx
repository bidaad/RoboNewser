<%@ Page Title="" Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="RoboNewser.Roles" %>
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
                        <asp:HyperLink NavigateUrl='<%#"~/Roles/" + Tools.ReplaceSpaceWithUnderline( Eval("Name"))  %>' runat="server"><%#Eval("Name") %></asp:HyperLink>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            </div>
        </div>
    </div>
   
    <div class="Clear">
    </div>
    
</asp:Content>
