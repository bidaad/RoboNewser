<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_TextLinks"
    CodeBehind="TextLinks.ascx.cs" %>
<div>
    <asp:Repeater ID="rptTextAds" EnableViewState="false"
        runat="server">
        <HeaderTemplate>
            <div class="cUserADTopHead">
                <div class="CloseBox" onclick="CloseBox(this)">
                </div>
                تبلیغات
            </div>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="TextADItem">
                <div class="ADHead" style="color: #<%#GetColor()%>"><a onmouseover="window.status='http://' + '<%#DataBinder.Eval(Container.DataItem, "Link")%>';" onmousedown="window.status=''" href="http://<%#DataBinder.Eval(Container.DataItem, "Link")%>" target="_blank" title="<%#DataBinder.Eval(Container.DataItem, "Title") %>" onclick="GoToPage('<%#DataBinder.Eval(Container.DataItem, "Code")%>')"><%#Tools.ShowBriefText(DataBinder.Eval(Container.DataItem, "Title"),30)%></a></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="clear">
</div>
