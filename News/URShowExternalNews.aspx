<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/RootBulk.Master" CodeBehind="URShowExternalNews.aspx.cs" Inherits="RoboNewser.News.URShowExternalNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <style>
        .holder {

    width: 100%;
    height: 100%;
    position: absolute;
    top: 0px;
    left: 0px;
    right: 0px;
    bottom: 0px;

}
    </style>
    <AKP:MsgBox ID="msgText" runat="server" />
    <div class="holder">
   <iframe class="frame" scrolling="auto" frameborder="0" id="iframe" src="<%=NewsUrl %>" allowtransparency="true"  height="100%" width="100%"></iframe>
  
</div>​
    
    
    <div class="Clear">
    </div>
    
</asp:Content>
