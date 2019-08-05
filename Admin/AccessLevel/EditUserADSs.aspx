<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master"
    AutoEventWireup="true" Inherits="UserADSs_EditUserADSs"
    Title="UserADSs" Codebehind="EditUserADSs.aspx.cs" %>

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
            window.location.href = 'EditUserADSs.aspx?SelectedTab=' + SelTab + '&Code=<%=Code%>'
        }
    </script>

    <div style="text-align: center">
        <div >
            <table class="cTblEdit" bordercolor="#697077" border="1" align="center" cellpadding="0"
                cellspacing="0">
                <tr>
                    <th>
                        <div >
                            <div style="width: 180px; float: left;">
                                
                            </div>
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
                                                <div class="cHeaderEditMain">
                                                    
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
                                                                                                <AKP:ExTextBox ID="txtTitle" jas="1" Width="250" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">http://
                                                                                                <AKP:ExTextBox ID="txtLink" SkinID="English" jas="1" 
                                                                                                    runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblLink" runat="server" Text="لینک:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
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
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExTextBox ID="txtDescription" jas="1" CssClass="cMultiLine" TextMode="MultiLine"
                                                                                                    MaxLength="500" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblDescription" runat="server" Text="توضیحات:"></asp:Label>
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
                                                                                                <AKP:Lookup ID="lkpUserCode" jas="1" BaseID="Users" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblUserCode" runat="server" Text="کاربر:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:ExCheckBox ID="chkActive" jas="1"  runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="Label2" runat="server" Text="فعال :"></asp:Label>
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
                                                                                                <AKP:FarsiDate ID="dteStartDate" jas="1" runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblStartDate" runat="server" Text="تاریخ شروع:"></asp:Label>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                                        <tr>
                                                                                            <td class="cCtrl">
                                                                                                <AKP:FarsiDate ID="dteEndDate" jas="1"  runat="server" />
                                                                                            </td>
                                                                                            <td class="cLabel">
                                                                                                <asp:Label ID="lblEndDate" runat="server" Text="تاریخ انقضا:"></asp:Label>
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
