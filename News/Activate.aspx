<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/RootCol1.Master" CodeBehind="Activate.aspx.cs" Inherits="RoboNewser.News.Activate" %>

<%@ Register Src="~/UserControls/Message.ascx" TagName="Message" TagPrefix="Msg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
<div class="WinRadiusGray">
    <AKP:MsgBox ID="msgText" runat="server" />
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="Box3">
                    <div class="MainHeader">
                    </div>
                    <div>
                        <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="تکمیل عضویت خبرنامه "></asp:Label>
                    </div>
                    <div class="Clear">
                    </div>
                    <div class="Marginer2">
                        <asp:Panel runat="server" ID="pnlMessage" CssClass="Message">
                            <div style="padding: 6px;">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
</div>
</asp:Content>