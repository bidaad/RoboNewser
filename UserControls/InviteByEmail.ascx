<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_InviteByEmail" Codebehind="InviteByEmail.ascx.cs" %>
<fieldset style="direction:rtl;">
    <legend>&nbsp;دعوت از دوستان</legend>
    <div>
        <AKP:MsgBox runat="server" id="msg" />
    </div>
    <div style="height:30px;padding-top:10px;">
        <asp:Label ID="Label1" runat="server" Text="ایمیلها را با کاما از یکدیگر جدا کنید."></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="txtFriendList" SkinID="English" TextMode="MultiLine" CssClass="ctxtInviteFriends"
            runat="server"></asp:TextBox>
    </div>
    <div class="RightButtons">
        <asp:LinkButton ID="btnInviteFriends" Text="ارسال دعوتنامه" CssClass="button3" runat="server"
            OnClick="btnInviteFriends_Click"></asp:LinkButton>
    </div>
</fieldset>
