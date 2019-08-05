<%@ Page Title="" Language="C#" MasterPageFile="~/RootNoCol.master" AutoEventWireup="true"
    Inherits="News_Resources" CodeBehind="Resources.aspx.cs" %>

<%@ Register Src="~/UserControls/UCNewsFeedTool.ascx" TagName="UCNewsFeedTool" TagPrefix="UCNewsFeed" %>
<%@ Register Src="~/UserControls/Menu.ascx" TagName="Menu" TagPrefix="MNU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">


    <div class="row">
        <div class="col-md-3">
            <div class="WinRadiusGray">
                <MNU:Menu runat="server" />
            </div>
            <div class="WinRadiusGray">
                <UCNewsFeed:UCNewsFeedTool ID="UCNewsFeedTool1" runat="server" />
            </div>

        </div>
        <div class="col-md-9">
            <div class="panel">
                <div class="heading">
                    <asp:Label ID="lblTitle" runat="server" Text="سایتهای خبری تحت پوشش"></asp:Label>
                </div>
                <div class="ContResources Padder10">
                    <asp:DataList ID="dtlResources" CssClass="tblResources" RepeatDirection="Horizontal"
                        RepeatColumns="3" runat="server">
                        <ItemTemplate>
                            <div>
                                <a href="Resources/<%#DataBinder.Eval(Container.DataItem, "Code")%>.htm">
                                    <%#DataBinder.Eval(Container.DataItem, "Name")%></a>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>

            </div>
        </div>

    </div>

</asp:Content>

