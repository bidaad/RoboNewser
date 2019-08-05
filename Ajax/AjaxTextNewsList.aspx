<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="AjaxTextNewsList.aspx.cs" Inherits="RoboNewser.Ajax.AjaxTextNewsList" %>

<div class="CatHeaderCont">
    <h3 class="CatHeader">
        <asp:literal id="lblCatTitle" text="پر بیننده ترین خبرها"
            runat="server"></asp:literal>
    </h3>
</div>
<div class="clear">
</div>
<div class="cSpacer">
</div>
<div class="Padder5">
    <div class="TextNewsList">
        <asp:repeater id="rptNewsList" enableviewstate="false" runat="server">
            <ItemTemplate><div ><asp:HyperLink runat="server" CssClass="cTitle" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>' NavigateUrl='<%#"~/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>'><%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"), 90)%></asp:HyperLink>&nbsp;</div></ItemTemplate>
        </asp:repeater>
    </div>
</div>
