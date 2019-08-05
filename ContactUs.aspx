<%@ Page Language="C#" MasterPageFile="~/Root1.master" AutoEventWireup="true" Inherits="ContactUs"
    Title="Contact us" CodeBehind="ContactUs.aspx.cs" %>

<%@ Register Src="~/UserControls/Toolbar.ascx" TagName="Toolbar" TagPrefix="Tlb" %>
<%@ Register Src="~/UserControls/PagerToolbar.ascx" TagName="PagerToolbar" TagPrefix="Tlb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="RoundBorder1">
        <div class="CatHeaderCont">
                <h3 class="CatHeader">
                    <asp:Label ID="lblCatTitle"  Text="Contact Us"
                        runat="server"></asp:Label>
                </h3>
            </div>
            <div class="clear">
            </div>
        
        <div>
            <AKP:MsgBox ID="msgText" runat="server" />
            <div class="RoboNewserList">
                <div class="Marginer1">
                    <div class="Box3">
                        
                        <div class="Clear">
                        </div>
                        <div class="Marginer2">
                            
                            <asp:Panel ID="pnlSend" runat="server">
                                <div style="text-align: right">
                                    <div class="FormRow">
                                        <div class="FormList">
                                           
                                            <asp:TextBox ID="txtName" placeholder="Name" CssClass="form-control" Width="300" runat="server"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtName"
                                                runat="server" ErrorMessage="Please enter name"></asp:RequiredFieldValidator>
                                        </div>
                                        
                                    </div>
                                    <div class="FormRow">
                                        <div class="FormList">
                                           
                                            <asp:TextBox ID="txtEmail" placeholder="Email" CssClass="form-control" Width="300" SkinID="English" runat="server"></asp:TextBox>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" ControlToValidate="txtEmail"
                                                runat="server" ErrorMessage="Please enter email"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" Display="Dynamic"
                                                runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                                ControlToValidate="txtEmail" ValidationGroup="Invitation" ErrorMessage="ایمیل معتبر نیست"></asp:RegularExpressionValidator>
                                        </div>
                                        
                                    </div>
                                    <div class="FormRow">
                                        <div class="FormList">
                                            
                                            <asp:TextBox ID="txtComment" placeholder="Comment" CssClass="form-control" TextMode="MultiLine" Width="300" Rows="7" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator2" ControlToValidate="txtComment"
                                                runat="server" ErrorMessage="Please enter comment"></asp:RequiredFieldValidator>
                                        </div>

                                    </div>
                                    <div class="Clear">
                                    </div>
                                    <div class="FormRow">
                                        <div class="FormList">
                                            <div style="text-align: right">
                                                <telerik:RadCaptcha ID="RadCaptcha1" CssClass="Capt" Width="300" CaptchaImage-ImageCssClass="CaptImg"
                                                    CaptchaTextBoxCssClass="CaptText" runat="server" ErrorMessage="" CaptchaTextBoxLabel="">
                                                </telerik:RadCaptcha>
                                            </div>
                                        </div>
                                        
                                    </div>
                                    <div class="Clear">
                                    </div>
                                    <div style="text-align: left; padding-left: 150px; padding-top: 5px;">
                                        <asp:LinkButton ID="btnSend" CssClass="btn btn-warning" Text="Submit" runat="server" OnClick="btnSend_Click"></asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="Clear">
    </div>
</asp:Content>
