<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAlireza.aspx.cs" Inherits="Parsetv91._1.TestAlireza" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblResponse" runat="server" Text="Label"></asp:Label>
    <asp:ImageButton ImageUrl="~/images/site/ContinuePay.png" ID="btnPayCost" OnClientClick="HideAndShowLoading(this);"
                                                        runat="server" Text="پرداخت" 
            onclick="btnPayCost_Click"  />
    </div>
    </form>
</body>
</html>
