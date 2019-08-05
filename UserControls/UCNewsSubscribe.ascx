<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsSubscribe.ascx.cs" Inherits="RoboNewser.UserControls.UCNewsSubscribe" %>
<div class="WinRadiusGray Padder10">
    <div>
        <asp:Panel ID="pnlSendInvitation" runat="server">
            <div class="text-center">
                <asp:Label ID="Label10" runat="server" Text="در خبرنامه پارست عضو شوید"></asp:Label>
            </div>

            
            <div class="Padder5">
                <asp:TextBox ID="txtEmail" TabIndex="2" CssClass="form-control" FirstTime="1" Text="ایمیل" onclick="this.value=''"
                    SkinID="English" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnSendToFriend" Text="ارسال" CssClass="btn btn-info" ValidationGroup="NewsEmails" runat="server"
                    OnClick="btnSendToFriend_Click"></asp:Button>
            </div>


        </asp:Panel>
        <asp:Label ID="lblInvSent" Visible="false" runat="server" Text="ایمیل با موفقیت ارسال شد"></asp:Label>
    </div>
</div>
