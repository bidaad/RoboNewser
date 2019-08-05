<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="UserControls_UserComments" Codebehind="UserComments.ascx.cs" %>
<div class="Box3" style="width: 700px;">
    <div class="Marginer1">
        <div class="MainHeader">
            <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="نظرات کاربران"></asp:Label>
        </div>
        <div class="Clear">
        </div>
        <div style="text-align: right">
            <asp:Repeater ID="rptComments" EnableViewState="false" runat="server">
                <ItemTemplate>
                    <div class="Comment">
                        <div class="ComRight">
                            <%#DataBinder.Eval(Container.DataItem, "FirstName")%>&nbsp;<%#DataBinder.Eval(Container.DataItem, "LastName")%>
                        </div>
                        <div class="ComLeft">
                            <div>
                                <%#Tools.FormatText(DataBinder.Eval(Container.DataItem, "Comment"))%>
                            </div>
                            <div class="Timeago">
                                <%#TimeAgo(DataBinder.Eval(Container.DataItem, "CommentDate"))%>
                            </div>
                        </div>
                        <div class="Clear">
                        </div>
                        <div class="HorzDotSpace">
                        </div>
                    </div>
                    <div class="Clear">
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="Clear">
        </div>
        <div class="Center">
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtComment" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                    </td>
                    <td style="direction: rtl; width: 20%; text-align: left;">
                        <asp:Label ID="Label1" runat="server" Text="نظر: "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div style="text-align: left">
            <asp:LinkButton ID="btnNewComment" CssClass="button2" Text="ثبت نظر" runat="server"
                OnClick="btnNewComment_Click"></asp:LinkButton>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </div>
</div>
