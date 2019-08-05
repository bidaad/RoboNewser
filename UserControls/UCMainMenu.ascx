<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMainMenu.ascx.cs"
    Inherits="Decili.UserControls.MainMenu" %>
<div>
    <ul class="TopMenu">
        <li>
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Default.aspx" runat="server">صفحه اصلی</asp:HyperLink>
        </li>
        <li>
            <div class="SubMenuCont">
                <div class="VMenuItem" id="mnuMainMenu">
                    <span>منو</span>
                </div>
                <div class="hide SubMenu" id="submenuMainMenu">
                    <div class="container">
                        <div>
                            <ul class="navSubMenu">
                                <li class="boldtext">
                                    <asp:HyperLink ID="HyperLink40" NavigateUrl="~/News" runat="server">اخبار</asp:HyperLink></li>
                                <li>
                                    <asp:HyperLink ID="HyperLink41" NavigateUrl="~/Culture" runat="server">فرهنگی</asp:HyperLink></li>
                                <li>
                                    <asp:HyperLink ID="HyperLink42" NavigateUrl="~/Fun" runat="server">سرگرمی</asp:HyperLink></li>
                                <li>
                                    <asp:HyperLink ID="HyperLink43" NavigateUrl="~/Contents/MainCats/15.htm" runat="server">سلامت</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Contents/MainCats/26.htm" runat="server">اسرار خانه داری</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink3" NavigateUrl="~/Contents/MainCats/33.htm" runat="server">دنیای مد</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink5" NavigateUrl="~/Contents/MainCats/39.htm" runat="server">روان شناسی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink6" NavigateUrl="~/Contents/MainCats/47.htm" runat="server">آرایش و زیبایی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink7" NavigateUrl="~/Tourism" runat="server">گردشگری</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink8" NavigateUrl="~/Contents/MainCats/61.htm" runat="server">زناشویی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink9" NavigateUrl="~/Contents/MainCats/69.htm" runat="server">آشپزی و تغذیه</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink10" NavigateUrl="~/Contents/MainCats/77.htm" runat="server">کودکان و والدین</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink11" NavigateUrl="~/Contents/MainCats/98.htm" runat="server">مذهبی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink12" NavigateUrl="~/Contents/MainCats/107.htm" runat="server">کامپیوتر و اینترنت</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink13" NavigateUrl="~/Contents/MainCats/114.htm" runat="server">علمی و آموزشی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink14" NavigateUrl="~/Contents/MainCats/122.htm" runat="server">ورزش و تندرستی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink15" NavigateUrl="~/Contents/MainCats/39.htm" runat="server">اطلاعات عمومی</asp:HyperLink>
                                </li>
                                <li>
                                    <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Games" runat="server">بازی آنلاین</asp:HyperLink>
                                </li>

                            </ul>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </div>
            </div>
        </li>
        <li>
            <asp:HyperLink NavigateUrl="~/Reg" ID="hplReg" runat="server">ثبت نام</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink ID="hplLogin" NavigateUrl="~/Users/Login.aspx" runat="server">ورود</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink NavigateUrl="~/AboutUs.aspx" ID="hplAboutUs" runat="server">درباره ما</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink NavigateUrl="~/ContactUs.aspx" ID="hplContactUs" runat="server">تماس با ما</asp:HyperLink>
        </li>
        <li>
            <asp:HyperLink NavigateUrl="~/Advertise.aspx" ID="hplAdver" runat="server">تبلیغات</asp:HyperLink>
        </li>

    </ul>

</div>

