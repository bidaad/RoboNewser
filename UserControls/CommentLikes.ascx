<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="UserControls_CommentLikes" Codebehind="CommentLikes.ascx.cs" %>
<div class="Padder2">
    <div class="CommentBox">
    <div class="text-center">
        <asp:ImageButton ID="btnLike" ImageUrl="~/images/btnlike.png" OnClick="btnLike_Click" runat="server"></asp:ImageButton>
    </div>
    <asp:Panel ID="pnlLikes" CssClass="text-center" runat="server">
        <div class="Padder1">
            <div>
                <asp:Label ID="lblLikeCaption" runat="server"></asp:Label>
            </div>
            <div>
                <asp:Repeater runat="server" ID="rptComments" OnItemCommand="HandleRepeaterCommand">
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 60px;">
                                    <asp:HyperLink ID="HyperLink1" CssClass="cUserImageSmall" BorderWidth="1" BorderColor="Black"
                                        NavigateUrl='<%#"~/Users/Profile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'
                                        ImageUrl='<%#ShowPic(DataBinder.Eval(Container.DataItem, "SmallPicFile"))%>'
                                        runat="server" />
                                </td>
                                <td>
                                    <span class="Commenter">
                                        <%#DataBinder.Eval(Container.DataItem, "FirstName")%>&nbsp;<%#DataBinder.Eval(Container.DataItem, "LastName")%></span>&nbsp;<%#DataBinder.Eval(Container.DataItem, "Comment") %>
                                    <br />
                                    <span class="DateAgo">
                                        <%#Tools.GetPrettyDate((DateTime)DataBinder.Eval(Container.DataItem, "CommentDate"))%></span>
                                    &nbsp;<div class="cDelComment">
                                        <asp:LinkButton ID="btnDeleteComment" CssClass="btn btn-danger" Visible='<%#ShowDelVisibility(DataBinder.Eval(Container.DataItem, "UserCode")) %>'
                                            CommentID='<%#DataBinder.Eval(Container.DataItem, "ID") %>' CommandName="DeleteComment"
                                            runat="server">حذف</asp:LinkButton></div>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div>
                <asp:TextBox ID="txtComment" TextMode="MultiLine" CssClass="form-control" 
                    runat="server"></asp:TextBox>
            </div>
            <div>
                <div class="ButtonsCont1">
                    <div style="float: right; padding-right: 5px;">
                        <asp:LinkButton ID="btnSendComment" OnClick="btnSendComment_Click" CssClass="btn btn-warning"
                             runat="server">ارسال نظر</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
    
    <br />
    <br />
</div>
<div class="Clear">
</div>
</div>