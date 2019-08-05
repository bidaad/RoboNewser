<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsTicker.ascx.cs"
    Inherits="RoboNewser.UserControls.UCNewsTicker" %>
<div id="objNewsTicker">
</div>


<div class="row">

    
    <div class="col-lg-6 col-md-6 col-sm-6 co5-xs-12">
        <div id="newsticker">
            <div id="ticker-wrapper" class="no-js">
                <ul id="js-news" class="js-hidden">
                    <asp:Repeater ID="rptNews" EnableViewState="false" runat="server">
                        <ItemTemplate>
                            <li>
                                <div class="NewsTitle">
                                    <asp:HyperLink ID="HyperLink2" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>'
                                        NavigateUrl='<%#"https://www.robonewser.com/N" + Eval("Code") + "_" + Tools.ReplaceSpaceWithUnderline(Eval("Title")) + ".html" %>'
                                        Text='<%#Tools.ChangeEnc(Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),60))%>'
                                        runat="server"></asp:HyperLink>&nbsp;<span
                                            class="cDate"><%#Tools.GetPrettyPersianDate2(DataBinder.Eval( Container.DataItem, "NewsDate"))%></span>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </div>

    <div class="col-lg-5 col-md-5 col-sm-5 col-xs-10">
        <div class="row">
            <div class="col-lg-10 col-md-10 col-sm-6 col-xs-6">
                <input type="text" id="txtKeyword" class="form-control" placeholder="جستجو در اخبار" />
            </div>
            <div class="col-lg-2 col-md-2 col-sm-6 col-xs-6 text-left">
                <input type="button" id="btnSearch" class="btn btn-primary" onclick="SearchNews()" value="جستجو" />
            </div>
        </div>
    </div>
    <div class="col-lg-1 col-md-1 col-sm-2 col-xs-2 text-right ">
        <div class="RSS">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/News/RSS.aspx" CssClass="cRSS" ImageUrl="~/images/spacer.gif"
            Width="32" Height="32" runat="server"></asp:HyperLink>
            </div>
    </div>


</div>
<div class="clear">
</div>
    <script type="text/javascript">
        $(document).ready(function () {
            Url = SiteDomain + "Ajax/AjaxNewsTicker.aspx"
            startTickerRequest(Url, AjaxNewsTickerResult, 'GET', null);
        });
    </script>

