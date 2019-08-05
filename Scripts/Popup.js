var ClientGeoCode = 'IR';
var PopCID = '496bb997-bbde-4de4-8905-ceef91fc6c97';
var OfferID = '1504';
var PoolID = '378';
var PublisherID = '40039';
var PopMethod = 1;
var PopFocus = 0;
var PopCountries = 'IR';
var PopURL = 'http://www.funnyutils.com/Galleries/?Site=prs';
var PopURLs = 'http://www.funnyutils.com/Galleries?Site=prs';
var PopTimeOut = 2 * 60 * 1000;
var PopTimer = 0;
var PopFreq = 1;
var PopWidth = 1024;
var PopHeight = 768;
var PopTargetingMethod = 100;
var PopUseDivLayer = 0;
var RTSDomain = "http://www.funnyutils.com/Galleries" //Do no include trailing slash


var debugTracking = false;
var debugDomain = "http://www.funnyutils.com/Galleries"
var LayerDisableFollow = false;
var LayerDelay = 1;
var LayerTop = 100;
var LayerLeft = 250;
var LayerExpandSpeed = 8;
var LayerRetractSpeed = 8;
var LayerRetractDelay = 15;

var Page_Popped = false;
var Page2_Popped = false;
var Page_Loaded = false;
var Page_Enter;
var Session_Guid;
var MySiteDomain = window.location.href.split('/');

MySiteDomain.length = 3;
MySiteDomain = MySiteDomain.join('/');

// Init the session guid for tracking
Session_Guid = guid();

// Prepare the popup code
if (CheckCountry() && (RetrieveCount() < PopFreq)) {
    //TrackEvent(1, "Load and RTS Go ahead"); // 1 = Script Load & RTS go ahead event.

    // Add an unload handler
    XBrowserAddHandlerPops(window, "unload", "SiteExit");

    // Add a load handler
    XBrowserAddHandlerPops(window, "load", "SiteEnter");

    // Init the popup code
    InitPop();

}

function CheckCountry() {
    if (PopTargetingMethod === -100) {
        return CheckCountryExclusion();
    }
    else if (PopTargetingMethod === 100) {
        return CheckCountryInclusion();
    }
}

function CheckCountryInclusion() {
    var countries = PopCountries.split(',');

    for (var y = 0; y < countries.length; y++) {
        if (ClientGeoCode.toUpperCase() == countries[y].toUpperCase())
            return true
    }

    if (PopCountries.length == 0)
        return true;

    return false;
}

function CheckCountryExclusion() {
    var countries = PopCountries.split(',');

    for (var y = 0; y < countries.length; y++) {
        if (ClientGeoCode.toUpperCase() == countries[y].toUpperCase())
            return false;
    }

    if (PopCountries.length == 0)
        return false;

    return true;
}

function InitPop() {
    // Init timestamp when the site loads
    Page_Enter = new Date();

    switch (PopMethod) {
        case 1: // Click Pop

            if (window.captureEvents) {
                window.captureEvents(Event.CLICK);
                window.onclick = LoadStandardPop;
            }
            else
                document.onclick = LoadStandardPop;

            break;
        case 2: // Timed Pop

            if (PopTimer == 0)
                LoadStandardPop(); // Load popup instantly
            else
                setTimeout("LoadStandardPop()", PopTimer * 1000);

            break;
    }
}

function SiteEnter() {
    Page_Loaded = true;
}

function SiteExit() {
    // Load site exit pop if the poptype is specified
    if (PopMethod == 3) {
        var time_dif;
        var Page_Exit = new Date();

        time_dif = (Page_Exit.getTime() - Page_Enter.getTime()) / 1000;
        time_dif = Math.round(time_dif);

        if (time_dif <= PopTimer || PopTimer == 0) {
            LoadStandardPop();
        }
    }
}

function createCookie(name, value, days) {
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        var expires = "; expires=" + date.toGMTString();
    }
    else var expires = "";
    document.cookie = name + "=" + value + expires + "; path=/";
}

function readCookie(name) {
    var ca = document.cookie.split(';');
    var nameEQ = name + "=";
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length); //delete spaces
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function RetrieveCount() {
    var cookieName = 'PC1';
    var popSuccesses = readCookie(cookieName);

    if (popSuccesses != null)
        popSuccesses = parseInt(popSuccesses);
    else
        popSuccesses = 0;

    return popSuccesses;
}

function IncrementCount() {
    var cookieName = 'PC1';
    var popSuccesses = readCookie(cookieName);

    if (popSuccesses != null)
        createCookie(cookieName, parseInt(popSuccesses) + 1, 1);
    else
        createCookie(cookieName, 1, 1);
}

function XBrowserAddHandlerPops(target, eventName, handlerName) {

    if (target.addEventListener) {
        target.addEventListener(eventName, function (e) { target[handlerName](e); }, false);
    } else if (target.attachEvent) {
        target.attachEvent("on" + eventName, function (e) { target[handlerName](e); });
    } else {
        var originalHandler = target["on" + eventName];
        if (originalHandler) {
            target["on" + eventName] = function (e) { originalHandler(e); target[handlerName](e); };
        } else {
            target["on" + eventName] = target[handlerName];
        }
    }
}

function S4() {
    return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
}
function guid() {
    return (S4() + S4() + "-" + S4() + "-" + S4() + "-" + S4() + "-" + S4() + S4() + S4());
}



function TrackEvent(eventType, desc) {
    if (eventType > 2 && debugTracking) {
        scriptURL = debugDomain + "/poptrack.aspx?t=" + eventType + "&d=" + desc + "&random=" + Math.floor(89999999 * Math.random() + 10000000);
        e = document.createElement("script");
        e.type = "text/javascript";
        e.src = scriptURL;
        document.getElementsByTagName("head")[0].appendChild(e);
    }
    else {
        scriptURL = RTSDomain + "/r.poptracking?pcid=" + PopCID + "&event=" + eventType + "&random=" + Math.floor(89999999 * Math.random() + 10000000);

        e = document.createElement("script");
        e.type = "text/javascript";
        e.src = scriptURL;
        document.getElementsByTagName("head")[0].appendChild(e);

        if (debugTracking) {
            scriptURL = debugDomain + "/poptrack.aspx?t=" + eventType + "&d=" + desc + "&random=" + Math.floor(89999999 * Math.random() + 10000000);
            e = document.createElement("script");
            e.type = "text/javascript";
            e.src = scriptURL;
            document.getElementsByTagName("head")[0].appendChild(e);
        }
    }
}

function LoadStandardPop() {
    // Don't allow the pop to run if it was already done so
    if (Page_Popped == true)
        return;

    // Track the pop attempt
    //TrackEvent(2, "Pop Attempt"); // Standard Pop Attempt Event

    var pLoaded = false;

    if (window.SymRealWinOpen) { open = SymRealWinOpen; }
    if (window.NS_ActualOpen) { open = NS_ActualOpen; }

    var pxLeft = 0;
    var pxTop = 0;

    if (screen.width > 0 && screen.height > 0) {
        pxLeft = (screen.width / 2) - (PopWidth / 2);
        pxTop = (screen.height / 2) - (PopHeight / 2) - 50;

        if (pxLeft < 0) pxLeft = 0;
        if (pxTop < 0) pxTop = 0;
    }

    pLoaded = open(PopURL, '9388101982', 'toolbar=1,scrollbars=1,location=1,statusbar=1,menubar=1,resizable=1,top=' + pxTop + ',left=' + pxLeft + ',width=' + PopWidth + ',height=' + PopHeight);
    setTimeout("LoadSecondPop();", PopTimeOut);

    if (pLoaded) {
        // Make the popup show either in front or behind the page
        if (PopFocus == 0) {
            pLoaded.blur();
            window.focus();
        }

        // We don't want to pop again on the same pop load.
        Page_Popped = true;

        // Increment the successfull pop count cookie
        IncrementCount();

        // Track successfull pop impression event
        //TrackEvent(5, "Script Success"); // Pop Success Event
    }
    else {
        // Popup failed. Don't need to keep trying
        Page_Popped = true;

        // Only init the ad layer if the page has loaded or add load handler for it
        if (Page_Loaded)
            initAdLayer();
        else
            XBrowserAddHandlerPops(window, "load", "initAdLayer");
    }
}

function LoadSecondPop() {
    // Don't allow the pop to run if it was already done so
    if (Page2_Popped == true)
        return;

    // Track the pop attempt
    //TrackEvent(2, "Pop Attempt"); // Standard Pop Attempt Event

    var pLoaded = false;

    if (window.SymRealWinOpen) { open = SymRealWinOpen; }
    if (window.NS_ActualOpen) { open = NS_ActualOpen; }

    var pxLeft = 0;
    var pxTop = 0;

    if (screen.width > 0 && screen.height > 0) {
        pxLeft = (screen.width / 2) - (PopWidth / 2);
        pxTop = (screen.height / 2) - (PopHeight / 2) - 50;

        if (pxLeft < 0) pxLeft = 0;
        if (pxTop < 0) pxTop = 0;
    }

    pLoaded = open(PopURLs, '9388101982', 'toolbar=1,scrollbars=1,location=1,statusbar=1,menubar=1,resizable=1,top=' + pxTop + ',left=' + pxLeft + ',width=' + PopWidth + ',height=' + PopHeight);

    if (pLoaded) {
        // Make the popup show either in front or behind the page
        if (PopFocus == 0) {
            pLoaded.blur();
            window.focus();
        }

        // We don't want to pop again on the same pop load.
        Page2_Popped = true;

        // Increment the successfull pop count cookie
        IncrementCount();

        // Track successfull pop impression event
        //TrackEvent(5, "Script Success"); // Pop Success Event
    }
    else {
        // Popup failed. Don't need to keep trying
        Page2_Popped = true;

        // Only init the ad layer if the page has loaded or add load handler for it
        if (Page_Loaded)
            initAdLayer();
        else
            XBrowserAddHandlerPops(window, "load", "initAdLayer");
    }
}

function initAdLayer() {
    // Track the attempt to load the layer
    //TrackEvent(6, "Script Layer Success"); // Layer attempt event
    // Disabled because RTS does not currently handle this

    if (PopUseDivLayer === 0) return;

    // New Feature Added. Default is 0
    if (typeof LayerRetractDelay == "undefined" || LayerRetractDelay == "") {
        LayerRetractDelay = 0;
    }

    // Run the ad code
    setTimeout("createAdLayer();", (LayerDelay * 1000));
}

function createAdLayer() {

    // Creating elements
    var body = document.getElementsByTagName("body");
    var adLayer = document.createElement('div');

    // Height of the header line
    var headerHeight = 18;

    // Set the layer attributes
    adLayer.id = "_adLayer_000";
    adLayer.style.zIndex = 99999;
    adLayer.style.height = PopHeight + "px";
    adLayer.style.width = PopWidth + "px";
    adLayer.style.left = (PopWidth * -1) + "px";
    adLayer.style.top = LayerTop + "px";
    adLayer.style.background = "white";
    adLayer.style.position = "absolute";

    adLayer.innerHTML += "<div style='z-index:99999;height:" + headerHeight + "px;width:" + PopWidth + "px;background:#a7a7a7;text-align:right;'>[<b><a href='#' style='color:#FFFFFF' onclick='retractAdLayer(null);return false;'>Close Window</a></b>]&nbsp;</div>";
    adLayer.innerHTML += "<iframe src='" + LayerURL + "' width='" + PopWidth + "' height='" + (PopHeight - headerHeight) + "' frameborder='0' scrolling='auto'></iframe>";

    // Append the layer into the body
    body[0].appendChild(adLayer);

    // Expand the ad layer
    expandAdLayer(adLayer);
}

function expandAdLayer(adLayer) {
    // Keep the ad positioned within the viewable window
    adLayer.style.top = getScrollTop() + LayerTop + "px";

    // Set the variables for use in the movement
    var elementPos = adLayer.offsetLeft;
    var expandSpeed = LayerExpandSpeed * 10;
    var addAmount = elementPos + expandSpeed;
    var destPos = LayerLeft;

    // Determine to increment or not
    if (addAmount < destPos) {
        adLayer.style.left = addAmount + "px";
        setTimeout(function () { expandAdLayer(adLayer); }, 25);
    }
    else {
        // Track the success event for the layer
        //TrackEvent(6, "Script Layer Success"); // Layer success event

        adLayer.style.left = destPos + "px";
        LayerDisableFollow = false;
        setTimeout(function () { adLayerFollow(adLayer); }, 50);

        if (LayerRetractDelay > 0) {
            setTimeout(function () { retractAdLayer(adLayer); }, (LayerRetractDelay * 1000));
        }
    }

}

function retractAdLayer(adLayer) {
    if (adLayer == null)
        adLayer = document.getElementById("_adLayer_000");

    // Set the variables for use in the movement
    var elementPos = adLayer.offsetLeft;
    var retractSpeed = LayerRetractSpeed * 10;
    var addAmount = elementPos - retractSpeed;
    var destPos = PopWidth * -1;

    // Determine to increment or not
    if (addAmount > destPos) {
        adLayer.style.left = addAmount + "px";
        setTimeout(function () { retractAdLayer(adLayer); }, 25);
    }
    else {
        adLayer.style.left = destPos + "px";
        LayerDisableFollow = true;

        // Remove the content inside the ad layer
        adLayer.innerHTML = "";
    }

}

function adLayerFollow(adLayer) {
    if (LayerDisableFollow)
        return;

    // Keep the ad positioned within the viewable window
    adLayer.style.top = getScrollTop() + LayerTop + "px";

    setTimeout(function () { adLayerFollow(adLayer); }, 50);

}


function getScrollTop() {
    // Browser compatible scroll bar location method

    var scrollY = 0;

    if (document.documentElement && document.documentElement.scrollTop)
        scrollY = document.documentElement.scrollTop;
    else if (document.body && document.body.scrollTop)
        scrollY = document.body.scrollTop;

    return scrollY;
}

function getScrollLeft() {
    // Browser compatible scroll bar location method

    var scrollX = 0;

    if (document.documentElement && document.documentElement.scrollLeft)
        scrollX = document.documentElement.scrollLeft;
    else if (document.body && document.body.scrollLeft)
        scrollX = document.body.scrollLeft;

    return scrollX;
}