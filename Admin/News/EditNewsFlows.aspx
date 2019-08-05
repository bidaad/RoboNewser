<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master" AutoEventWireup="True" Inherits="NewsFlows_EditNewsFlows" Title="NewsFlows" Codebehind="EditNewsFlows.aspx.cs" %>

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
                                                                <asp:ImageButton ID="imgBtnPrint" Visible="false"  runat="server" ImageUrl="~/images/Print.gif" ToolTip="چاپ" />
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
                                                                        <table class="cTblField">
                                                                            <tr>
                                                                                <td class="cCtrl">
                                                                                    <AKP:ExTextBox jas="1" ID="txtTitle" Width="500" MaxLength="500" runat="server" />
                                                                                </td>
                                                                                <td class="cLabel">
                                                                                    <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
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
                                                                                                <AKP:FarsiDate jas="1" ID="dteStartDate" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblStartDate" runat="server" Text="تاريخ شروع:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:FarsiDate jas="1" ID="dteEndDate" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblEndDate" runat="server" Text="تاريخ پايان:"></asp:Label>
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
                                                                                                <AKP:Combo jas="1" AllowNull="false" ID="cboHCShowTypeCode" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="Label1" runat="server" Text="نحوه نمایش:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:NumericTextBox jas="1" ID="txtShowOrder" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="Label2" runat="server" Text="ترتیب نمایش:"></asp:Label>
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
                                                                                                <AKP:ExCheckBox jas="1"  ID="chkActive" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="Label3" runat="server" Text="فعال :"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
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
                                    <table class="cEditTabs" width="100%">
                                        <tr>
                                            <td>
                                                <div>
                                                    <telerik:RadTabStrip Style="margin-right: 8px;" dir="rtl" ID="tsNews" runat="server"
                                                        MultiPageID="RadMultiPage1" SelectedIndex="0" Skin="Vista" SkinsPath="~/RadControls/TabStrip/Skins">
                                                        <Tabs>
                                                            <telerik:RadTab ID="Tab1" runat="server" Text="کلمات کلیدی">
                                                            </telerik:RadTab>
                                                        </Tabs>
                                                        <Tabs>
                                                            <telerik:RadTab ID="Tab2" runat="server" Text="اخبار جریان خبری">
                                                            </telerik:RadTab>
                                                        </Tabs>
                                                    </telerik:RadTabStrip>
                                                    <div class="cTabWrapper">
                                                        <telerik:RadMultiPage ID="RadMultiPage1" runat="server">
                                                            <telerik:RadPageView ID="PageView1" runat="server">
                                                                <div class="cDivSep">
                                                                </div>
                                                                <div class="cBrowseArea" id="NewsFlowsKeywords">
                                                                </div>
                                                                <div class="cDivSep">
                                                                </div>
                                                            </telerik:RadPageView>
                                                            <telerik:RadPageView ID="RadPageView2" runat="server">
                                                                <div class="cDivSep">
                                                                </div>
                                                                <div class="cBrowseArea" id="NewsNewsFlows">
                                                                </div>
                                                                <div class="cDivSep">
                                                                </div>
                                                            </telerik:RadPageView>
                                                        </telerik:RadMultiPage>
                                                    </div>
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
