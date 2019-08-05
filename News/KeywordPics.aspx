<%@ Page Title="" Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" CodeBehind="KeywordPics.aspx.cs" Inherits="RoboNewser.News.KeywordPics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="server">
    <div class="panel">
        <h1>
            <asp:Literal ID="lblTitle" runat="server"></asp:Literal>
        </h1>
        <div class="Clear">
        </div>
        <div class="row">
            <asp:Repeater ID="rptPics" runat="server">
                <ItemTemplate>
                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <div class="PicItem">
                            <div>
                                <asp:HyperLink NavigateUrl='<%#"~/News/" + Eval("Code")  + ".html" %>' runat="server"><asp:Image CssClass="img-fluid" AlternateText='<%# Eval("Title") %>' ToolTip=<%# Eval("Title") %> ImageUrl=<%#Eval("ImgUrl") %> runat="server"/></asp:HyperLink>
                            </div>
                            <div>
                                <asp:HyperLink NavigateUrl='<%#"~/News/" + Eval("Code")  + ".html" %>' runat="server"><%#Eval("Title") %></asp:HyperLink>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>


        <div class="ByRoboNewser">
            All news has been gathered by <a href="https://www.robonewser.com/Crawler">RoboNewser Crawler</a><br />
        </div>
    </div>
</asp:Content>
