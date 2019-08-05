<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLatestNewsBox.ascx.cs" Inherits="RoboNewser.UserControls.UCLatestNewsBox" %>
<%@ Register Src="~/UserControls/UCNewsItems.ascx" TagName="NewsItems" TagPrefix="UC" %>
<div class="WinRadiusGray  MarginBot5">
    <div class="CatHeaderCont">
        <div class="pull-right">
            <div class="Wifi"></div>
        </div>
        <h3 class="CatHeader">
            <asp:Label ID="lblCatTitle" Text="پخش اخبار زنده"
                runat="server"></asp:Label>

        </h3>
    </div>
    <div class="clear"></div>
    <div class="LatestNewsCont">
        <div id="topNewsBox">
            <asp:Repeater ID="rptPagerNews" runat="server">
                <ItemTemplate>
                    <div>
                        <UC:NewsItems runat="server" PageNo="<%#Container.DataItem %>" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function () {
        $(".NewsPage").removeClass("hide");
        $('#topNewsBox').after('<div class="WholePager"><ul id="CyclePager" ></ul><br class="clearfloat" /></div>').cycle({
            fx: 'fade',
            speed: 'slow',
            fit: 1,
            width: '100%',
            timeout: 5000,
            pager: '#CyclePager',
            pagerAnchorBuilder: function (index, slide) {
                imgSrc = jQuery(slide).find('img').attr('src');
                Title = jQuery(slide).find('h3').text();
                return '<li><div class="TopSlider"></div></li>';
            }
        });

        $("#topNewsBox").mouseover(function () {
            $(this).cycle('pause');
        }).mouseout(function () {
            $(this).cycle('resume');
        });


    });

</script>
