<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/RootCol1.master" CodeBehind="PayDomainStep1.aspx.cs" Title="پرداخت آنلاین مبلغ دامنه" Inherits="Parsetv91._1.Domain.PayDomainStep1" %>

<%@ Register Src="~/UserControls/UserMenu.ascx" TagName="UserMenu" TagPrefix="UCUserMenu" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="CP1">
    <div class="Col2Pay">
        <div class="Col2PayLeft">
            <div class="WinRadiusGray" style="min-height: 450px;">
                <div class="Marginer1">
                    <div class="Farsi">
                        <h2>راهنمای پرداخت</h2>
                        <p>
                            به روش های ساده زیر پرداخت کنید:
                        </p>
                        <p>
                            <br>
                        </p>
                        <p>
                            <strong>روش آنلاین:</strong> با استفاده از کارت اعتباری بانکی خود به صورت آنلاین
                            هزینه ثبت دامنه خود را پرداخت کنید.
                        </p>
                        <p>
                            <br>
                        </p>
                        <p>
                            <strong>افزایش موجودی حساب:</strong> برای <span lang="fa">شارژ حساب</span> <span
                                lang="fa">لازم است ابتدا عضو سایت شوید. سپس میتوانید بصورت آنلاین</span> موجودی
                            حساب خود را <span lang="fa">به هر میزان</span> که مایلید<span lang="fa"> (حداقل 1000
                                تومان)</span> افزایش دهید و سپس <span lang="fa">با بهره مندی از تخفیفات ویژه سایت اقدام
                                    به ثبت دامنه نمایید</span>. <a target="_blank" style="color: Blue;" href="http://parset.com//users/AccountCharge.aspx">افزایش موجودی حساب</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class="Col2PayRight">
            <div class="WinRadiusGray">
                <div class="CatHeaderCont">
                    <h3 class="CatHeader">
                        <asp:Label ID="lblCatTitle" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;پرداخت مبلغ دامین"
                            runat="server"></asp:Label>
                    </h3>
                </div>
                <div class="clear">
                </div>
                <div>
                    <div>
                        <div class="Marginer1">
                            <div class="Box1" style="margin-top: 10px;">
                                <div class="PayPanel">
                                    <div>
                                        <AKP:MsgBox runat="server" ID="msg">
                                        </AKP:MsgBox>
                                    </div>
                                    <div>
                                        ابتدا نام دامنه مورد نظر خود را به همراه کد امنیتی وارد کنید تا از آزاد بودن آن اطمینان حاصل کنید.

                                    </div>
                                    <div>
                                        <table style="float: right; right: 100px;">
                                            <tr>
                                                
                                                <td>
                                                    <asp:TextBox ID="txtDomainName" SkinID="English" runat="server"></asp:TextBox>
                                                </td>
                                                <td class="lbl">دامین:
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><telerik:RadCaptcha ID="RadCaptcha1" CssClass="Capt" Width="300" CaptchaImage-ImageCssClass="CaptImg"
                                                    CaptchaTextBoxCssClass="CaptText" runat="server" ErrorMessage="" CaptchaTextBoxLabel="">
                                                </telerik:RadCaptcha></td>
                                                <td class="lbl"><asp:Label ID="Label5" runat="server" Text="کد امنیتی:"></asp:Label></td>

                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Button ID="btnCheckDomain" CssClass="input-button" runat="server" Text="بررسی وضعیت" OnClick="btnCheckDomain_Click" />
                                                </td>

                                            </tr>
                                        </table>
                                    </div>
                                    <div class="clear">
                                    </div>
                                    <asp:Panel runat="server" Visible="false" ID="pnlPay">
                                        <div class="LargeMessage">
                                            <table>
                                                <tr>
                                                    <td>مبلغ قابل پرداخت:
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblDomainCost" runat="server"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label2" runat="server" Text="تومان"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div>
                                            <table style="float: right; right: 100px;">
                                                <tr>
                                                    <td></td>

                                                    <td>
                                                        <asp:Label ID="Label3" runat="server" Text="پرداخت با استفاده از درگاه بانک پارسیان"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div class="clear">
                                        </div>
                                        <div style="text-align: center;">
                                            <div id="BankLoading"></div>
                                            <div>
                                                <table style="margin-left:100px;">
                                                    <tr>
                                                        <td>
                                                            <AKP:ExTextBox runat="server" ID="txtName"></AKP:ExTextBox>
                                                        </td>
                                                        <td class="lbl">
                                                            <asp:Label ID="Label1" runat="server" Text="نام و نام خانوادگی:"></asp:Label></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <AKP:ExTextBox runat="server" ID="txtEmail"></AKP:ExTextBox>
                                                        </td>
                                                        <td class="lbl">
                                                            <asp:Label ID="Label4" runat="server" Text="ایمیل:"></asp:Label>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  ValidationGroup="DomainReg" Display="Dynamic" ControlToValidate="txtEmail"
                                                runat="server" ErrorMessage="ایمیل را وارد کنید"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" Display="Dynamic"
                                                runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                ControlToValidate="txtEmail" ValidationGroup="DomainReg" ErrorMessage="ایمیل معتبر نیست"></asp:RegularExpressionValidator>

                                                        </td>
                                                    </tr>

                                                </table>

                                            </div>
                                            <asp:ImageButton ImageUrl="~/images/site/ContinuePay.png" ID="btnPayCost"  ValidationGroup="DomainReg" 
                                                runat="server" Text="پرداخت" OnClick="btnPayCost_Click" />
                                        </div>
                                        <div dir="rtl" id="paymentBox">
                                            <div id="shetab" style="opacity: 1;">
                                                &nbsp;
                                            </div>
                                            <div id="banks">
                                                <h3>درگاه پرداخت فوق پذیرنده تمامی کارت های بانکی عضو شبکه شتاب می باشد.</h3>
                                                <div class="Clear">
                                                </div>
                                                <ul class="list1" id="banks-list">
                                                    <li style="background-position: -216px 0px; border-width: 1px; top: 0px;" id="bank-number-9">
                                                        <span class="english-title">melli</span><span class="persian-title">ملی</span></li>
                                                    <li style="background-position: -240px 0px; border-width: 1px; top: 0px;" id="bank-number-10">
                                                        <span class="english-title">saderat</span><span class="persian-title">صادرات</span></li>
                                                    <li style="background-position: -120px 0px; border-width: 1px; top: 0px;" id="bank-number-5">
                                                        <span class="english-title">parsian</span><span class="persian-title">پارسیان</span></li>
                                                    <li style="background-position: -48px 0px; border-width: 1px; top: 0px;" id="bank-number-2">
                                                        <span class="english-title">mellat</span><span class="persian-title">ملت</span></li>
                                                    <li style="background-position: 0px 0px; border-width: 1px; top: 0px;" id="bank-number-0">
                                                        <span class="english-title">saman</span><span class="persian-title">سامان</span></li>
                                                    <li style="background-position: -288px 0px; border-width: 1px; top: 0px;" id="bank-number-12">
                                                        <span class="english-title">tejarat</span><span class="persian-title">تجارت</span></li>
                                                    <li style="background-position: -360px 0px; border-width: 1px; top: 0px;" id="bank-number-15">
                                                        <span class="english-title">refah</span><span class="persian-title">رفاه</span></li>
                                                    <li style="background-position: -384px 0px;" id="bank-number-16"><span class="english-title">sepah</span><span class="persian-title">سپه</span></li>
                                                    <li style="background-position: -480px 0px;" id="bank-number-20"><span class="english-title">maskan</span><span class="persian-title">مسکن</span></li>
                                                    <li style="background-position: -24px 0px; border-width: 1px; top: 0px;" id="bank-number-1">
                                                        <span class="english-title">eghtesade-novin</span><span class="persian-title">اقتصاد
                                                    نوین</span></li>
                                                    <li style="background-position: -72px 0px; border-width: 1px; top: 0px;" id="bank-number-3">
                                                        <span class="english-title">keshavarzi</span><span class="persian-title">کشاورزی</span></li>
                                                    <li style="background-position: -192px 0px; border-width: 1px; top: 0px;" id="bank-number-8">
                                                        <span class="english-title">pasargad</span><span class="persian-title">پاسارگاد</span></li>
                                                </ul>
                                                <ul class="list2" id="Ul1">
                                                    <li style="background-position: -312px 0px; border-width: 1px; top: 0px;" id="bank-number-13">
                                                        <span class="english-title">toseye-tavon</span><span class="persian-title">توسعه تعاون</span></li>
                                                    <li style="background-position: -336px 0px; border-width: 1px; top: 0px;" id="bank-number-14">
                                                        <span class="english-title">ansar</span><span class="persian-title">انصار</span></li>
                                                    <li style="background-position: -264px 0px; border-width: 1px; top: 0px;" id="bank-number-11">
                                                        <span class="english-title">post-bank</span><span class="persian-title">پست بانک</span></li>
                                                    <li style="background-position: -96px 0px; border-width: 1px; top: 0px;" id="bank-number-4">
                                                        <span class="english-title">sina</span><span class="persian-title">سینا</span></li>
                                                    <li style="background-position: -408px 0px;" id="bank-number-17"><span class="english-title">sarmayeh</span><span class="persian-title">سرمایه</span></li>
                                                    <li style="background-position: -432px 0px;" id="bank-number-18"><span class="english-title">tat</span><span class="persian-title">تات</span></li>
                                                    <li style="background-position: -456px 0px;" id="bank-number-19"><span class="english-title">kar-afarin</span><span class="persian-title">کار آفرین</span></li>
                                                    <li style="background-position: -504px 0px;" id="bank-number-21"><span class="english-title">mehr</span><span class="persian-title">مهر</span></li>
                                                    <li style="background-position: -528px 0px; border-width: 1px; top: 0px;" id="bank-number-22">
                                                        <span class="english-title">dey</span><span class="persian-title">دی</span></li>
                                                    <li style="background-position: -552px 0px; border-width: 1px; top: 0px;" id="bank-number-23">
                                                        <span class="english-title">shahr</span><span class="persian-title">شهر</span></li>
                                                    <li style="background-position: -144px 0px; border-width: 1px; top: 0px;" id="bank-number-6">
                                                        <span class="english-title">toseye-saderat</span><span class="persian-title">توسعه صادرات</span></li>
                                                    <li style="background-position: -168px 0px; border-width: 1px; top: 0px;" id="bank-number-7">
                                                        <span class="english-title">sanato-madan</span><span class="persian-title">صنعت و معدن</span></li>
                                                </ul>
                                                <!--<p id="selected-bank-name">&nbsp;</p>-->
                                            </div>
                                        </div>
                                    </asp:Panel>

                                </div>

                            </div>
                            <div class="clear">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
