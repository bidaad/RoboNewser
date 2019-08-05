<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_AddFreind" CodeBehind="AddFreind.ascx.cs" %>

<div id="divAddFriendReq" class="modal fade" >
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                    &times;</button>
                <h4 class="modal-title">
                    <asp:Literal ID="ltrHeader" runat="server"></asp:Literal>

                </h4>
            </div>
            <div class="modal-body">
                <asp:Panel ID="pnlAddFriendTool" CssClass="AddFriendTool" runat="server">

                    <div class="Win1Cont">
                        <div>
                            <div class="Win1Header">
                                <asp:Label ID="lblAddFriend" runat="server"></asp:Label>
                            </div>
                            <div class="Win1Header">
                                <asp:Label ID="lblTitle" runat="server"></asp:Label>
                            </div>
                            <div>
                                <asp:Image ID="imgPhoto" CssClass="cUserImage" Width="170" ImageUrl="~/Files/Users/man_icon.gif"
                                    runat="server" />
                            </div>
                            <div>
                                <div class="RTL">
                                    <asp:Label ID="Label2" runat="server" Text="پیام(اختیاری)"></asp:Label>
                                </div>
                                <div>
                                    <asp:TextBox ID="txtAddFriendMessage" runat="server" Rows="5" Height="60" Width="180"
                                        TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-inline">


                                <div class="Padder5">
                                    <asp:Button ID="btnCancel" aria-hidden="true" data-dismiss="modal" CssClass="btn btn-primary" runat="server" Text=" انصراف " />
                                
                                    <asp:Button ID="btnAddFriend" OnClick="btnAddFriend_Click" CssClass="btn btn-primary" OnClientClick="$('#divAddFriendReq').modal('hide');"
                                        runat="server" Text=" ارسال تقاضا " />
                                </div>

                            </div>

                        </div>
                    </div>

                </asp:Panel>
            </div>
        </div>
    </div>
</div>

