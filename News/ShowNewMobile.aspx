<%@ Page Language="C#" MasterPageFile="~/Mobile1.Master" AutoEventWireup="true" CodeBehind="ShowNewMobile.aspx.cs"
    Inherits="RoboNewser.News.ShowNewMobile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div class="Toolbar">
        <div>
            <div style="float: left">
            </div>
            <div style="padding-top: 5px; padding-right: 5px;">
                <span id="Span1">تعداد بازدید:</span>
                <asp:Label ID="lblViewCount" CssClass="Viewlabel" runat="server">1</asp:Label><span
                    class="sep">&nbsp;|&nbsp;</span> <span id="Span2">تاريخ انتشار:</span>
                <asp:Label ID="lblViewNewsDate" CssClass="Viewlabel" runat="server" />
            </div>
        </div>
    </div>
    <div class="ShowItem">
        <asp:Panel runat="server" EnableViewState="false" ID="pnlPic">
            <fieldset class="Pic">
                <legend>&nbsp;<asp:Label runat="server" Text="عکس" ID="lblPicName" />&nbsp;</legend>
                <div class="cPic">
                    <asp:Image class="thickbox" EnableViewState="false" runat="server" ID="imgPicName" /></div>
            </fieldset>
        </asp:Panel>
        <div class="Title">
            <asp:Label ID="lblViewTitle" MaxLength="500" runat="server" /></div>
        <div class="Content">
            <asp:Label ID="lblViewContents" EnableViewState="false" ShowAllText="1" runat="server" />
        </div>
        <br />
        <div class="Farsi" style="margin-top: 5px;">
            <span id="lblNewsTime">ساعت انتشار:</span>
            <asp:Label runat="server" ID="lblViewNewsTime" CssClass="Viewlabel"></asp:Label>
            <span class="sep">&nbsp;|&nbsp;</span> <span>کد خبر:</span>
            <asp:Label runat="server" ID="lblViewCode" CssClass="Viewlabel"></asp:Label>
            <span class="sep">&nbsp;|&nbsp;</span> <span id="Label2">منبع:</span>
            <asp:HyperLink runat="server" ID="hplViewResourceName" CssClass="Viewlabel">جام جم</asp:HyperLink>
        </div>
    </div>
</asp:Content>
