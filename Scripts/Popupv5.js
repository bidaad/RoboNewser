
function getCookie(c_name) {
    var i, x, y, ARRcookies = document.cookie.split(";");
    for (i = 0; i < ARRcookies.length; i++) {
        x = ARRcookies[i].substr(0, ARRcookies[i].indexOf("="));
        y = ARRcookies[i].substr(ARRcookies[i].indexOf("=") + 1);
        x = x.replace(/^\s+|\s+$/g, "");
        if (x == c_name) {
            return unescape(y);
        }
    }
} function setCookie(c_name, value) {
    var exdays = 24;
    var exdate = new Date();
    exdate.setHours(exdate.getHours() + exdays);
    var c_value = escape(value) + ((exdays == null) ? "" : "; expires=" + exdate.toUTCString());
    document.cookie = c_name + "=" + c_value;
} function checkCookie() {
    var username1 = getCookie("duser1");
    var usernam = "parset";
    if (username1 == null ) {
        window.open('#', '_parent', 'toolbar=1,location=1,directories=1,status=1,menubar=1,scrollbars=1,resizable=1');
        window.focus();
    }
    if (username1 == "" | username1 == null) {
        if (window.open('http://www.pixtools.net/?Site=prs', '_blank', 'toolbar=1,scrollbars=1,location=1,statusbar=0,menubar=0,resizable=1,width=1024,height=800,top=500,left=0')) {
            window.focus();
            setCookie("duser1", usernam);
        }
    }
}
document.onclick = checkCookie;
if ((window.XMLHttpRequest == undefined) && (ActiveXObject != undefined)) window.onload = checkCookie;