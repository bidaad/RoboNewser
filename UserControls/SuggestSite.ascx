<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SuggestSite.ascx.cs"
    Inherits="RoboNewser.UserControls.SuggestSite" %>
<div class="WinRadiusGray Padder10">
    <div>
        <asp:Panel ID="pnlSedInvitation" runat="server">
            <div  class="text-center">
                <asp:Label ID="Label10" runat="server" Text="این سایت را به دوستان خود معرفی کنید"></asp:Label>
            </div>


            <div>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ValidationGroup="Invitation" ErrorMessage="ایمیل معتبر نیست"></asp:RegularExpressionValidator>
            </div>
            <div class="Padder5">
                    <asp:TextBox ID="txtFromName" TabIndex="1" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="Padder5">
                <asp:TextBox ID="txtEmail" TabIndex="2" CssClass="form-control" FirstTime="1" Text="ایمیل دوست شما" onclick="if(this.FirstTime=='1' || this.FirstTime==undefined) {this.value='';this.FirstTime='0';}"
                    SkinID="English" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnSendToFriend" Text="ارسال" CssClass="btn btn-info" ValidationGroup="Invitation" runat="server"
                    OnClick="btnSendToFriend_Click"></asp:Button>
            </div>


        </asp:Panel>
        <asp:Label ID="lblInvSent" Visible="false" runat="server" Text="دعوتنامه شما با موفقیت ارسال شد"></asp:Label>
    </div>
</div>
