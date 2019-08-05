<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/RootBulk.Master"
    CodeBehind="ShowExternalNews.aspx.cs" Inherits="RoboNewser.News.ShowExternalNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CP1" runat="Server">
    <AKP:MsgBox ID="msgText" runat="server" />
    <iframe class="resize-to-window" scrolling="auto" frameborder="0" id="iframe" src="<%=NewsUrl %>"
        allowtransparency="true" style="width: 100%; height: 100%;"></iframe>
    
    <div class="Clear">
    </div>
    <script type="text/javascript">
        function CloseSideBar() {
            objSideBar = document.getElementById('SideBar');
            if (objSideBar != null) {
                objSideBar.style.display = 'none';
                var windowWidth = $(window).width();
                $('.resize-to-window').width(windowWidth );
            }


        }
        function resizeToWindow() {
            var windowHeight = $(window).height();
            var windowWidth = $(window).width();

            if ($('.recomended-form')) {
                $('.resize-to-window').height(windowHeight - 105);
                $('.resize-to-window').width(windowWidth - 240);
            }
            else {
                $('.resize-to-window').height(windowHeight - 105);
                $('.resize-to-window').width(windowWidth - 240);
            }

            if ($('.SideBar'))
                $('.SideBar').height(windowHeight - 105);

        }

        //change height when document is ready
        $(function () {
            resizeToWindow();

            //change iframe height whene browser is resize
            $(window).resize(function () {
                resizeToWindow();
            });
        });
        resizeToWindow();

    </script>
</asp:Content>
