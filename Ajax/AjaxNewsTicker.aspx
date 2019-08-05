<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxNewsTicker.aspx.cs" Inherits="RoboNewser.Ajax.AjaxNewsTicker" %>

<asp:repeater id="rptNews" enableviewstate="false" runat="server">
    <ItemTemplate><li><div class="NewsTitle"><asp:HyperLink Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>' NavigateUrl='<%#"https://www.robonewser.com/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>' Text='<%#Tools.ChangeEnc(Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),60))%>' runat="server"></asp:HyperLink>&nbsp;<span class="cDate"><%#Tools.GetPrettyPersianDate2(DataBinder.Eval( Container.DataItem, "NewsDate"))%></span></div></li></ItemTemplate>
</asp:repeater>
