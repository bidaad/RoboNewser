<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="UserControls_TextNewsList" Codebehind="TextNewsList.ascx.cs" %>
<div id="objTextNewsList">
</div>
    <script type="text/javascript">
        Url = SiteDomain + "Ajax/AjaxTextNewsList.aspx"
        startRequest(Url, AjaxTextNewsListResult, 'GET', null);
    </script>


