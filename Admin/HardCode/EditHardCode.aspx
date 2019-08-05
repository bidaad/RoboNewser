<%@ Page Language="C#" StylesheetTheme="Edit" MasterPageFile="~/Admin/Main.master" AutoEventWireup="true" Inherits="HardCode_EditHardCode" Title="ویرایش اطلاعات پایه" Codebehind="EditHardCode.aspx.cs" %>




<asp:Content runat="server" ID="content1" ContentPlaceHolderID="cphMain">
    
    <table align="center" border="1" cellpadding="0" cellspacing="0" class="cNormalTable"
        bordercolor="#8b8b8b" width="70%">
        <tr>
            <td bgcolor="#ededed">
                <table cellpadding="0" cellspacing="0" align="center" width="100%">
                    <tr>
                        <td>
                            <table cellpadding="0" cellspacing="0" width="100%" class="cMainEditTable">
                                <tr>
                                    <td>
                                        <AKP:MsgBox ID="msgBox" runat="server" CssClass="cError" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table class="EditRow">
                                            <tr>
                                                <td class="cCtrl" ><div>
                                                    <AKP:ExTextBox jas="1" ID="txtName" runat="server" /></div>
                                                </td>
                                                <td class="cLabel" ><asp:Label ID="Label1" runat="server" Text="نام: "></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="cSep">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table class="EditRow">
                                            <tr>
                                                <td id="Td5">
                                                    <div><AKP:ExTextBox jas="1" ID="txtDescription" runat="server" /></div>
                                                </td>
                                                <td class="cLabel">
                                                    
                                                        <asp:Label ID="Label7" runat="server" Text="توضیحات: "></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                                                <tr>
                                    <td class="cSep">
                                    </td>
                                </tr>
                                </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <table cellpadding="5" align="right" border="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <asp:ImageButton ID="imgBtnBack" SkinID="BackButton" runat="server" OnClick="GoToList" />
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="imgBtnSave" SkinID="SaveButton" runat="server" OnClick="DoSave" />
                                    </td>
                                    <td>
                                        
                                            <a id="imgBtnLang" href='#' onclick='ChangeLang()'><img alt="(F5) تغییر زبان" name="langimg" border="0" src="../images/Farsibtn.gif" class="cBtnImage2" width="16" height="16" /></a>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    
</asp:Content>

