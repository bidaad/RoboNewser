<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master" AutoEventWireup="True" Inherits="Keywords_EditKeywords" Title="Keywords" Codebehind="EditKeywords.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div style="text-align: center">
        <div >
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div >
                            
                            <div class="cSysName">
                                <asp:HyperLink runat="server" ID="hplSysName"></asp:HyperLink></div>
                        </div>
                    </th>
                </tr>
                <tr>
                    <td class="cTDEdit">
                        <table cellpadding="2" cellspacing="0" width="100%">
                            <tr>
                                <td class="cEditRight">
                                    <table class="cEditMain" width="100%">
                                        <tr>
                                            <td style="vertical-align: top;">
                                                <div class="cHeaderEditMain">
                                                    <table align="left" width="150" dir="ltr">
                                                        <tr>
                                                            <td>
                                                                <a id="imgBtnDelete" href='#' onclick="DeleteFromEditForm('<%=BaseID %>','<%=Code %>')">
                                                                    <img alt='(F3) حذف' class="cDelRec" src='../images/spacer.gif' /></a>
                                                            </td>
                                                            <td class="cSepVer">
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="imgBtnPrint" runat="server" ImageUrl="~/images/Print.gif" ToolTip="چاپ" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                                <div class="cEditMainData">
                                                    <table align="center" width="100%">
                                                        <tr>
                                                            <td>
                                                                <div>
                                                                    <div>
                                                                        <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                                                                    </div>
                                                                    <div>
                                                                        <table class="cTblOneRow">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox jas="1" ID="txtName" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblName" runat="server" Text="نام کليد واژه:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox jas="1" SkinID="English" ID="txtEngName" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblEngName" runat="server" Text="نام لاتين:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div>
                                                                    <div>
                                                                        <table class="cTblOneRow">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox jas="1" ID="txtDescription" CssClass="cMultiLine" TextMode="MultiLine"
                                                                                                    MaxLength="500" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblDescription" runat="server" Text="توضيحات:"></asp:Label>
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
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <div class="cHorSep">
                                    </div>
                                    <div style="text-align: left">
                                        <table class="tblEditButtons" cellpadding="2" cellspacing="4">
                                            <tr>
                                                <td>
                                                    <asp:ImageButton ID="imgBtnBack" Text=" بازگشت " SkinID="BackButton" OnClick="GoToList"
                                                        runat="server" />
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="imgBtnSave" Text=" ذخیره " SkinID="SaveButton" OnClick="DoSave"
                                                        runat="server" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
