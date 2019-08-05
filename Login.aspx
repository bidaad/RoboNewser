<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" Inherits="Login"
    Title="ورود به پارست" CodeBehind="Login.aspx.cs" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="UserControls/Login.ascx" TagName="Login" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="WinRadiusGray">
        <div class="InnerBarWrap">
        </div>
        <AKP:MsgBox ID="msgText" runat="server" />
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="Box3">
                    <div class="MainHeader">
                    </div>
                    <div>
                        <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="ورود به پارست"></asp:Label>
                    </div>
                    <div class="Marginer2">
                        <uc1:Login ID="Login1" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="Clear">
    </div>
</asp:Content>
