<%@ Control Language="C#" AutoEventWireup="true" Inherits="Users_UserList" CodeBehind="UserList.ascx.cs" %>
<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/Banner.ascx" TagName="Banner" TagPrefix="ADS" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/AddFreind.ascx" TagName="AddFriend" TagPrefix="FTL" %>
<%@ Register Src="~/UserControls/SendMessage.ascx" TagName="SendMessage" TagPrefix="FTL" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="Box2">
            <div class="BlueHeader">
                <asp:Label ID="lblPageTitle" runat="server"></asp:Label>
            </div>
            <div style="margin-bottom: 10px; padding: 7px;">
                <AKP:MsgBox runat="server" ID="msgBox" />
            </div>
            <div class="Clear">
            </div>
            <div>
                <asp:Repeater ID="rptItems" OnItemCommand="HandleRepeaterCommand"
                    runat="server" OnItemDataBound="rptItems_ItemDataBound">
                    <ItemTemplate>
                        <div class="row">
                            <div class="col-lg-2 col-md-3 col-sm-3 col-xs-3 text-center">
                                <div>
                                    <asp:HyperLink ID="hplUserImage" CssClass="cUserImage1" BorderColor="Black" BorderWidth="1" NavigateUrl='<%#"https://www.robonewser.com/Users/Profile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'
                                        ImageUrl='<%#ShowPic(DataBinder.Eval(Container.DataItem, "PicFile"))%>' runat="server" />
                                </div>
                                <div>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"https://www.robonewser.com/Users/Profile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'
                                        runat="server">
                                                            <%#DataBinder.Eval(Container.DataItem, "FirstName")%>&nbsp;<%#DataBinder.Eval(Container.DataItem, "LastName")%>
                                    </asp:HyperLink>
                                </div>
                            </div>
                            <div class="col-lg-10 col-md-9 col-sm-9 col-xs-9">
                                <div class="AddTools">
                                    <div>
                                        <asp:LinkButton ID="btnAddFriend" FriendCode='<%#DataBinder.Eval(Container.DataItem, "Code") %>'
                                            FirstName='<%#DataBinder.Eval(Container.DataItem, "FirstName")%>' LastName='<%#DataBinder.Eval(Container.DataItem, "LastName")%>'
                                            CommandName="AddFriend" runat="server">ارسال تقاضای دوستی</asp:LinkButton>
                                    </div>
                                    <div>
                                        <asp:LinkButton ID="btnSendMessage" CommandName="SendMessage" FirstName='<%#DataBinder.Eval(Container.DataItem, "FirstName")%>'
                                            LastName='<%#DataBinder.Eval(Container.DataItem, "LastName")%>' runat="server">ارسال پیام</asp:LinkButton>
                                    </div>
                                    <div>
                                        <asp:LinkButton ID="btnViewFriends" CommandName="ViewFriends" runat="server">مشاهده دوستان</asp:LinkButton>
                                    </div>
                                    <div>
                                        <asp:LinkButton ID="LinkButton1" CommandName="DeleteFriend" runat="server">حذف</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="gLine">
                        </div>
                        <div class="Clear">
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div>
                <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
            </div>
        </div>
        <FTL:AddFriend runat="server" Visible="false" ID="AddFriend"></FTL:AddFriend>
        <FTL:SendMessage runat="server" Visible="false" ID="SendMessage"></FTL:SendMessage>
        <asp:HiddenField ID="hfToUserCode" runat="server" />
    </ContentTemplate>
</asp:UpdatePanel>
