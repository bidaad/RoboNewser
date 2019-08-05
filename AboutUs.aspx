<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" Inherits="AboutUs"
    Title="درباره پارست" CodeBehind="AboutUs.aspx.cs" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="WinRadiusGray">
        <div class="CatHeaderCont">
            <h3 class="CatHeader">
                <asp:Label ID="lblCatTitle"  Text="درباره ما"
                    runat="server"></asp:Label>
            </h3>
        </div>
        <div class="clear">
        </div>
        <AKP:MsgBox ID="msgText" runat="server" />
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="Box3">
                    <div class="Clear">
                    </div>
                    <div class="Marginer2">
                        <div class="Farsi">
                            <span lang="fa"><font size="2">سايت پارست در مهرماه 82 به منظور اطلاع رسانی و توسعه
                                فعاليتهای فرهنگی در ايران با امکانات کاملا رايگان راه اندازی گرديد.<br>
                                بيش از 340000 بيت شعر فارسی ، متن کامل قرآن مجيد و نهج البلاغه، آدرس و تلفن بيش
                                از 26000 واحد تجاری، آدرس سايتهای ايرانی، فرهنگ لغات شش زبانه، 3600 نام نوزاد و...<br>
                                از محتویات این سایت است.<br>
                                اين سايت به هيچ گروه، موءسسه يا انجمنی وابسته نميباشد و تنها به منظور اطلاع رسانی
                                به معرفی ديگر سايتها پرداخته است. مسووليت محتوای سايتها به عهده پارست نميباشد.</font></span>&nbsp;&nbsp;
                            <p align="left">
                                <span lang="fa"><font size="2">عليرضا گرجی</font></span></p>
                            <p align="left">
                                <span lang="fa"><font size="2">مدير سايت</font></span></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="Clear">
    </div>
</asp:Content>
