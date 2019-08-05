<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true"
    Inherits="Sites_SearchSites_Default" Title="فهرست سایتهای ایرانی" Codebehind="Default.aspx.cs" %>



<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>    <div class="InnerBarWrap">
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
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="Box3">
                    <div class="MainHeader">
                    </div>
                    <div>
                        <asp:Label ID="lblHeader" CssClass="Header1" runat="server" Text="فهرست سایتهای ایرانی"></asp:Label>
                    </div>
                    <div class="Clear">
                    </div>
                    <div style="text-align: center">
                        <div class="Box4">
                            <div class="Marginer2">
                                <div class="Header1">
                                    <asp:Label ID="Label1" runat="server" Text="گروه بندی"></asp:Label>
                                </div>
                                <div class="Clear">
                                </div>
                                <asp:DataList ID="dlSites" RepeatColumns="4" RepeatDirection="Horizontal" CssClass="tblSiteCats"
                                    runat="server">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"https://www.robonewser.com/Sites/?CatID=" + DataBinder.Eval(Container.DataItem, "ID")%>'
                                            runat="server"><%#DataBinder.Eval(Container.DataItem, "Name")%></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:DataList>
                                <div class="Clear">
                                </div>
                                <div style="padding-top: 50px; vertical-align: middle;">
                                    <asp:HyperLink ID="HyperLink1" CssClass="FunctionLink" NavigateUrl="~/Sites/SubmitSite"
                                        runat="server">اضافه کردن سایت جدید</asp:HyperLink>&nbsp;
                                    <asp:HyperLink ID="HyperLink2" CssClass="FunctionLink" NavigateUrl="~/Sites/ReportLink"
                                        runat="server">گزارش لینک خراب</asp:HyperLink>
                                </div>
                            </div>
                        </div>
                        <div class="Clear">
                        </div>
                        <div class="ListHeader">
                            <div id="divHeader">
                                <AKP:MsgBox ID="msgText" runat="server" />
                            </div>
                        </div>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Repeater ID="rptItems" OnItemCommand="HandleRepeater" runat="server" EnableViewState="false">
                                    <ItemTemplate>
                                        <div class="<%= GetClass()%>">
                                            <div class="SingleSite">
                                                <div class="Link">
                                                    <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" NavigateUrl='<%#"https://www.robonewser.com/Sites/Direct/?SiteID=" + DataBinder.Eval(Container.DataItem, "ID")%>'>
                                    <%#DataBinder.Eval(Container.DataItem, "Url")%>
                                                    </asp:HyperLink>
                                                </div>
                                                <div class="LinkTitle">
                                                    <asp:HyperLink ID="HyperLink3" Target="_blank" runat="server" NavigateUrl='<%#"https://www.robonewser.com/Sites/Direct/?SiteID=" + DataBinder.Eval(Container.DataItem, "ID")%>'>
                                    <%#DataBinder.Eval(Container.DataItem, "SiteName")%>&nbsp;<span class="VisitCount">(تعداد بازدید: <%#DataBinder.Eval(Container.DataItem, "VisitCount")%>)</span>
                                    
                                                    </asp:HyperLink>
                                                    <asp:LinkButton ID="btnEditLink" SiteID='<%#DataBinder.Eval(Container.DataItem, "ID")%>'
                                                        CssClass="EditLink" CommandName="EditLink" runat="server">
                                                        <asp:Image ID="Image1" ImageUrl="~/images/spacer.gif" ToolTip="ویرایش آدرس" CssClass="EditLink"
                                                            runat="server" />
                                                    </asp:LinkButton>
                                                </div>
                                                <div class="LinkDesc">
                                                    <%#DataBinder.Eval(Container.DataItem, "Description")%></div>
                                            </div>
                                        </div>
                                        <div class="clear">
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:Panel ID="Panel1" CssClass="EditLinkAreaHidden" runat="server">
                                    <div class="Marginer1">
                                        <div class="CloseSiteFunc" onclick="this.parentNode.className='EditLinkAreaHidden'">
                                        </div>
                                        <table style="float: right; margin-right: 60px;">
                                            <tr>
                                                <td colspan="2">
                                                    <AKP:MsgBox runat="server" ID="msgBox"></AKP:MsgBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtTitle" Width="420" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label3" runat="server" Text=":عنوان سایت"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtDescription" Width="420" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label4" runat="server" Text=":شرح سایت"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtSenderName" Width="420" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" Text=":نام فرستنده"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txtEmail" SkinID="English" Width="420" runat="server"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label6" runat="server" Text=":ایمیل فرستنده"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div style="text-align: right">
                                                        <telerik:RadCaptcha ID="RadCaptcha1" CssClass="Capt" Width="300" CaptchaImage-ImageCssClass="CaptImg"
                                                            CaptchaTextBoxCssClass="CaptText" runat="server"
                                                            ErrorMessage="" CaptchaTextBoxLabel="">
                                                        </telerik:RadCaptcha>
                                                    </div>
                                                </td>
                                                <td>
                                                     <asp:Label ID="Label7" runat="server" Text=":کد امنیتی"></asp:Label>
                                                    <asp:Label ID="Label8" CssClass="cReq" runat="server" Text="*"></asp:Label>
                                                    
                                                </td>
                                            </tr>
                                        </table>
                                        <div class="ErrorContainer">
                                            <asp:CheckBoxList ID="CheckBoxList1" CssClass="tblSiteErrors" runat="server">
                                                <asp:ListItem Value="سایت قابل مشاهده نیست " Text="سایت قابل مشاهده نیست "></asp:ListItem>
                                                <asp:ListItem Value="سایت فیلتر شده است " Text="سایت فیلتر شده است "></asp:ListItem>
                                                <asp:ListItem Value="سایت منقضی شده است " Text="سایت منقضی شده است "></asp:ListItem>
                                                <asp:ListItem Value="سایت خطا می دهد " Text="سایت خطا می دهد "></asp:ListItem>
                                                <asp:ListItem Value="شرح سایت ایراد نگارشی دارد " Text="شرح سایت ایراد نگارشی دارد "></asp:ListItem>
                                                <asp:ListItem Value="شرح سایت کامل نیست " Text="شرح سایت کامل نیست "></asp:ListItem>
                                                <asp:ListItem Value="آدرس اینترنتی عوض شده است " Text="آدرس اینترنتی عوض شده است "></asp:ListItem>
                                            </asp:CheckBoxList>
                                        </div>
                                        <div style="text-align: left">
                                            <asp:LinkButton ID="btnSend" CssClass="button" runat="server" OnClick="btnSend_Click">ارسال</asp:LinkButton>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="pnlMessage" Visible="false" CssClass="Message">
                                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                </asp:Panel>
                                <asp:HiddenField ID="hfSiteID" runat="server" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
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
    <asp:Panel ID="pnlEditLink" CssClass="EditLinkArea" runat="server">
        <div class="Marginer1">
            <div>
                <asp:CheckBoxList ID="chkListErrors" Visible="false" runat="server">
                    <asp:ListItem Value="1" Text="سایت قابل مشاهده نیست"></asp:ListItem>
                    <asp:ListItem Value="1" Text="سایت فیلتر شده است"></asp:ListItem>
                    <asp:ListItem Value="1" Text="سایت منقضی شده است"></asp:ListItem>
                    <asp:ListItem Value="1" Text="سایت خطا می دهد"></asp:ListItem>
                    <asp:ListItem Value="1" Text="شرح سایت ایراد نگارشی دارد"></asp:ListItem>
                    <asp:ListItem Value="1" Text="شرح سایت کامل نیست"></asp:ListItem>
                    <asp:ListItem Value="1" Text="آدرس اینترنتی عوض شده است"></asp:ListItem>
                </asp:CheckBoxList>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
