<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Stars" Codebehind="Stars.ascx.cs" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table>
            <tr>
                <td>
                    <div class="StarsCont" onmouseout="RestoreStars(this)">
                        <div class="Left">
                            <asp:Repeater runat="server" OnItemCommand="HandleRepeaterCommand" ID="rptStars">
                                <HeaderTemplate>
                                    <ul class="Stars">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li class="StarFull" onmouseover="ChangeStar(this)">
                                        <asp:ImageButton Val='<%#Eval("Num") %>' ID="btnStar" Width="22" Height="21" CommandName="FullStar"
                                            ImageUrl="~/images/spacer.gif" runat="server" />
                                    </li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="Right">
                            <asp:Repeater runat="server" OnItemCommand="HandleRepeaterCommand" ID="rptOffstars">
                                <HeaderTemplate>
                                    <ul class="Stars">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li class="StarHalf" onmouseover="ChangeStar(this)">
                                        <asp:ImageButton Val='<%#Eval("Num") %>' ID="btnStar" Width="22" Height="21" CommandName="HalfStar"
                                            ImageUrl="~/images/spacer.gif" runat="server" />
                                    </li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </td>
                <td>
                    <AKP:MsgBox ID="msgMessage" runat="server" />
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
