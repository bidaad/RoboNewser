<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master2Col.Master"
    CodeBehind="AllNews.aspx.cs" Inherits="AllNews" %>

<%@ Register Src="~/UserControls/Resources.ascx" TagName="Resources" TagPrefix="UCResources" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/UCNewsCats.ascx" TagName="UCNewsCats" TagPrefix="UCNCats" %>
<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/UCNewsTicker.ascx" TagName="UCNewsTicker" TagPrefix="UCNT" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <div >
        <div class="panel ">
            <div class="heading">
                <h1>
                All News
                    </h1>
            </div>
            <div class="Padder10">
                <asp:Repeater ID="rptNewsList" EnableViewState="false" runat="server">
                    <HeaderTemplate>
                        <div class="TextNewsCont">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div>
                            <asp:HyperLink ID="HyperLink1" Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>'
                                NavigateUrl='<%#"https://www.robonewser.com/News/" + Eval("Code") +  ".html" %>'
                                Text='<%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),60)%>'
                                runat="server"></asp:HyperLink>-&nbsp;<span class="cResource"><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"https://www.parset.com/NR" + Eval("ResourceSiteCode") + "_" + Tools.ReplaceSpaceWithUnderline(Eval("Title")) + ".html"%>' Target="_blank"><%#DataBinder.Eval(Container.DataItem, "ResourceName")%></asp:HyperLink></span>&nbsp;<span
                                    class="cDate"><%#Tools.GetPrettyDate(Convert.ToDateTime( Eval("NewsDate")))%></span>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <p>
                <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
            </p>
            <div class="clear">
            </div>
        </div>

    </div>
</asp:Content>
