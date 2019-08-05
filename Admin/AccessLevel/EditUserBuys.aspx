<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/EditPopup.master"
    AutoEventWireup="true" Inherits="UserBuys_EditUserBuys"
    Title="UserBuys" Codebehind="EditUserBuys.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div>
        <asp:Panel runat="server" ID="pnlGuestUser">
            <fieldset style="direction: rtl; width: 90%">
                <legend>کاربر مهمان</legend>
                <div>
                    <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtFirstName" jas="1" Width="200" MaxLength="50" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblFirstName" runat="server" Text="نام:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtLastName" jas="1" Width="200" MaxLength="100" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblLastName" runat="server" Text="نام خانوادگي:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtEmail" SkinID="English" jas="1" Width="200" MaxLength="50" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblEmail" runat="server" Text="ايميل:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtPhone" SkinID="English" jas="1" Width="200" MaxLength="50" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="Label1" runat="server" Text="تلفن:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
            </fieldset>
        </asp:Panel>
        <div>
            <div>
                <AKP:MsgBox ID="msgBox1" runat="server" CssClass="cError" />
            </div>
            <div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:Combo ID="cboChargeTypeCode" AllowNull="false" BaseID="HCChargeTypes"  runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblChargeTypeCode" runat="server" Text="نوع شارژ:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:FarsiDate ID="dteChargeDate"  runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblChargeDate" runat="server" Text="تاريخ تراکنش:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:Combo ID="cboHCTransStatusCode" AllowNull="false" BaseID="HCUserTransStatuses"  runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblHCTransStatusCode" runat="server" Text="وضعيت:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtDigitalSignature"  MaxLength="20" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblDigitalSignature" runat="server" Text="امضاي ديجيتال:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtComment"  CssClass="cMultiLine" TextMode="MultiLine"
                                                MaxLength="1000" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblComment" runat="server" Text="توضیحات:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtBankName"  MaxLength="100" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblBankName" runat="server" Text="بانک:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtBankState"  MaxLength="100" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblBankState" runat="server" Text="شعبه بانک:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtFishNo"  MaxLength="50" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblFishNo" runat="server" Text="شماره فیش:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:FarsiDate ID="dtePayDate"  runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblPayDate" runat="server" Text="تاریخ پرداخت:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtUserIP" SkinID="English"  MaxLength="50" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblUserIP" runat="server" Text="IP کاربر:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:Combo ID="cboBankCode"  runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblBankCode" runat="server" Text="کد بانک:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="cTblField">
                                    <tr>
                                        <td class="cCtrl">
                                            <AKP:ExTextBox ID="txtAuthority"  MaxLength="100" runat="server" />
                                        </td>
                                        <td class="cLabel">
                                            <asp:Label ID="lblAuthority" runat="server" Text="Authority:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                
                <div>
                <table class="cTblOneRowPopup">
                    <tr>
                        <td class="cFieldLeft">
                            <table class="cTblField">
                                <tr>
                                    <td class="cCtrl">
                                        <asp:Label ID="lblTotalAmount" MaxLength="50" runat="server" />
                                    </td>
                                    <td class="cLabel">
                                        <asp:Label ID="Label3" runat="server" Text="کل مبلغ:"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="cFieldRight">
                        </td>
                    </tr>
                </table>
            </div>
            </div>
            
        </div>
        <div class="TabHeaderData">
            <telerik:RadTabStrip Style="margin-right: 8px;" dir="rtl" ID="tsUsers" runat="server"
                MultiPageID="RadMultiPage1" SelectedIndex="0" Skin="Vista" SkinsPath="~/RadControls/TabStrip/Skins">
                <Tabs>
                    <telerik:RadTab ID="Tab1" runat="server" Text="محصولات خریداری شده">
                    </telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
            <div class="cTabWrapper">
                <telerik:RadMultiPage ID="RadMultiPage1" SelectedIndex="0" runat="server">
                    <telerik:RadPageView ID="PageView1" runat="server">
                        <div class="cDivSep">
                        </div>
                        <div class="cBrowseArea" id="UserBuyProducts">
                        </div>
                        <div class="cDivSep">
                        </div>
                    </telerik:RadPageView>
                </telerik:RadMultiPage>
            </div>
        </div>
    </div>
    <div class="cPopupToolbar">
        <table cellpadding="2" cellspacing="4">
            <tr>
                <td>
                    <a class="button2" onclick="ChangeLang()">فارسی </a>
                </td>
                <td class="cVerBar1">
                </td>
                <td>
                    <asp:LinkButton ID="btnBackToList" Text=" بازگشت " 
                        SkinID="BackButton" runat="server" onclick="btnBackToList_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="imgBtnBack" Text=" بستن پنجره " OnClientClick="window.close()"
                        SkinID="BackButton" runat="server" />
                </td>
                <td class="cVerBar1">
                </td>
                <td>
                    <asp:LinkButton ID="imgBtnSave" Text=" ذخیره " SkinID="SaveButton" OnClick="DoSave"
                        runat="server" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
