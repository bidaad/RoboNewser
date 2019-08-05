<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Root1.master" CodeBehind="KeywordsByRole.aspx.cs" Inherits="RoboNewser.KeywordsByRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="panel">
        <h2>
            <asp:Literal ID="lblTitle" runat="server"></asp:Literal>
        </h2>
        <div class="Clear">
        </div>
        <div class="">
            <ul class="KRoles">
            <asp:Repeater ID="rptKeywords" runat="server">
                <ItemTemplate>
                    <li class="">
                        <h3>
                            <%#Eval("Name") %>
                        </h3>
                        <div class="KRImgCont"><asp:Image runat="server" ImageUrl='<%#"//static.robonewser.com/Roles/" + Eval("ImgPath") %>' /></div>
                        <h4>
                            <a href="https://en.wikipedia.org/wiki/<%#Eval("Name").ToString().Replace(" ", "_") %>" target="_blank">
                            <%#Eval("Role") %></a>
                        </h4>
                        <div class="text-justify">
                            <%#Eval("Description") %>
                        </div>
                        <div>
                            <asp:HyperLink NavigateUrl='<%#"~/K/" + Tools.ReplaceSpaceWithUnderline( Eval("Name")) + ".html" %>' runat="server"><%#Eval("Name") %> news</asp:HyperLink>
                        </div>

                    </li>
                </ItemTemplate>
            </asp:Repeater>
                </ul>
        </div>
        <div class="clearfix"></div>        
        
        <div class="ByRoboNewser">
            All news has been gathered by <a href="https://www.robonewser.com/Crawler">RoboNewser Crawler ver 1.0</a><br />
        </div>
    </div>
</asp:Content>
