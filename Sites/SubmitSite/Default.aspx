<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true"
    Inherits="Sites_SubmitSite_Default" Title="افزودن سایت جدید" Codebehind="Default.aspx.cs" %>



<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <script type="text/javascript">
        function pageScroll() {
    	        window.scrollBy(0,20); // horizontal and vertical scroll increments
    	        scrolldelay = setTimeout('pageScroll()',40); // scrolls every 100 milliseconds
        }
    </script>

    <div class="InnerBarWrap">
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnSearch" Text="جستجو" CssClass="btnSearch" runat="server" OnClick="btnSearch_Click" />
                </td>
                <td>
                    <asp:TextBox ID="txtKeyword" CssClass="txtKeyword" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="جستجو در سایتها: "></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div class="LeftCol">
        <AKP:MsgBox ID="msgText" runat="server" />
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="Box3">
                    <div class="TopNav">
                        <asp:HyperLink ID="hplNav" NavigateUrl="~/Sites" runat="server">بازگشت به گروه های اصلی</asp:HyperLink>
                    </div>
                    <div>
                        <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="اضافه کردن سایت جدید"></asp:Label>
                    </div>
                    <div class="Clear">
                    </div>
                    <div style="text-align: center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="Box4">
                                    <div class="Marginer2">
                                        <div class="Header1">
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblSelectedGroup" runat="server"></asp:Label>
                                                    </td>
                                                    <td class="Farsi">
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSelGroupLabel"
                                                            Visible="false" runat="server" Text="گروه انتخاب شده:"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton ID="btnTopCat" Width="32" Height="32" ToolTip="بازگشت به گروه بالاتر"
                                                            CssClass="GotoTopCat" runat="server" OnClick="btnTopCat_Click"></asp:LinkButton>&nbsp;
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1" runat="server" Text="انتحاب گروه"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div class="Clear">
                                        </div>
                                        <div>
                                            <asp:DataList ID="dlSiteCats" OnItemCommand="HandleDataList" RepeatColumns="4" RepeatDirection="Horizontal"
                                                CssClass="tblSiteCats" runat="server">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="btnCat" CatID='<%#DataBinder.Eval(Container.DataItem, "ID") %>'
                                                        CommandName="ShowSubCats" NavigateUrl='<%#"https://www.robonewser.com/Sites/?CatID=" + DataBinder.Eval(Container.DataItem, "ID")%>'
                                                        runat="server"><%#DataBinder.Eval(Container.DataItem, "Name")%></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:DataList>
                                        </div>
                                        <div class="Clear">
                                        </div>
                                    </div>
                                </div>
                                <div class="Clear">
                                </div>
                                <div class="Marginer1">
                                    <table style="float: right; margin-right: 60px;">
                                        <tr>
                                            <td colspan="3">
                                                <AKP:MsgBox runat="server" ID="msgBox">
                                                </AKP:MsgBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="NewSite"
                                                    ControlToValidate="txtTitle" Display="Static" runat="server" ErrorMessage="عنوان سایت را وارد کنید"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtTitle" Width="420" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label3" runat="server" Text=":عنوان سایت"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="NewSite"
                                                    ControlToValidate="txtUrl" Display="Static" runat="server" ErrorMessage="آدرس سایت را وارد کنید"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                http://
                                                <asp:TextBox ID="txtUrl" Width="377" SkinID="English" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label7" runat="server" Text=":آدرس سایت"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="NewSite"
                                                    ControlToValidate="txtDescription" Display="Static" runat="server" ErrorMessage="توضیحات سایت را وارد کنید"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDescription" Width="420" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" Text=":شرح سایت"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="NewSite"
                                                    ControlToValidate="txtSenderName" Display="Static" runat="server" ErrorMessage="نام فرستنده را وارد کنید"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtSenderName" Width="420" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" Text=":نام فرستنده"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="NewSite"
                                                    ControlToValidate="txtEmail" Display="Static" runat="server" ErrorMessage="ایمیل فرستنده را وارد کنید"></asp:RequiredFieldValidator>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtEmail" SkinID="English" Width="420" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text=":ایمیل فرستنده"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div style="text-align: right">
                                                    <telerik:RadCaptcha ID="RadCaptcha1" CssClass="Capt"  ValidationGroup="NewSite" Width="300" CaptchaImage-ImageCssClass="CaptImg"
                                                        CaptchaTextBoxCssClass="CaptText" runat="server" ErrorMessage="" CaptchaTextBoxLabel="">
                                                    </telerik:RadCaptcha>
                                                </div>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label8" runat="server" Text=":کد امنیتی"></asp:Label>
                                                <asp:Label ID="Label9" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <div class="Clear">
                                    </div>
                                    <div style="text-align: left">
                                        <asp:LinkButton ID="btnSend" CssClass="button" ValidationGroup="NewSite" runat="server"
                                            OnClick="btnSend_Click">ارسال</asp:LinkButton>
                                    </div>
                                </div>
                                <asp:Panel runat="server" ID="pnlMessage" Visible="false" CssClass="Message">
                                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                </asp:Panel>
                                <asp:HiddenField ID="hfCatID" runat="server" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="Clear">
                    </div>
                    <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
                    <div class="Box3Toolbar">
                        <Tlb:Toolbar ID="tlb1" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="RightCol">
        <Mnu:Menu ID="Menu1" runat="server" />
    </div>
    <div class="Clear">
    </div>
</asp:Content>
