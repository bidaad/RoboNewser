var SiteDomain = '/'
function opacity(id, opacStart, opacEnd, millisec) {
	//speed for each frame
	var speed = Math.round(millisec / 100);
	var timer = 0;

	//determine the direction for the blending, if start and end are the same nothing happens
	if(opacStart > opacEnd) {
		for(i = opacStart; i >= opacEnd; i--) {
			setTimeout("changeOpac(" + i + ",'" + id + "')",(timer * speed));
			timer++;
		}
	} else if(opacStart < opacEnd) {
		for(i = opacStart; i <= opacEnd; i++)
			{
			setTimeout("changeOpac(" + i + ",'" + id + "')",(timer * speed));
			timer++;
		}
	}
}

//change the opacity for different browsers
function changeOpac(opacity, id) {
	var object = document.getElementById(id).style; 
	object.opacity = (opacity / 100);
	object.MozOpacity = (opacity / 100);
	object.KhtmlOpacity = (opacity / 100);
	object.filter = "alpha(opacity=" + opacity + ")";
}

function shiftOpacity(id, millisec) {
	//if an element is invisible, make it visible, else make it ivisible
	if(document.getElementById(id).style.opacity == 0) {
		opacity(id, 0, 100, millisec);
	} else {
		opacity(id, 100, 0, millisec);
	}
}

function blendimage(divid, imageid, imagefile, millisec) {
	var speed = Math.round(millisec / 100);
	var timer = 0;
	
	//set the current image as background
	document.getElementById(divid).style.backgroundImage = "url(" + document.getElementById(imageid).src + ")";
	
	//make image transparent
	changeOpac(0, imageid);
	
	//make new image
	document.getElementById(imageid).src = imagefile;

	//fade in image
	for(i = 0; i <= 100; i++) {
		setTimeout("changeOpac(" + i + ",'" + imageid + "')",(timer * speed));
		timer++;
	}
}

function currentOpac(id, opacEnd, millisec) {
	//standard opacity is 100
	var currentOpac = 100;
	
	//if the element has an opacity set, get it
	if(document.getElementById(id).style.opacity < 100) {
		currentOpac = document.getElementById(id).style.opacity * 100;
	}

	//call for the function that changes the opacity
	opacity(id, currentOpac, opacEnd, millisec)
}

function FadeIn(ID)
{
    document.getElementById(ID).className = 'ToolbarContainerVis';
    opacity(ID, 0, 100, 500)
}

function FadeOut(ID)
{
    document.getElementById(ID).className = 'ToolbarContainer';
    opacity(ID, 100, 0, 500)
}

function CloseWin(Obj)
{
    FadeOut(Obj.parentNode.id);
    //Obj.parentNode.className = 'HideDiv1';
}

function OpenAlbum(AlbumCode)
{
    Domain = '';
    Domain = 'https://www.robonewser.com/Music/';
    window.open(Domain + 'PlayMusic.aspx?Code=' + AlbumCode , 'Player', 'width=750,height=550');
}

function LoadBanner() {
    try {
        if (checkVersion()) {
            obhMainContent = document.getElementById("MainContent").childNodes[1];
            BannerTag = "<div class='Marginer2'><a href='https://www.robonewser.com/?Ref=RoboNewser' target='_blank'><div class='BisstonBanner1'></div></a></div><div class='Clear'></div><br>"
            obhMainContent.innerHTML = BannerTag + obhMainContent.innerHTML;
        }
    }
    catch (e) {
    }
}

function getInternetExplorerVersion()
// Returns the version of Internet Explorer or a -1
// (indicating the use of another browser).
{
    var rv = -1; // Return value assumes failure.
    if (navigator.appName == 'Microsoft Internet Explorer') {
        var ua = navigator.userAgent;
        var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
        if (re.exec(ua) != null)
            rv = parseFloat(RegExp.$1);
    }
    return rv;
}
function checkVersion() {
    var msg = "You're not using Internet Explorer.";
    var ver = getInternetExplorerVersion();

    if (ver > -1) {
        return true;
    }
    else
        return false;
    alert(msg);
}

function IsOnlyNumber() {

    var returnValue = false;
    var keyCode = (window.event.which) ? window.event.which : window.event.keyCode;
    if (((keyCode >= 48) && (keyCode <= 57)) ||
(keyCode == 8) ||
(keyCode == 9) ||
(keyCode == 46) ||
(keyCode == 45) ||
(keyCode == 13))
        returnValue = true;

    if (window.event.returnValue)
        window.event.returnValue = returnValue;
    return returnValue;
}
function IsOnlyNumberAndSlash() {
    var returnValue = false;
    var keyCode = (window.event.which) ? window.event.which : window.event.keyCode;
    if (((keyCode >= 47) && (keyCode <= 57)) ||
(keyCode == 8) ||
(keyCode == 9) ||
(keyCode == 13))
        returnValue = true;

    if (window.event.returnValue)
        window.event.returnValue = returnValue;

    return returnValue;
}

function GoToPage(ADSCode)
{
    try{
        Url = 'https://www.robonewser.com/LogBannerClick.aspx?Code=' + ADSCode;
        startRequest(Url,null,'GET',null);
    }
    catch(e)
    {
    }
}

var http_request = null;
function startRequest(url, Func, Method, Param) { 
    if (window.XMLHttpRequest) { 
       http_request = new XMLHttpRequest(); 
    } 
    else if (window.ActiveXObject) { 
       http_request = new ActiveXObject('Microsoft.XMLHTTP'); 
    } 
    if (url.indexOf("?") == -1)
        url = url + '?rnd=' + Math.random();
    else
        url = url + '&rnd=' + Math.random();
    //alert(url)
    http_request.onreadystatechange = Func;
    http_request.open(Method, url, true); 
    if( Method == 'GET')
       http_request.send(null); 
    else
       http_request.send(Param); 
} 

function CloseBox(objDiv)
{
    objDiv.parentNode.parentNode.style.display = 'none';
}
function PrintPage(btnObj) {
    window.print();
}

function ChangeStar(objLI) {
    objUL = objLI.parentNode;

    Index = 0;
    for (i = 0; i < objUL.childNodes.length; i++) {
        objUL.childNodes[i].className = "StarFull";
        Index++;
        if (objLI == objUL.childNodes[i])
            break;
    }
    for (i = Index; i < objUL.childNodes.length; i++) {
        objUL.childNodes[i].className = "StarHalf";

    }

}

function RestoreStars(objStars) {
    objOnStars = objStars.childNodes[0].childNodes[0];
    objOffStars = objStars.childNodes[1].childNodes[0];

    for (i = 0; i < objOnStars.childNodes.length; i++) {
        objOnStars.childNodes[i].className = "StarFull";
    }
    for (i = 0; i < objOffStars.childNodes.length; i++) {
        objOffStars.childNodes[i].className = "StarHalf";
    }
}


function toggle(div_id) {
    var el = document.getElementById(div_id);
    if (el.style.display == 'none') { el.style.display = 'block'; }
    else { el.style.display = 'none'; }
}
function blanket_size(popUpDivVar) {
    if (typeof window.innerWidth != 'undefined') {
        viewportheight = window.innerHeight;
    } else {
        viewportheight = document.documentElement.clientHeight;
    }
    if ((viewportheight > document.body.parentNode.scrollHeight) && (viewportheight > document.body.parentNode.clientHeight)) {
        blanket_height = viewportheight;
    } else {
        if (document.body.parentNode.clientHeight > document.body.parentNode.scrollHeight) {
            blanket_height = document.body.parentNode.clientHeight;
        } else {
            blanket_height = document.body.parentNode.scrollHeight;
        }
    }
    var blanket = document.getElementById('blanket');
    blanket.style.height = blanket_height + 'px';
    var popUpDiv = document.getElementById(popUpDivVar);
    popUpDiv_height = blanket_height / 2 - 150; //150 is half popup's height
    //popUpDiv.style.top = popUpDiv_height + 'px';
    popUpDiv.style.top = '200px';
}
function window_pos(popUpDivVar) {
    if (typeof window.innerWidth != 'undefined') {
        viewportwidth = window.innerHeight;
    } else {
        viewportwidth = document.documentElement.clientHeight;
    }
    if ((viewportwidth > document.body.parentNode.scrollWidth) && (viewportwidth > document.body.parentNode.clientWidth)) {
        window_width = viewportwidth;
    } else {
        if (document.body.parentNode.clientWidth > document.body.parentNode.scrollWidth) {
            window_width = document.body.parentNode.clientWidth;
        } else {
            window_width = document.body.parentNode.scrollWidth;
        }
    }
    var popUpDiv = document.getElementById(popUpDivVar);
    window_width = window_width / 2 - 150; //150 is half popup's width
    popUpDiv.style.left = window_width + 'px';
}
function popup(windowname) {
    blanket_size(windowname);
    window_pos(windowname);
    toggle('blanket');
    toggle(windowname);
}
function ShowKeywords(objButton, objID, BriefDiv) {
    objDiv = document.getElementById(objID)
    objBriefDiv = document.getElementById(BriefDiv)

    if (objDiv.className == 'cHidden') {
        objBriefDiv.className = 'cHidden';
        objDiv.className = 'cVisible'
        objButton.className = 'MinusButton'
    }
    else {
        objBriefDiv.className = 'cVisible';
        objDiv.className = 'cHidden'
        objButton.className = 'PlusButton'
    }

}

function SelectText(objTextArea) {
    objTextArea.focus();
    objTextArea.select();
}

function ChangeScript(SelectObj, ComboType) {
    if (ComboType == 'Cat') {
        if (SelectObj.value == '0')
            document.getElementById('RoboNewserScript').value = '<script type="text/javascript" src="https://www.robonewser.com/Feed/"></script>'
        else
            document.getElementById('RoboNewserScript').value = '<script type="text/javascript" src="https://www.robonewser.com/Feed/?c=' + SelectObj.value + '"></script>'
    }
    else if (ComboType == 'Res') {
        if (SelectObj.value == '0')
            document.getElementById('RoboNewserScript').value = '<script type="text/javascript" src="https://www.robonewser.com/Feed/"></script>'
        else
            document.getElementById('RoboNewserScript').value = '<script type="text/javascript" src="https://www.robonewser.com/Feed/?r=' + SelectObj.value + '"></script>'
    }
}
function Hide(obj) {
    obj.style.display = 'none'
}

function ShowLoading(objButton) {
    objButton.parentNode.childNodes[0].innerHTML = "<img src='../images/Loading2.gif' />";
}

function getObj(objID) {
    if (document.getElementById) { return document.getElementById(objID); }
    else if (document.all) { return document.all[objID]; }
    else if (document.layers) { return document.layers[objID]; }
}
function isChild(s, d) {
    while (s) {
        if (s == d)
            return true;
        s = s.parentNode;
    }
    return false;
}

function CheckBrowser() {
    if (navigator.userAgent.indexOf("Firefox") != -1)
        return "FireFox";
    else
        return "IE";
}


function getSelectedText(e) {

    var evt = window.event || e
    var text = "";
	CSE=e.target?evt.target:e.srcElement;
	if( getObj('PanelSendSMS'))
	{
	    if (isChild(CSE, getObj('PanelSendSMS')))
	        return;
    }

	if (getObj('dialog')) {
	    if (isChild(CSE, getObj('dialog')))
	        return;
	}


    if (typeof window.getSelection != "undefined") {
        text = window.getSelection().toString();
    } else if (typeof document.selection != "undefined" && document.selection.type == "Text") {
        text = document.selection.createRange().text;
    }
    return text;
}

function doSomethingWithSelectedText(e) {
    var evt = window.event || e
    var selectedText = getSelectedText(evt);
    if (selectedText) {
        if (selectedText.length < 5)
            return;
        //$(".BackLoading").fadeIn();

        $("#dialog").dialog({
            autoOpen: false,
            resizable: false,
            height: 550,
            width: 600,
            show: 'puff',
            hide:'scale',
            buttons: {
                
            },
            close: function () {

            }
        });

        $("#SendSMSTools").show();
        $("#SendInfo").show();
        $("#BigMessage").hide();
        $("#dialog").dialog("open");
        ShowSMSPanel(selectedText);
    }
}

function DoSelect(selectedText) {
    if (selectedText) {
        if (selectedText.length < 5)
            return;
        //$(".BackLoading").fadeIn();

        $("#dialog").dialog({
            autoOpen: false,
            resizable: false,
            height: 550,
            width: 600,
            show: 'puff',
            hide: 'scale',
            buttons: {

            },
            close: function () {

            }
        });

        $("#SendSMSTools").show();
        $("#SendInfo").show();
        $("#BigMessage").hide();
        $("#dialog").dialog("open");
        ShowSMSPanel(selectedText);
    }
}



function ShowSMSPanel(selectedText) {
    try {
        document.getElementById('PanelSendSMS').className = 'PanelSendSMS';
        document.getElementById('SMSInnerArea').innerHTML = selectedText;

        if (CheckBrowser() == "FireFox")
            SMSBody = document.getElementById('SMSInnerArea').innerHTML;
        else
            SMSBody = document.getElementById('SMSInnerArea').innerText;

        SMSBodyLen = parseInt(SMSBody.length, 10);
        var SMSCount = SMSBodyLen / 70;
        SMSCount = parseInt(SMSCount, 10) + 1;
        SendCostGuest = SMSCount * 70;
        if (SendCostGuest < 100)
            SendCostGuest = 100;
        document.getElementById('SMSSendCostGuest').innerHTML = SendCostGuest;

        SendCostUser = SMSCount * 40;
        if (SendCostUser < 100)
            SendCostUser = 100;
        document.getElementById('SMSSendCostUser').innerHTML = SendCostUser;


        //alert(document.getElementById('SMSInnerArea').innerText);
        //$("#SMSInnerArea").toggle("highlight");
//        document.getElementById('PanelSendSMS').style.top = Y + 13 + document.body.scrollTop + 'px';

    }
    catch (e) {
    }
}

function ReqSendSMS() {
    $("#btnSendSMS").fadeOut();
    if (CheckBrowser() == "FireFox") 
        SMSBody = document.getElementById('SMSInnerArea').innerHTML;
    else
        SMSBody = document.getElementById('SMSInnerArea').innerText;

    strToCellNo = document.getElementById('ToCellNo').value;

    Url = 'https://www.robonewser.com/ReqSendSMS.aspx?ToCellNo=' + strToCellNo + '&Body=' + escape(SMSBody);
    startRequest(Url, SMSResult, 'GET', null);
}

function SMSResult() {
    if (http_request != null) {
        if (http_request.readyState == 4) {
            if (http_request.status == 200) {
                $("#btnSendSMS").fadeIn();

                result = http_request.responseText
                if (result == 'REDIRECTTOPAY') {
                    window.location.href = 'https://www.robonewser.com/Users/PaySMSStep1.aspx';
                    return;
                }
                if (result.substring(0, 2) == 'OK') {
                    OKMessage = result.substring(3, result.length )
                    $("#SendSMSTools").fadeOut();
                    document.getElementById('BigMessage').innerHTML = 'اس ام اس با موفقیت ارسال شد.' + '<br />' + ' موجودی بعد از ارسال اس ام اس: ' + OKMessage + ' ریال ';
                    $("#BigMessage").show("fadein");
                    $("#SendInfo").hide("slow");
                }
                else
                    alert(result);
            }
        }
    }
}

function CloseSMSPanel() {
    document.getElementById('PanelSendSMS').className = 'cHiddenPanel';
}

//document.write("<div id=\"dialog\" title=\"ارسال اس ام اس\"><div class=\"cHiddenPanel\" id=\"PanelSendSMS\"><div  id=\"SMSInnerArea\"></div><div class=\"SMSButtons\"><table class=\"tblSMSButton\"><tr><td colspan=\"2\">شماره مقصد:<input type=\"text\" id=\"ToCellNo\"></td></tr><tr><td><input type=\"button\" id=\"btnSendSMS\" value=\"ارسال\" onclick=\"ReqSendSMS()\" ></td><td></td></tr></table></div></div></div>");



function HideButton(ObjButton) {
    ObjButton.style.display = 'none';
}

function HideAndShowLoading(ObjButton) {
    ObjButton.style.display = 'none';
    document.getElementById('BankLoading').innerHTML = 'در حال اتصال به بانک'
    return true;
}



(function ($) {
    $.fn.blink = function (options) {
        var defaults = { delay: 500 };
        var options = $.extend(defaults, options);

        return this.each(function () {
            var obj = $(this);
            setInterval(function () {
                if ($(obj).css("visibility") == "visible") {
                    $(obj).css('visibility', 'hidden');
                }
                else {
                    $(obj).css('visibility', 'visible');
                }
            }, options.delay);
        });
    }
} (jQuery))

function submitSearch()
{
    objKeyword = document.getElementById('universalSearchBox');
    if(objKeyword != null && objKeyword != undefined)
    {
        Url = 'http://www.google.com/search?hl=en&tbo=d&output=search&sclient=psy-ab&q=site%3Awww.RoboNewser.com+' + objKeyword.value
        window.location.href= Url;
    }
}
function ShowPopupLink() {
    Link = window.location.href;
    window.open('https://www.robonewser.com/SendLink.aspx?Link=' + escape(Link), 'SendLink', 'width=500,height=400')
}

function OpenShop() {
    if (CheckBrowser() == "FireFox")
        window.open('http://www.pixtools.net', '_blank')
}

function AjaxTextNewsListResult() {
    if (http_request != null) {
        if (http_request.readyState == 4) {
            if (http_request.status == 200) {
                result = http_request.responseText
                document.getElementById("objTextNewsList").innerHTML = result;
            }
        }
    }
}

var http_requestTicker = null;
function startTickerRequest(url, Func, Method, Param) {
    if (window.XMLHttpRequest) {
        http_requestTicker = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        http_requestTicker = new ActiveXObject('Microsoft.XMLHTTP');
    }
    if (url.indexOf("?") == -1)
        url = url + '?rnd=' + Math.random();
    else
        url = url + '&rnd=' + Math.random();
    http_requestTicker.onreadystatechange = Func;
    http_requestTicker.open(Method, url, true);
    if (Method == 'GET')
        http_requestTicker.send(null);
    else
        http_requestTicker.send(Param);
}
function AjaxNewsTickerResult() {
    if (http_requestTicker != null) {
        if (http_requestTicker.readyState == 4) {
            if (http_requestTicker.status == 200) {
                result = http_requestTicker.responseText
                document.getElementById("js-news").innerHTML = result;
                $(function (b) {
                    $('#js-news').ticker({
                        speed: 0.10,
                        htmlFeed: true,
                        controls: false,
                        fadeInSpeed: 600,
                        displayType: 'fade',
                        direction: 'rtl',
                        titleText: ''
                    });
                });

            }
        }
    }
}

var http_requestRandSMS = null;
function startRandSMSRequest(url, Func, Method, Param) {
    if (window.XMLHttpRequest) {
        http_requestRandSMS = new XMLHttpRequest();
    }
    else if (window.ActiveXObject) {
        http_requestRandSMS = new ActiveXObject('Microsoft.XMLHTTP');
    }
    if (url.indexOf("?") == -1)
        url = url + '?rnd=' + Math.random();
    else
        url = url + '&rnd=' + Math.random();
    http_requestRandSMS.onreadystatechange = Func;
    http_requestRandSMS.open(Method, url, true);
    if (Method == 'GET')
        http_requestRandSMS.send(null);
    else
        http_requestRandSMS.send(Param);
}
function AjaxRandSMSResult() {
    if (http_requestRandSMS != null) {
        if (http_requestRandSMS.readyState == 4) {
            if (http_requestRandSMS.status == 200) {
                result = http_requestRandSMS.responseText
                document.getElementById("RandSMSPanel").innerHTML = result;
                $("div#RandSMS").jContent({
                    orientation: 'vertical',
                    easing: "easeOutCirc",
                    duration: 5500,
                    width: 148,
                    height: 232,
                    auto: true,
                    pause_on_hover: true,
                    direction: 'next',
                    pause: 9500
                });

            }
        }
    }
}



function SearchNews() {
    objtxtKeyword = document.getElementById("txtKeyword");
    window.location.href = SiteDomain + 'News/SearchResults.aspx?Keyword=' + objtxtKeyword.value;
}


function showPass(b) {
    var a = b.closest("div").find("input");
    a.get(0).type = "text";
    b.css("background-color", "#FCEC63")
}
function hidePass(b) {
    var a = b.closest("div").find("input");
    a.get(0).type = "password";
    b.css("background-color", "")
};


if (self != top) {
    top.location.href = self.location;
}









var SubMenuLoaded = 0;
var StaticShow = 0;

$(document).ready(function () {
    $(".VMenuItem").mouseleave(function () {
        if (SubMenuLoaded != 1)
            $(".VMenuItem").removeClass('MenuSelected');
    });
    $(".SubMenu").mouseleave(function () {
        SubMenuLoaded = 0;
        $(".VMenuItem").removeClass('MenuSelected');
    });


    $("#mnuMainMenu").hoverIntent(function () {
        //alert(6);
        $(".VMenuItem").removeClass('MenuSelected');
        $("#mnuMainMenu").addClass('MenuSelected');
        $(".SubMenu").addClass('hide');
        $("#submenuMainMenu").removeClass('hide');
        $("#submenuMainMenu").fadeIn();

        SubMenuLoaded = 1;
    });

    $("#mnuMainMenu").click(function () {
        if (SubMenuLoaded == 0) {
            $(".VMenuItem").removeClass('MenuSelected');
            $("#mnuMainMenu").addClass('MenuSelected');
            $(".SubMenu").addClass('hide');
            $("#submenuMainMenu").removeClass('hide');
            $("#submenuMainMenu").fadeIn();

            SubMenuLoaded = 1;
        }
        else {
            $(".SubMenu").addClass('hide');
            $(".SubMenu").fadeOut();
            SubMenuLoaded = 0;
            $(".VMenuItem").removeClass('MenuSelected');
        }
    });

    $(".SubMenuCont").mouseleave(function () {
        $(".SubMenu").addClass('hide');
        $(".SubMenu").fadeOut();
        SubMenuLoaded = 0;
        $(".VMenuItem").removeClass('MenuSelected');

    });


    $(".MenuContent").mouseleave(function () {
        $("#submenuCellPhone").addClass('hide');
        $("#submenuCellPhone").fadeOut();
    });

    $(".VerMenu").mouseleave(function () {
        if (StaticShow != 1)
            $(".MenuContent").addClass('hide');
    });

    $(".VerMenu").mouseenter(function () {
        MainMenuLoaded = 0;
        ToggleMainMenu();
    });

    

});


$(document).click(function () {
    //$(".SubMenu").addClass('hide');
    //$(".VMenuItem").removeClass('MenuSelected');
});

var MainMenuLoaded = 0;
function ToggleMainMenu() {
    if (MainMenuLoaded == 0) {
        $(".MenuContent").removeClass('hide');
        MainMenuLoaded = 1;
    }
    else {
        if (StaticShow != 1) {
            $(".MenuContent").addClass('hide');
            MainMenuLoaded = 0;
        }
    }
}

$(document).ready(function () {


    $('#txtKeyword').keydown(function (event) {
        if (event.keyCode == 13) {
            window.location.href = '/News/SearchResults.aspx?Keyword=' + $('#txtKeyword').val();
            return false;
        }
    });

});
