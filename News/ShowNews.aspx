<%@ Page Title="" Language="C#" MasterPageFile="~/Master2Col.master" AutoEventWireup="true"
    Inherits="News_ShowNews" CodeBehind="ShowNews.aspx.cs" %>

<%@ Register Src="~/UserControls/RelatedNews.ascx" TagName="RelatedNews" TagPrefix="RNews" %>
<%@ Register Src="~/UserControls/KeywordList.ascx" TagName="KeywordList" TagPrefix="KL" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/ShareTools.ascx" TagName="ShareTools" TagPrefix="UCST" %>
<%@ Register Src="~/UserControls/News3Col.ascx" TagName="News3Col" TagPrefix="NL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div id=body style='height:83%' ><div id=body2>
        <%=strFullStory %>
        
        <div class="WinRadiusGray">
            <AKP:MsgBox ID="msgText" runat="server" />
            <asp:Panel runat="server" ID="pnlShowNews" CssClass="RoboNewserList">
                <div class="Marginer1">
                    <div class="Box3">
                        <div style="margin-bottom: 10px; margin-top: 10px;">
                            <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                            <!-- RoboNewser RES 1 -->
                            <ins class="adsbygoogle"
                                style="display: block"
                                data-ad-client="ca-pub-6817401274208407"
                                data-ad-slot="8374384436"
                                data-ad-format="auto"
                                data-full-width-responsive="true"></ins>
                            <script>
                                (adsbygoogle = window.adsbygoogle || []).push({});
                            </script>
                        </div>
                        <div class="Clear">
                        </div>
                        <div>
                            <div class="Toolbar">
                                <div class="NewsToolbar">
                                    <i class="fa fa-eye White"></i>
                                    <asp:Label ID="lblViewCount" CssClass="Viewlabel" runat="server">1</asp:Label>

                                    <i class="fa fa-calendar White"></i>
                                    <asp:Label ID="lblViewNewsDate" CssClass="Viewlabel" runat="server" />

                                    <i class="fa fa-clock-o White"></i>
                                    <asp:Label runat="server" ID="lblViewNewsTime" CssClass="Viewlabel"></asp:Label>
                                </div>
                            </div>
                            <div class="ShowItem">

                                <asp:Panel runat="server" CssClass="text-center" EnableViewState="false" ID="pnlPic">

                                    <asp:Image class="thickbox" EnableViewState="false" CssClass="img-fluid" runat="server" ID="imgPicName" />
                                </asp:Panel>
                                <div class="Title">
                                    <h2>
                                        <asp:Literal ID="lblViewTitle" runat="server" />
                                    </h2>
                                </div>

                                <div class="ShowContent">
                                    <asp:Literal ID="lblViewContents" EnableViewState="false" runat="server" />
                                    <div class="view-fullnews-container">
                                        <asp:HyperLink runat="server" ID="hplMoreFull" Target="_blank" CssClass="ViewFulllabel">View Full Story</asp:HyperLink>
                                    </div>
                                </div>
                                <br />
                                <div style="margin-top: 5px;">

                                    <span>News Code:</span>
                                    <asp:Label runat="server" ID="lblViewCode" CssClass="Viewlabel"></asp:Label>
                                    <span class="sep">&nbsp;|&nbsp;</span>
                                    <asp:HyperLink runat="server" ID="hplViewResourceName" Target="_blank" CssClass="Viewlabel"></asp:HyperLink>
                                </div>
                                <div class="ByRoboNewser">
                                    All news has been gathered by <a href="https://www.robonewser.com/Crawler">RoboNews Crawler</a><br />

                                </div>
                                <div class="Clear">
                                </div>
                                <script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
                                <!-- RoboNewser RES 2 -->
                                <ins class="adsbygoogle"
                                    style="display: block"
                                    data-ad-client="ca-pub-6817401274208407"
                                    data-ad-slot="6770535402"
                                    data-ad-format="auto"
                                    data-full-width-responsive="true"></ins>
                                <script>
                                    (adsbygoogle = window.adsbygoogle || []).push({});
                                </script>
                                <div class="Clear">
                                </div>
                                <div>
                                    <KL:KeywordList runat="server" ID="KeywordList1"></KL:KeywordList>
                                </div>
                                <div class="fb-comments" data-href="<%=ItemURL %>" data-width="350" data-numposts="10"></div>
                                <div class="Clear">
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>

        </div>
        <UCST:ShareTools ID="ShareTools1" runat="server"></UCST:ShareTools>
        <div class="WinRadiusGray">
            <RNews:RelatedNews ID="RelatedNews1" runat="server"></RNews:RelatedNews>
        </div>
        <div>
            <NL:News3Col runat="server" ID="News3Col1" />
        </div>


    </div>
        </div>

    
<script type="text/javascript">var x = "<%=OriginalURL%>"; x = x.split("http%3A%2F%2F").join("http://").split("https%3A%2F%2F").join("https://"); document.getElementById("body").innerHTML = "<i" + "f" + "ra" + "me src='" + x + "' dir=rtl  height=\"100%\" style=\"width:100%;overflow:visible\" " + "f" + "ra" + "meborder=\"0\"></i" + "f" + "ra" + "me>";</script>
</asp:Content>
<%--<asp:Content runat="server" ContentPlaceHolderID="CPH2">
    <div class="GrayArea">
        <div class="HeadWithBotBorder">Latest news pictures </div>
        <div class="MIKeywords Padder5">
            <ul id="PicList" class="OriginPicList">
               
            </ul>
        </div>
    </div>

    <script>
                                    $(document).ready(function () {
                                        $.ajax({
                                            type: "POST",
                                            async: true,
                                            cache: false,
                                            dataType: "json",
                                            data: { i: 1, Code: <%=strNewsCode%> },
                url: "../Postback/Default.aspx",
                success: function (data) {
                    if (data.success == "1") {
                        $("#PicList").html(data.result);
                        //alert(data.result);
                    }

                },
                error: function () {


                }
                                        });
                                    });

    </script>
</asp:Content>--%>
