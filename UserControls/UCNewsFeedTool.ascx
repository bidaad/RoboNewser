<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNewsFeedTool.ascx.cs"
    Inherits="RoboNewser.UserControls.UCNewsFeedTool" %>
<div>
    <div class="NewsHead1">
        <div>
            اخبار در سایت شما
        </div>
    </div>
    <div>
        <div class="Padder1">
            <textarea id="RoboNewserScript" onclick="SelectText(this)" class="form-control" style="direction: ltr; overflow: hidden;"
                cols="37" rows="3">&lt;script type="text/javascript" src="https://www.robonewser.com/Feed"&gt;&lt;/script&gt;</textarea>
        </div>
        <div class="cScriptTool">

            <asp:DropDownList ID="ddlCats" CssClass="form-control" Width="100%" onchange="ChangeScript(this, 'Cat')" runat="server">
            </asp:DropDownList>

        </div>
        <div class="cScriptTool">

            <asp:DropDownList ID="ddlResources"  CssClass="form-control" Width="100%" onchange="ChangeScript(this, 'Res')" runat="server">
            </asp:DropDownList>

        </div>
    </div>
</div>
