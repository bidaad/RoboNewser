<%@ Page Language="C#" StylesheetTheme="Edit" ValidateRequest="false" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="Banners_EditBanners"
    Title="Banners" CodeBehind="EditBanners.aspx.cs" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">

    <script language="javascript" type="text/javascript">
        var SelTab = <%=SelectedTabIndex%>;
        function ClientTabSelectedHandler(sender, eventArgs)
        {
            var tabStrip = sender;
            SelTab = tabStrip.SelectedIndex
        }
        function GoToPage()
        {
            window.location.href = 'EditBanners.aspx?SelectedTab=' + SelTab + '&Code=<%=Code%>'
        }
    </script>

    <div style="text-align: center">
        <div >
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div>
                            <div style="width: 700px; float: right; text-align: right; color: White;">
                                <asp:Label runat="server" ID="lblSysName"></asp:Label>
                            </div>
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
                                                                                                <AKP:ExRadUpload jas="1" ID="uplBanFile" TargetFolder="~/Files/Banners/" runat="server"
                                                                                                    Skin="Vista" MaxFileSize="20971520" ControlObjectsVisibility="None" />
                                                                                                <br />
                                                                                                <asp:HyperLink ID="hplBanFile" runat="server"></asp:HyperLink>
                                                                                                <AKP:ExCheckBox ID="chkDeleteBanFile" runat="server" Text="حذف فایل" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblBanFile" runat="server" Text="فایل:"></asp:Label>
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
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">http://<AKP:ExTextBox ID="txtTargetUrl" SkinID="English" jas="1" MaxLength="200" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblTargetUrl" runat="server" Text="آدرس :"></asp:Label>
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
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox ID="txtKeywords" jas="1" CssClass="cMultiLine" TextMode="MultiLine"
                                                                                                    MaxLength="1000" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblKeywords" runat="server" Text="کلمات کلیدی:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox ID="txtText" jas="1" CssClass="cMultiLine" TextMode="MultiLine" MaxLength="1000"
                                                                                                    runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblText" runat="server" Text="متن:"></asp:Label>
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
                                                                                                <AKP:Combo ID="cboPositionCode" jas="1" BaseID="BannerPositions" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblPositionCode" runat="server" Text="مکان نمایش:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:Combo ID="cboHCTypeCode" jas="1" BaseID="HCBannerTypes" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblHCTypeCode" runat="server" Text="نوع:"></asp:Label>
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
                                                                                                <AKP:NumericTextBox ID="txtViewNum" jas="1" NumericType="IntType" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblViewNum" runat="server" Text="تعداد نمایش:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:NumericTextBox ID="txtClickNum" jas="1" NumericType="IntType" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblClickNum" runat="server" Text="تعداد کلیک:"></asp:Label>
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
