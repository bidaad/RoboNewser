<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_RandNews"
    CodeBehind="RandNews.ascx.cs" %>
<div>
    <div class="ContentCatMore">
        <asp:HyperLink ID="hplMore" NavigateUrl="~/News" runat="server">بیشتر  »</asp:HyperLink>
    </div>
    <div class="CatHeaderCont">
        <h3 class="CatHeader">
            <asp:Label ID="lblCatTitle" Text="اخبار" runat="server"></asp:Label>
        </h3>
    </div>
    <div class="clear">
    </div>
    <div class="bar">
    </div>
</div>
<div class="HeadNews">
    <div class="NewsContainer">
        <asp:Repeater ID="rptRandNews" EnableViewState="false" runat="server">
            <HeaderTemplate>
                <ul id="ticker">
            </HeaderTemplate>
            <ItemTemplate><li><div class="NewsTitle"><asp:HyperLink Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>' NavigateUrl='<%#"~/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>'
                            Text='<%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),60)%>'
                            runat="server"></asp:HyperLink>-&nbsp;<span class="cResource"><asp:HyperLink runat="server" NavigateUrl='<%#"~/NR" + Eval("ResourceSiteCode") + "_" + Tools.ReplaceSpaceWithUnderline(Eval("ResourceName")) + ".html"%>'><%#DataBinder.Eval(Container.DataItem, "ResourceName")%></asp:HyperLink></span>&nbsp;<span
                                    class="cDate"><%#Tools.GetPrettyPersianDate2(DataBinder.Eval( Container.DataItem, "NewsDate"))%></span></div></li></ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</div>
<script type="text/javascript">

    function tick() {
        $('#ticker li:first').slideUp(function () { $(this).appendTo($('#ticker')).slideDown(); });
    }
    setInterval(function () { tick() }, 5000);


</script>
