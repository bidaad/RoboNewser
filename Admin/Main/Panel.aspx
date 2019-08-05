<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Panel.aspx.cs" Inherits="RoboNewser.Panel"
    MasterPageFile="~/Admin/Main.master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="cphMain">
    <div class="homeBox">
        <div class="homeIconTable">
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <asp:HyperLink runat="server" NavigateUrl="~/Admin/News/EditNewsFlows.aspx">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/addNews.png" />
                    <h4>
                        ثبت جریان خبری جدید
                    </h4>
                </asp:HyperLink>
            </div>
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <asp:HyperLink runat="server" NavigateUrl="~/Admin/Main/Default.aspx?BaseID=News">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/newsList.png" />
                    <h4>
                        اخبار</h4>
                </asp:HyperLink>
            </div>
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <asp:HyperLink ID="hplBanners" runat="server" NavigateUrl="~/Admin/Main/Default.aspx?BaseID=Banners">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/addPage.png" />
                    <h4>
                        بنرها
                    </h4>
                </asp:HyperLink>
            </div>
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <asp:HyperLink ID="hplLinks" runat="server" NavigateUrl="~/Admin/Main/Default.aspx?BaseID=Advertises">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/addPage.png" />
                    <h4>
                        نیازمندی ها
                    </h4>
                </asp:HyperLink>
            </div>
            
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <asp:HyperLink runat="server" NavigateUrl="~/Admin/HardCode/HardCodes.aspx?ResourceName=HardCodes">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/config.png" />
                    <h4>
                        تنظیمات سایت</h4>
                </asp:HyperLink>
            </div>
            <div onmouseout="this.className='homeIconBox'" onmouseover="this.className='homeIconBox homeIconBoxHover'"
                class="homeIconBox">
                <a href="Logout.aspx">
                    <asp:Image runat="server" ImageUrl="~/Admin/images/Site/SignOut.png" />
                    <h4>
                        خروج</h4>
                </a>
            </div>
            <br class="clearfloat" />
        </div>
    </div>
</asp:Content>
