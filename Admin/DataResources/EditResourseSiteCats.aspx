<%@ Page Language="C#" AutoEventWireup="True" StylesheetTheme="Edit" MasterPageFile="~/Admin/EditPopup.master" CodeBehind="EditResourseSiteCats.aspx.cs" Inherits="RoboNewser.Admin.DataResources.EditResourseSiteCats" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    
    <table cellpadding="0" cellspacing="0" align="center" width="100%">
        <tr>
            <td>
                <div>
                    <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                </div>
                <div>
                    <table class="EditRow">
                        <tr>
                            <td class="cCtrl">
                                <asp:Label ID="lblUrl" runat="server" Text="Url:"></asp:Label>
                            </td>
                            <td class="cLabel">
                                <AKP:ExTextBox ID="txtUrl" SkinID="English" jas="1" Width="300" MaxLength="500" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="EditRow">
                        <tr>
                            <td class="cCtrl">
                                <AKP:Combo ID="cboCatCode" jas="1" runat="server" />
                            </td>
                            <td class="cLabel">
                                <asp:Label ID="lblCatCode" runat="server" Text="طبقه بندي:"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="EditRow">
                        <tr>
                            <td class="cCtrl">
                                <asp:Label ID="Label2" runat="server" Text="RSS:"></asp:Label>
                            </td>
                            <td class="cLabel">
                                <AKP:ExTextBox ID="txtRssUrl" SkinID="English" jas="1" Width="300" MaxLength="500"
                                    runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <table class="cTblOneRowPopup">
                        <tr>
                            <td class="cFieldLeft">
                                <table class="EditRow">
                                    <tr>
                                        <td class="cCtrl">
                                            
                                        </td>
                                        <td class="cLabel">
                                            <AKP:ExCheckBox ID="chkActive" jas="1" runat="server" />
                                            <asp:Label ID="lblActive" runat="server" Text="فعال:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td class="cFieldRight">
                                <table class="EditRow">
                                    <tr>
                                        <td class="cCtrl">
                                            
                                        </td>
                                        <td class="cLabel">
                                            <AKP:ExCheckBox ID="chkRssIsActive" jas="1" runat="server" />
                                            <asp:Label ID="Label1" runat="server" Text="RSS فعال است:"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <asp:HyperLink ImageUrl="~/Admin/images/pass.jpg" runat="server" ID="hplTest" Target="_blank">Test Site</asp:HyperLink>
                </div>
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
                            <asp:ImageButton ID="imgBtnSave" SkinID="SaveButton" Text="ذخیره" runat="server" OnClick="DoSave" />
                        </td>
                       
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
