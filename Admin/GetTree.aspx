<%@ Page Language="C#" AutoEventWireup="true" Inherits="GetTree" Codebehind="GetTree.aspx.cs" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tree</title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadTreeView ID="RadTree1" EnableViewState="false" runat="server" Skin="WebBlue"
            ImagesBaseDir="~/Images/TreeView/Outlook" AfterClientClick="SelectNode" ShowLineImages="true"
            ExpandDelay="3" Style="direction: rtl; text-align: right;" >
        </telerik:RadTreeView>
    </div>
    </form>
        <script language="javascript" type="text/javascript">
function SelectNode(node)
{

    NodeCode = node.Value
    NodeText = node.Text
    opener.aspnetForm.<%=FFC%>.value = NodeCode;
    opener.aspnetForm.<%=FFN%>.value = NodeText;
    window.close();

}
    
    </script>
</body>
</html>
