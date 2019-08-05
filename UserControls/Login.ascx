<%@ Control Language="C#" AutoEventWireup="True" Inherits="UserControls_Login" CodeBehind="Login.ascx.cs" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="panel panel-default Marginer20">
            <div class="panel-heading ListTitle">
                <h3 class="panel-title BulletList">ورود به حساب کاربری</h3>
            </div>
            <div class="Padder5 text-center">
                <AKP:MsgBox runat="server" ID="msgBox">
                </AKP:MsgBox>
                <div class="RegformCont">
                    <div class="form-group RegField">
                        <asp:TextBox ID="txtUsername" runat="server" placeholder="ایمیل" CssClass="form-control LTR" />
                    </div>
                    <div class="form-group RegField">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="کلمه عبور"
                            CssClass="form-control LTR" />
                        <span onmouseup="hidePass($(this))" onmousedown="showPass($(this))" class="viewpass">
                            <img alt="مشاهده کلمه عبور" src="../images/viewpassword.png"></span>
                    </div>
                    <div class="checkbox pull-left">
                        <label>
                            <AKP:ExCheckBox ID="chkRemInfo" ClientIDMode="Static" runat="server" />
                            من را به خاطر بسپار
                        </label>
                    </div>
                    <div class="Clear"></div>
                     <div class="form-group RegField pull-left">
                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Users/ForgotPass1.aspx" runat="server">کلمه عبور را فراموش کرده ام</asp:HyperLink>
                    </div>
                    <div class="Clear">
                    </div>
                    <div style="margin-right: 0px; margin-top: 5px;">
                        <asp:Button ID="imgBtnLogin" CssClass="btn btn-primary container" Width="80" runat="server" Text="ورود"
                            OnClick="imgBtnLogin_Click" />
                         <asp:Button ID="btnReg" CssClass="btn btn-info container" runat="server" Width="80" Text="عضویت"
                            OnClick="btnReg_Click" />
                    </div>
                   
                    
                    
                </div>
                <div class="clear">
                </div>
            </div>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>
<asp:HiddenField ID="hfPrePage" runat="server" />
