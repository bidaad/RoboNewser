<%@ Page Language="C#" ValidateRequest="false" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="True" Inherits="ResourceSites_EditResourceSites" Title="ResourceSites"
    CodeBehind="EditResourceSites.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div style="text-align: center">
        <div>
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div>

                            <div class="cSysName">
                                <asp:HyperLink runat="server" ID="hplSysName"></asp:HyperLink>
                            </div>
                        </div>
                    </th>
                </tr>
                <tr>
                    <td class="cTDEdit">
                        <table cellpadding="2" cellspacing="0" width="100%" align="center">
                            <tr>
                                <td class="cEditRight">
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
                                                                <AKP:ExTextBox jas="1" ID="txtName" MaxLength="500" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblName" runat="server" Text="نام:"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td class="cFieldRight"></td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div>
                                        <table class="cTblOneRow">
                                            <tr>
                                                <td class="cFieldLeft"></td>
                                                <td class="cFieldRight">
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExCheckBox ID="chkMakeCopy" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblMakeCopy" runat="server" Text=" ایجاد کپی: "></asp:Label>
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
                                                                <AKP:Combo jas="1" ID="cboHCEntityTypeCode" BaseID="HCEntities" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label3" runat="server" Text="موجودیت:"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td class="cFieldRight">
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:Combo jas="1" ID="cboZoneCode" BaseID="Zones" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label4" runat="server" Text="منطقه: "></asp:Label>
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
                                                                <AKP:ExCheckBox ID="chkBaseSite" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblBaseSite" runat="server" Text="سایت پایه: "></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td class="cFieldRight">
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExCheckBox ID="chkActive" jas="1" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label5" runat="server" Text="فعال: "></asp:Label>
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
                                                                <AKP:Combo jas="1" ID="cboHCEncodingTypeCode" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label1" runat="server" Text="انکودینگ: "></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td class="cFieldRight">
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:Combo jas="1" AllowNull="false" ID="cboLanguageCode" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label2" runat="server" Text="زبان: "></asp:Label>
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
                                                                <AKP:ExTextBox jas="1" ID="txtBaseURL" SkinID="English" runat="server" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label6" runat="server" Text="آدرس پایه: "></asp:Label>
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
                                    <div>
                                        <table class="cTblOneRow">
                                            <tr>
                                                <td>
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExTextBox jas="1" ID="txtRELink" CssClass="cEngMultiLine" Font-Size="Large"
                                                                    Height="152px" Width="492px" TextMode="MultiLine" MaxLength="500" runat="server"
                                                                    SkinID="English" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblRELink" runat="server" Text="کلید یافتن لینک:"></asp:Label>
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
                                                <td>
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExTextBox jas="1" ID="txtREDetail" Font-Size="Large" TextMode="MultiLine" MaxLength="500"
                                                                    runat="server" SkinID="English" Height="152px" Width="492px" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblREDetail" runat="server" Text="کلید یافتن متن کامل: "></asp:Label>
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
                                                <td>
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExTextBox jas="1" ID="txtREImage" Font-Size="Large" TextMode="MultiLine" MaxLength="500"
                                                                    runat="server" SkinID="English" Height="152px" Width="492px" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="lblREImage" runat="server" Text="کلید یافتن عکس: "></asp:Label>
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
                                                <td>
                                                    <table class="cTblField">
                                                        <tr>
                                                            <td class="cCtrl">
                                                                <AKP:ExTextBox jas="1" ID="txtREVideo" Font-Size="Large" TextMode="MultiLine" MaxLength="500"
                                                                    runat="server" SkinID="English" Height="152px" Width="492px" />
                                                            </td>
                                                            <td class="cLabel">
                                                                <asp:Label ID="Label7" runat="server" Text="کلید یافتن ویدیو: "></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div class="clearfloat"></div>
                                    <div class="cHorSep">
                                    </div>
                                    <table class="cEditTabs" width="100%">
                                        <tr>
                                            <td>
                                                <div>
                                                    <div>
                                                        <div class="cDivSep">
                                                        </div>
                                                        <div class="cBrowseArea" id="ResourseSiteCats">
                                                        </div>
                                                        <div class="cDivSep">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="cBrowseArea" id="NewsIGroups">
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
