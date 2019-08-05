<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Main.master" AutoEventWireup="true" Inherits="Contents_EditContents" Title="Contents" Codebehind="EditContents.aspx.cs" %>


<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    <div class="cTblEdit">
        <div style="width: 700px; float: right; text-align: right; color: White;">
            <asp:Label runat="server" ID="lblSysName"></asp:Label></div>
        <div class="cTDEdit">
            <div class="cEditRight">
                <div class="cEditMain">
                    <div class="cEditMainData">
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
                                                                            <AKP:Lookup ID="lkpContentCatCode" jas="1"  runat="server"/>
                                                                        </td>
                                                                        <td class="cLabel">
                                                                            <asp:Label ID="lblContentCatCode" runat="server" Text="گروه:"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                 </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                    <tr>
                                                                        <td class="cCtrl">
                                                                            <AKP:ExTextBox ID="txtTitle" jas="1"  CssClass="cMultiLine" TextMode="MultiLine" MaxLength="500"  runat="server"/>
                                                                        </td>
                                                                        <td class="cLabel">
                                                                            <asp:Label ID="lblTitle" runat="server" Text="عنوان:"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                 </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div><div>
                                                                        <table class="cTblOneRow">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                    <tr>
                                                                        <td class="cCtrl">
                                                                            <AKP:ExTextBox ID="txtContentText" jas="1"  CssClass="cMultiLine" TextMode="MultiLine"  runat="server"/>
                                                                        </td>
                                                                        <td class="cLabel">
                                                                            <asp:Label ID="lblContentText" runat="server" Text="متن:"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                 </table>
                                                                                </td>
                                                                                <td class="cFieldRight">
                                                                                    <table class="cTblField">
                                                                    <tr>
                                                                        <td class="cCtrl">
                                                                            <AKP:ExTextBox ID="txtUrl" jas="1" MaxLength="20"  runat="server"/>
                                                                        </td>
                                                                        <td class="cLabel">
                                                                            <asp:Label ID="lblUrl" runat="server" Text="آدرس:"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                 </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </div><div>
                                                                        <table class="cTblOneRow">
                                                                            <tr>
                                                                                <td class="cFieldLeft">
                                                                                    <table class="cTblField">
                                                                    <tr>
                                                                        <td class="cCtrl">
                                                                            <AKP:ExTextBox ID="txtPicName" jas="1" MaxLength="50"  runat="server"/>
                                                                        </td>
                                                                        <td class="cLabel">
                                                                            <asp:Label ID="lblPicName" runat="server" Text="عکس:"></asp:Label>
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
            </div>
        </div>
        <div class="cHorSep">
        </div>
        <div class="TabHeaderData">
            <telerik:RadTabStrip Style="margin-right: 8px;" dir="rtl" ID="tsUsers" runat="server"
                MultiPageID="RadMultiPage1" SelectedIndex="0" Skin="Vista" SkinsPath="~/RadControls/TabStrip/Skins">
                <Tabs>
                    
                    <telerik:RadTab ID="Tab1" runat="server" Text="گروه های کاربر">
                    </telerik:RadTab>
                    <telerik:RadTab ID="Tab2" runat="server" Text="فعالیتها های کاربر">
                    </telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
            <div class="cTabWrapper">
                <telerik:RadMultiPage ID="RadMultiPage1" SelectedIndex="0" runat="server">
                    <telerik:RadPageView ID="PageView1" runat="server">
                        
                        <div class="cBrowseArea" id="UserGroups">
                        </div>
                        <div class="cDivSep">
                        </div>
                    </telerik:RadPageView>
                    <telerik:RadPageView ID="RadPageView1" runat="server">
                       
                        <div class="cBrowseArea" id="UserLogs">
                        </div>
                        <div class="cDivSep">
                        </div>
                    </telerik:RadPageView>
                    
                </telerik:RadMultiPage>
            </div>
        </div>
        <div style="text-align: right">
            <table class="tblEditButtons" cellpadding="2" cellspacing="4">
                <tr>
                    <td>
                        <a class="BlueButton" onclick="ChangeLang()">فارسی </a>
                    </td>
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
    </div>
    <asp:HiddenField ID="hfPassword" runat="server" />
</asp:Content>