<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="BannerPositions_EditBannerPositions"
    Title="BannerPositions" Codebehind="EditBannerPositions.aspx.cs" %>








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
            window.location.href = 'EditBannerPositions.aspx?SelectedTab=' + SelTab + '&Code=<%=Code%>'
        }
    </script>

    <div style="text-align: center">
        <div >
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div >
                            
                            <div style="width: 700px; float: right; text-align: right; color: White;">
                                <asp:Label runat="server" ID="lblSysName"></asp:Label></div>
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
                                                                                                <AKP:ExTextBox ID="txtName" jas="1"  MaxLength="500"
                                                                                                    runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblName" runat="server" Text="نام:"></asp:Label>
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
                                                                        <table class="cTblOneRow">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                     <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:NumericTextBox ID="txtWidth" jas="1" NumericType="IntType" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblWidth" runat="server" Text="طول:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                   <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:NumericTextBox ID="txtHeight" jas="1" NumericType="IntType" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblHeight" runat="server" Text="عرض:"></asp:Label>
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
                                        <table cellpadding="2" cellspacing="4">
                                            <tr>
                                                <td>
                                                    <asp:ImageButton ID="imgBtnBack" SkinID="BackButton" OnClick="GoToList" runat="server" />
                                                </td>
                                                <td class="cVerBar1">
                                                </td>
                                                <td>
                                                    <asp:LinkButton ID="imgBtnSave" Text="Save" SkinID="SaveButton" OnClick="DoSave"
                                                        runat="server" />
                                                </td>
                                                <td class="cVerBar1">
                                                </td>
                                                <td>
                                                    <button onclick="ChangeLang()" class="cBtnImage2" type="button">
                                                        <img alt="" name="langimg" border="0" src="../images/Farsibtn.gif" width="16" height="16" /></button>
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
