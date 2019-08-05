<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/EditPopup.master"
    AutoEventWireup="true" Inherits="UserLogs_EditUserLogs"
    Title="UserLogs" Codebehind="EditUserLogs.aspx.cs" %>








<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <table cellpadding="0" cellspacing="0" align="center" width="100%">
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" width="90%" class="cMainEditTable">
                    <tr>
                        <td>
                            <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                        </td>
                    </tr>
                    <div>
                        <table class="cTblOneRowPopup">
                            <tr>
                                <td class="cFieldLeft">
                                    <table class="cTblField">
                                        <tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                            <AKP:Lookup jas="1" ID="lkpCode" BaseID="" runat="server" />
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblCode" runat="server" Text="کد:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="cFieldRight">
                                    <table class="cTblField">
                                        <tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                            <AKP:Lookup jas="1" ID="lkpEntityCode" BaseID="" runat="server" />
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblEntityCode" runat="server" Text="کد موجوديت:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
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
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                            <AKP:Combo jas="1" ID="cboHCEntityTypeCode" BaseID="HCEntities" runat="server" />
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblHCEntityTypeCode" runat="server" Text="موجوديت:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="cFieldRight">
                                    <table class="cTblField">
                                        <tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                            <AKP:Combo jas="1" ID="cboHCUserActionCode" BaseID="HCUserActions" runat="server" />
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblHCUserActionCode" runat="server" Text="نوع عمليات:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
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
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                            <AKP:FarsiDate jas="1" ID="dteActionDate" runat="server" />
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblActionDate" runat="server" Text="Not Defined:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="cFieldRight">
                                </td>
                            </tr>
                        </table>
                    </div>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" class="cPopupToolbar">
                <table cellpadding="5" align="right" border="0" cellspacing="2">
                    <tr>
                        <td>
                            <asp:ImageButton ID="imgBtnBack" SkinID="BackButton" runat="server" OnClientClick="window.close()" />
                        </td>
                        <td class="cVerBar1">
                        </td>
                        <td>
                            
                                <a id="imgBtnLang" href='#' onclick='ChangeLang()'><img alt="(F5) تغییر زبان" name="langimg" border="0" src="../images/Farsibtn.gif" class="cBtnImage2" width="16" height="16" /></a>
                        </td>
                        <td class="cVerBar1">
                        </td>
                        <td>
                            <asp:ImageButton ID="imgBtnSave" SkinID="SaveButton" runat="server" OnClick="DoSave" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
