<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayDomainStep2.aspx.cs" MasterPageFile="~/RootCol1.master" Inherits="Parsetv91._1.Domain.PayDomainStep2" %>

<%@ Register Src="~/UserControls/UserMenu.ascx" TagName="UserMenu" TagPrefix="UCUserMenu" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CP1">
    <div class="WinRadiusGray">
        <div class="CatHeaderCont">
            <h3 class="CatHeader">
                <asp:Label ID="lblCatTitle" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;پرداخت مبلغ اس ام اس"
                    runat="server"></asp:Label>
            </h3>
        </div>
        <div class="clear">
        </div>
        <div>
            <div>
                <div class="Marginer1">
                    <div class="Box1" style="margin-top: 10px;">
                        <div class="PayPanel">
                            <div>
                                <AKP:MsgBox runat="server" ID="msg">
                                </AKP:MsgBox>
                            </div>
                            
                            <div class="clear"></div>
                            <div class="Farsi">
                                <table style="direction: ltr; width: 100%;" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td>
                                            <img src="../images/Templates/WinShadow_01.gif" width="29" height="23" alt="">
                                        </td>
                                        <td style="background-image: url(../images/Templates/WinShadowTop.jpg); height: 23px;">
                                        </td>
                                        <td>
                                            <img src="../images/Templates/WinShadow_03.gif" width="28" height="23" alt="">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="background-image: url(../images/Templates/WinShadowLeft.jpg); width: 29px;">
                                        </td>
                                        <td style="text-align: right; direction: rtl; line-height: 150%;">
                                            <div style="direction: rtl; margin-top: 10px; padding: 10px;">
                                                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                                            </div>
                                            &nbsp;
                                        </td>
                                        <td style="background-image: url(../images/Templates/WinShadowRight.jpg); width: 28px;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <img src="../images/Templates/WinShadow_07.gif" width="29" height="27" alt="">
                                        </td>
                                        <td style="background-image: url(../images/Templates/WinShadowBottom.jpg); height: 27px;">
                                        </td>
                                        <td>
                                            <img src="../images/Templates/WinShadow_09.gif" width="28" height="27" alt="">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div>
                                
                            </div>
                            <div class="clear"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>