<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_RandUsers"
    CodeBehind="RandUsers.ascx.cs" %>
<div class="TopMargin5 hidden-xs">
    <table style="width: 100%; direction: ltr !important;" >
        <tr>
            <td class="WinThem1Corner1">&nbsp;
            </td>
            <td class="WinThem1Mid">برخی کاربران
            </td>
            <td class="WinThem1Corner2">&nbsp;
            </td>
        </tr>
        <tr>
            <td class="WinThem1Left">&nbsp;
            </td>
            <td class="WinThem1Data" style="direction: rtl; padding: 6px;">
                <div class="Padder2">
                    <asp:DataList ID="dtlUsers" CssClass="tblRandUsers" RepeatColumns="1" runat="server">
                        <ItemTemplate>
                            <div class="text-center">
                                <div>
                                    <asp:HyperLink ID="hplUserImage" BorderColor="Black" BorderWidth="1"
                                        NavigateUrl='<%#"https://www.robonewser.com/Users/Profile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'
                                        runat="server">
                                <%#ShowPic(DataBinder.Eval(Container.DataItem, "PicFile"), DataBinder.Eval(Container.DataItem, "HCGenderCode"))%>
                                    </asp:HyperLink>
                                </div>
                                <div>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"https://www.robonewser.com/Users/Profile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'
                                        runat="server"><%#DataBinder.Eval(Container.DataItem, "FirstName")%>
                                    </asp:HyperLink>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </td>
            <td class="WinThem1Right">&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="WinThem1Corner3">&nbsp;
            </td>
            <td class="WinThem1Bot">&nbsp;
            </td>
            <td class="WinThem1Corner4">&nbsp;
            </td>
        </tr>
    </table>
</div>
