<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/EditPopup.master" AutoEventWireup="true" Inherits="UserComments_EditUserComments" Title="UserComments" Codebehind="EditUserComments.aspx.cs" %>

<asp:content runat="server" id="content1" contentplaceholderid="cphMain">
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
                                                                                    <table class="cTblField"><tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                                <AKP:Combo ID="cboHCSiteSectionCode" jas="1"  BaseID="HCSiteSections"  runat="server"/>
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblHCSiteSectionCode" runat="server" Text="قسمت سایت:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        
</table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField"><tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                                <AKP:Lookup ID="lkpItemCode" jas="1"  BaseID=""  runat="server"/>
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblItemCode" runat="server" Text="کد موجودیت:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        
</table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div><div>
                                                                        <table class="cTblOneRowPopup">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField"><tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                                <AKP:ExTextBox ID="txtComment" jas="1"  CssClass="cMultiLine" TextMode="MultiLine"  runat="server"/>
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblComment" runat="server" Text="نظر:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        
</table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField"><tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                                <AKP:FarsiDate ID="dteCommentDate" jas="1"  runat="server"/>
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblCommentDate" runat="server" Text="تاریخ:"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        
</table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div><div>
                                                                        <table class="cTblOneRowPopup">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField"><tr>
                                            <td>
                                                <table class="EditRow">
                                                    <tr>
                                                        <td class="cCtrl">
                                                                <asp:CheckBox ID="chkActive" jas="1"  runat="server"/>
                                                        </td>
                                                        <td class="cLabel">
                                                            <asp:Label ID="lblActive" runat="server" Text="فعال:"></asp:Label>
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
                            <button onclick="ChangeLang()" class="cBtnLang" type="button">
                                <img alt="" name="langimg" border="0" src="../images/Farsibtn.gif" width="16" height="16" /></button>
                        </td>
                        <td class="cVerBar1">
                        </td>
                        <td>
                            <asp:LinkButton ID="imgBtnSave" Text="Save" SkinID="SaveButton" runat="server" OnClick="DoSave" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:content>
