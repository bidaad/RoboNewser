<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master" AutoEventWireup="true" Inherits="Languages_EditLanguages" Title="Languages" Codebehind="EditLanguages.aspx.cs" %>









<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div style="text-align: center">
        <div >
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div >
                            <div style="width: 180px; float: left;">
                                <table align="left" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td>
                                            <asp:HyperLink ID="hplHelp" runat="server" ImageUrl="~/images/Help.gif" NavigateUrl="~/Help/Languages/" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
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
                                                                                                <AKP:ExTextBox ID="txtName" jas="1" CssClass="cMultiLine" TextMode="MultiLine" MaxLength="500"
                                                                                                    runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblName" runat="server" Text="نام زبان:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox ID="txtSymbol" jas="1" MaxLength="50" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblSymbol" runat="server" Text="سنبل:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div>
                                                                    <div>
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
                                    <div class="cHorSep">
                                    </div>
                                    <div style="text-align: left">
                                        <table cellpadding="2" cellspacing="4">
                                            <tr>
                                                <td>
                                                    <a id="imgBtnDeleteDown" href='#' onclick="DeleteFromEditForm('<%=BaseID %>','<%=Code %>')">
                                                        <img alt='(F3) حذف' class="cDelRec" src='../images/spacer.gif' /></a>
                                                </td>
                                                <td class="cVerBar1">
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="imgBtnBack" SkinID="BackButton" OnClick="GoToList" runat="server" />
                                                </td>
                                                <td class="cVerBar1">
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="imgBtnSave" SkinID="SaveButton" OnClick="DoSave" runat="server" />
                                                </td>
                                                <td class="cVerBar1">
                                                </td>
                                                <td>
                                                    <a id="imgBtnLang" href='#' onclick='ChangeLang()'>
                                                        <img alt="(F5) تغییر زبان" name="langimg" border="0" src="../images/Farsibtn.gif"
                                                            class="cBtnImage2" width="16" height="16" /></a>
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
