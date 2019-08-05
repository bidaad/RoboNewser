<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_SendMessage" CodeBehind="SendMessage.ascx.cs" %>
<div id="divSendMessage" class="modal fade" >
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                    &times;</button>
                <h4 class="modal-title">ارسال پیام</h4>
            </div>
            <div class="modal-body">
                <asp:Panel ID="pnlSendMessage" runat="server">
    <div class="Win1Container">
        <div class="Win1Cont">
            <table class="tblSendMsg">
                <tr>
                    <td>
                        <asp:Label ID="lblSMToUser" Text="برای:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <div>
                            <asp:TextBox ID="txtSMToUser" ReadOnly="true" CssClass="form-control" Width="400" runat="server" Rows="5"></asp:TextBox>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" Text="عنوان:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <div>
                            <asp:TextBox ID="txtMessageSubject" CssClass="form-control" Width="400" runat="server" Rows="5"></asp:TextBox>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" Text="متن پیام:" runat="server"></asp:Label>
                    </td>
                    <td>
                        <div>
                            <asp:TextBox ID="txtMessageContent" CssClass="form-control" Width="400" Height="60" runat="server" Rows="5"
                                TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table>
                            <tr>
                                <td>
                                    <asp:Button ID="btnCancelSendMessage" CssClass="btn btn-info" aria-hidden="true" data-dismiss="modal" OnClick="btnCancelSendMessage_Click" runat="server"
                                        Text="انصراف" />
                                </td>
                                <td>
                                    <asp:Button ID="btnSendMessage" CssClass="btn btn-info" OnClick="btnSendMessage_Click"  OnClientClick="$('#divSendMessage').modal('hide');" runat="server" Text=" ارسال " />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Panel>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        try {
            $("#divAddFriendReq").modal('hide');
            $("#divSendMessage").modal('show');
        }
        catch (err) {
        }
    });


</script>


