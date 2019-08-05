<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Root1.master" CodeBehind="Default.aspx.cs" Title="About RoboNewser"
    Inherits="WebApp_Crawler_Default" %>



<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
<div class="WinRadiusGray">
    <div class="CatHeaderCont">
            <h3 class="CatHeader">
                <asp:Label ID="lblCatTitle" Text="About RoboNewser"
                    runat="server"></asp:Label>
            </h3>
        </div>
    <AKP:MsgBox ID="msgText" runat="server" />
        <div class="RoboNewserList">
            <div class="Marginer1">
                <div class="RoundBorder1 ">
                    
                    <div class="Marginer2">
                        <div class="Farsi" >The RoboNewser Search Engine gathers the news from sources defined, such as CNN, Fox News, etc.
                            Searches and saves new news.
                            <br />
                            The title and text of the news as well as the photo of the news are received in full if available.
                            
                            <br />
                            The news tags or the same news tags are automatically extracted from the news text and
                            with these keywords you can retrieve news about a specific topic.
                            For example, the United Nations news via <a href="https://www.robonewser.com/NK2623_United_Nations.html" style="text-decoration:underline;"> this
                                Address </a> is available. <br />
                            <br />
                            &nbsp; Another added value of any news found through this system is related news.
                            In this way, when storing the news, the news through the algorithms used on the site of the RoboNewser
                            are also found. <br />
                           
                            It is easy to use this system to automatically collect news about a specific area, for example
                            Transportation, oil and ... <br />
                            It is obvious that in this case, to a large extent, human error and the costs associated with it
                             is saved. Of course. The robot's performance and accuracy is near 100
                            ercentage and mistakes during work, such as the production of wrong keywords and happens.
                            
                            <br />
                            <br />
                            All interested people are invited to collaborate on data processing and analysis.
<a href="http://RoboNewser.com/ContactUs.aspx"> Communicate with us. </a></div>

                    </div>
                </div>
            </div>
        </div>
    <div class="Clear">
    </div>
</div>
</asp:Content>
