<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCTopNewBox.ascx.cs" Inherits="RoboNewser.UserControls.UCTopNewBox" %>
<div >
    <div class="CatHeaderCont">
        <div class="pull-right">
            <asp:HyperLink ID="hplMore" runat="server">ادامه <i class="fa fa-angle-double-left"></i>
            </asp:HyperLink>
        </div>

        <h3 class="CatHeader">
            <asp:Label ID="lblCatTitle" Text=""
                runat="server"></asp:Label>

        </h3>
    </div>
    <div class="clear"></div>
    <div class="Padder10">
    <div class="row">
        <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
            <div class="ContentHeadImg">
                <asp:HyperLink ID="hplTopNews" runat="server">
                    <asp:Image BorderWidth="1" ID="ImgTopNews" CssClass="TopPic" runat="server" />
                </asp:HyperLink>
            </div>
            <div class="Farsi Padder5">
                <asp:HyperLink ID="hplTopNewsTitle" Target="_blank" CssClass="ACont" runat="server"></asp:HyperLink>
                &nbsp;<span
                    class="cResource"><asp:HyperLink ID="hplResource" runat="server"></asp:HyperLink></span>
            </div>
            <div class="ContText">
                <asp:Label ID="lblTopNewsStory" runat="server"></asp:Label>
            </div>
        </div>
        <div class="col-lg-7 col-md-7 col-sm-7 col-xs-12">
            <div class="NewsMainPageSmallList">
                <asp:Repeater ID="rptNews" runat="server" EnableViewState="false">
                    <ItemTemplate>

                        <div class="row">
                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">
                                <asp:HyperLink ID="HyperLink6" NavigateUrl='<%#"https://www.robonewser.com/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>'
                                    Target="_blank" ImageUrl='<%#"~/Files/News/" +Eval("PicName") %>' runat="server"></asp:HyperLink>
                            </div>
                            <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 ">
                                <asp:HyperLink ID="HyperLink1" CssClass="ACont" Target="_blank" NavigateUrl='<%#"https://www.robonewser.com/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>'
                                    runat="server">
                                    <%#Eval("Title") %>&nbsp;<span class="cResource"><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"https://www.robonewser.com/NR" + Eval("ResouseSiteCode") + "_" + Tools.ReplaceSpaceWithUnderline(Eval("ResourceName")) + ".html"%>'><%#DataBinder.Eval(Container.DataItem, "ResourceName")%></asp:HyperLink></span>
                                </asp:HyperLink>
                            </div>
                        </div>


                    </ItemTemplate>
                </asp:Repeater>
            </div>

        </div>
    </div>
        </div>
    <div class="clear">
    </div>
</div>
