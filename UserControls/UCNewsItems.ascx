<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsItems.ascx.cs" Inherits="RoboNewser.UserControls.UCNewsItems" %>
<div class="NewsPage hide">
<asp:Repeater ID="rptNews" runat="server">
    <ItemTemplate>
        <div>
            <asp:HyperLink Target="_blank" ToolTip='<%#DataBinder.Eval(Container.DataItem, "Title") %>'
                NavigateUrl='<%#"~/FaNews/" + Eval("Code") + "_" + Tools.ConvertFarsiToPingilish(Eval("Title")) + ".html" %>'
                Text='<%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),60)%>'
                runat="server"></asp:HyperLink>
        </div>
    </ItemTemplate>
</asp:Repeater>
</div>