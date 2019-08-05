<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Main.master" EnableEventValidation="false" CodeBehind="UserProfiles.aspx.cs" Inherits="WebApp.Admin.Users.UserProfiles" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" runat="Server">

    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        
        <asp:Repeater ID="rptUsers" OnItemCommand="HandleRepeaterCommand" runat="server">
            <ItemTemplate>
                <div>
                    <asp:Label runat="server" ID="lblStatus" Text=<%#GetStatusName( DataBinder.Eval(Container.DataItem, "HCPicStatusCode"))%>></asp:Label>
                    
                    <img src="https://www.robonewser.com/Files/Users/<%#DataBinder.Eval(Container.DataItem, "PicFile")%>" />
                    <asp:Button ID="btnPic" UserCode=<%#DataBinder.Eval(Container.DataItem, "Code")%> runat="server" CommandName="ActivatePic" Text="تایید" />
                    <asp:Button ID="btnDelPic" UserCode=<%#DataBinder.Eval(Container.DataItem, "Code")%> runat="server" CommandName="DeletePic" Text="حذف عکس" />
                </div>
                <div style="height:15px;"></div>
            </ItemTemplate>
        </asp:Repeater>
        </ContentTemplate>
        </asp:UpdatePanel>
        <Tlb:PagerToolbar runat="server" ID="pgrToolbar" />
    </div>

</asp:Content>
