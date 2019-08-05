var CurrentWord = null;
var Path = '';
function DeleteItem(FileName, MasterCode, DelList)
{
	AskResult = confirm("حذف شود ؟")

	if(AskResult){
		window.onbeforeunload = '';
		window.location.href=FileName + '?DelList=' + DelList + '&Code=' + MasterCode
	}
}
function makeRequest(url, Func, Method, Param) { 

   if (window.XMLHttpRequest) { 
       http_request = new XMLHttpRequest(); 
   } 
   else if (window.ActiveXObject) { 
       http_request = new ActiveXObject('Microsoft.XMLHTTP'); 
   } 
   http_request.onreadystatechange = Func;
   http_request.open(Method, url, true); 
   if( Method == 'GET')
       http_request.send(null); 
   else
       http_request.send(Param); 

} 

function IsOnlyNumber()
{

var returnValue = false;
var keyCode = (window.event.which) ? window.event.which : window.event.keyCode;
if ( ((keyCode >= 48) && (keyCode <= 57)) ||
(keyCode == 8) || 
(keyCode == 9) || 
(keyCode == 46) || 
(keyCode == 45) || 
(keyCode == 13) ) 
returnValue = true;

if ( window.event.returnValue )
window.event.returnValue = returnValue;
return returnValue;
}
function IsOnlyNumberAndSlash()
{
var returnValue = false;
var keyCode = (window.event.which) ? window.event.which : window.event.keyCode;
if ( ((keyCode >= 47) && (keyCode <= 57)) ||
(keyCode == 8) || 
(keyCode == 9) || 
(keyCode == 13) ) 
returnValue = true;

if ( window.event.returnValue )
window.event.returnValue = returnValue;

return returnValue;
}


function ConfirmUnload()
{
    event.returnValue = "تغییرات نادیده گرفته شود؟";
}
function GetInfo(InputObj, BaseID)
{
	Code = InputObj.value
	document.body.style.cursor='wait';
	
	// Create an instance of the XML HTTP Request object
	var oXMLHTTP = new ActiveXObject( "Microsoft.XMLHTTP" );
		
	// Prepare the XMLHTTP object for a HTTP POST to our validation ASP page
	var sURL = "../Seminars/GetInfo.asp?Code=" + Code + '&BaseID=' + BaseID
	oXMLHTTP.open( "POST", sURL, false );
	
	// Execute the request
	oXMLHTTP.send();
	
	rsl = oXMLHTTP.responseText
	InputObj.parentNode.parentNode.cells(2).childNodes(0).value = rsl
	if(rsl == 'رکورد مورد نظر یافت نشد')
		InputObj.parentNode.parentNode.cells(1).childNodes(0).value = ''
	document.body.style.cursor='auto';
	
}
function ImgOver(ImgObj)
{
	ImgObj.style.borderWidth = 1
	ImgObj.style.borderColor = 'black'
}
function ImgOut(ImgObj)
{
	ImgObj.style.borderWidth = 0
}

function DoPrint()
{
	window.print()
}
function AskDelete(Code)
{
	AskResult = confirm("رکورد حذف شود؟")
	if(AskResult){
		form1.DelValue.value = Code;
		form1.action = "index.asp"
		form1.submit()
	}
}

function AskDeleteDetail(FromAction, MasterCode, Code)
{
	AskResult = confirm("رکورد حذف شود؟")
	if(AskResult){
		window.onbeforeunload = '';
		form1.DelList.value = Code;
		form1.Code.value = MasterCode ;
		form1.action = FromAction
		form1.submit()
	}
}

function GotoLink(FormAction)
{
	if( FormAction != "undefined")
		form1.action = FormAction
	form1.submit();
}

function GotoUrl(Url)
{
    window.location.href = Url
}

function PickDate(DateFieldName, InitVal, Section)
{
	InitVal = InitVal.replace("/", "");
	InitVal = InitVal.replace("/", "");
	
	X =  window.event.clientX
	Y =  window.event.clientY + 100
	if ( InitVal.length != 8)
		InitVal = '';
	whn = 	window.open('../DatePicker.asp?FFN=' + DateFieldName + '&InitDate=' + InitVal + '&Section=' + Section,'DatePicker','width=200,height=185,menubar=no,status=no,titlebar=no,resizable=no,top=' + Y + ',left=' + X );
}

function UploadPic(FileName)
{
		whList = window.open(FileName + '?' + FieldName + '=' +  Code,'','width=580,height=150,menubar=no,status=no,titlebar=no,resizable=no,top=200,left=150');
}

function ShowTree(FileName, BaseID, FFN, InitCode)
{
		whList = window.open(FileName + '?BaseID=' + BaseID + '&FFN=' + FFN + '&InitGroup=' + InitCode,'PersonTree','width=580,height=450,menubar=no,status=no,titlebar=no,resizable=no,top=200,left=150');
}

function ShowFile(FileName, FieldName, Code)
{
		whList = window.open(FileName + '?' + FieldName + '=' +  Code,'','width=620,height=450,menubar=no,status=no,titlebar=no,resizable=no,scrollbars,top=200,left=150');
}

function ShowFile3(FileName, FieldName, Code)
{
		whList = window.open(FileName + '?' + FieldName + '=' +  Code,'','width=620,height=450,menubar=yes,status=no,titlebar=no,resizable=no,scrollbars,top=200,left=150');
}

function ShowFile2(PathName)
{
	whList = window.open(PathName,'','width=620,height=450,menubar=no,status=no,titlebar=no,resizable=no,scrollbars,top=200,left=150');
}




function ShowList(FileName, BaseID, FilterCols, FilterVals)
{
	if(FilterCols == undefined)
		FilterCols = ""
	if(FilterVals == undefined)
		FilterVals = ""
		whList = window.open(FileName + '?BaseID=' + BaseID + '&FN=' + FilterCols + '&FV=' + FilterVals,'','width=500,height=450,menubar=no,status=no,titlebar=no,resizable=no,top=200,left=150');
}

function GetLeftCenter(WinHeight, WinHeight)
{

	if (screen.width == 1024)
	{
		RTop = (768 - WinHeight) / 2
		Result = "top=" + RTop + ",left=213"
	}
	else
	{
		RTop = (600 - WinHeight) / 2
		Result = "top=" + RTop + ",left=20"
	}
		return Result
}




function ShowPics(BaseID, MasterID, MediaType)
{
		whList = window.open('Album.asp?BaseID=' + BaseID + '&MasterCode=' + MasterID + '&MediaType=' + MediaType,'','width=600,height=510,menubar=no,status=no,titlebar=no,resizable=no,top=100,left=150');
}

function DoMask(MaskFormat, str,textbox,loc,delim)
{
//	try{
	
	DoNothing = 0

	CurrentPos = textbox.value.length;
	var locs = loc.split(',');	

	KeyCode = event.keyCode
	if (!window.event.shiftKey && !window.event.ctrlKey && !window.event.altKey) {
		if ((KeyCode > 47 && KeyCode < 58) || (KeyCode > 95 && KeyCode < 106)) {
			MaxL = MaskFormat.length + locs.length 
			if (textbox.value.length >= MaxL) {
					event.returnValue = false
					return false;
			}
			if (KeyCode > 95) KeyCode -= (95-47);
		} else if (KeyCode != 8 && KeyCode != 46 ) {
			event.returnValue = false
			return false;
		}
	}

	CurrentChar = String.fromCharCode(KeyCode)

	for (var i = 0; i <= locs.length; i++){
		for (var k = 0; k <= str.length; k++){
		 if (k == locs[i]){
		  if (str.substring(k, k+1) != delim){
		    str = str.substring(0,k) + delim + str.substring(k,str.length)
			textbox.value = str
		  }
		 }
		}
	 }

	if(CurrentPos < MaskFormat.length + locs.length)
	{
		if(MaskFormat.charAt(CurrentPos) == 'N')
		{
			if( !isNaN(CurrentChar))
			{
				DoNothing = 0
			}
			else
			{
				DoNothing = 1
			}
		}
		else if(MaskFormat.charAt(CurrentPos) == '/')
		{
			if( CurrentChar == '/')
			{
				DoNothing = 0
			}
			else
			{
				DoNothing = 1
			}
		}
		else if(MaskFormat.charAt(CurrentPos) == 'L')
		{
			if( !isNaN(CurrentChar))
			{
				DoNothing = 1
			}
			else
			{
				DoNothing = 0
			}
		}

	}	
	else
		DoNothing = 1
	

	if(DoNothing == 1)
		event.keyCode = 0
	return true;
//	}
//	catch(e)
//	{
//	}
}


function OpenDate(DivObj)
{
    //InitVal = TDObj.parentNode.parentNode.parentNode.parentNode.rows[0].cells[0].childNodes[0].name;
    InitVal = DivObj.parentNode.parentNode.childNodes[1].childNodes[0].value;
    FFN = DivObj.parentNode.parentNode.childNodes[1].childNodes[0].name;
	InitVal = InitVal.replace("/", "");
	InitVal = InitVal.replace("/", "");
	X =  window.event.clientX 
	Y =  window.event.clientY
	if ( InitVal.length != 8)
		InitVal = '';


    DatePan.style.left = X - 32 + document.body.scrollLeft;
    DatePan.style.top = Y + 2 + document.body.scrollTop + document.documentElement.scrollTop;
       DatePan.style.display = "block"
    //window.resizeTo(X + DatePan.offsetWidth,Y + DatePan.offsetHeight)
    //document.body.scrollIntoView(true)
}


var http_request = null;
var DelObj = null;
function startRequest(url, Func, Method, Param, UpdateObj) { 
    DelObj = UpdateObj;
    if (window.XMLHttpRequest) { 
       http_request = new XMLHttpRequest(); 
    } 
    else if (window.ActiveXObject) { 
       http_request = new ActiveXObject('Microsoft.XMLHTTP'); 
    } 
    url = url + '&rnd=' + Math.random();
    http_request.onreadystatechange = Func;
    http_request.open(Method, url, true); 
    if( Method == 'GET')
       http_request.send(null); 
    else
       http_request.send(Param); 
} 






var LatestSTFHyperLink = null



function SelectMenu(Obj, SelID)
{

    for(i = 0; i < Obj.parentNode.parentNode.cells.length; i++)
    {
            Obj.parentNode.parentNode.cells[i].getElementsByTagName("DIV")[0].className = '';
    }

    Obj.className = 'SelectedItem'
    objDivID = document.getElementById(SelID);
    objContainer = document.getElementById("SubMenuCont");
    if(objDivID != null)
        objContainer.innerHTML = objDivID.innerHTML;
    else
    {
        objContainer.innerHTML = '';
    }

}

function DeselectItem(Obj)
{
    SelID = "";
    for(i = 0; i < Obj.parentNode.parentNode.cells.length; i++)
    {
        Obj.parentNode.parentNode.cells[i].getElementsByTagName("DIV")[0].className = '';
    }
    objDivID = document.getElementById(SelID);
    objContainer = document.getElementById("SubMenuCont");
    if(objDivID != null)
        objContainer.innerHTML = objDivID.innerHTML;
    else
    {
        objContainer.innerHTML = '';
    }
}

var CurTextBox = null;
var CurrentDic = null;
function SearchDic(objTextBox, Dic)
{
    var key
    if (window.ActiveXObject)
    {
         key = window.event.keyCode;
    }

    //debugger
    CurTextBox = objTextBox;
    InpulVal = objTextBox.value;
    if(InpulVal != "")
    {
        CurrentDic = Dic;
//        if (key < 0x0020 || key >= 0x00FF)
//        {
//            CurrentDic = "P2E";
//        }
        url = Path + 'ajxGetWord.aspx?Keyword=' + escape(InpulVal) +'&TransType=StartsWith&Dic=' + CurrentDic;
        makeRequest(url, DicResultReady, 'GET', null)
    }
    else
    {
        ObjSuggestDiv = document.getElementById("SuggestDiv");
        ObjSuggestDiv.className = 'cHidden';
    }
    
}

function DicResultReady()
{
    if(http_request != null)
    {
       if (http_request.readyState == 4) { 
           if (http_request.status == 200) { 
	            result = http_request.responseText
	            ShowToUser(result);
	            document.body.style.cursor='auto';
            }
       }
   }
}

function ShowToUser(response)
{

    if(response == null || response == "")
        return;

    ObjSuggestDiv = document.getElementById("SuggestDiv");
    ObjSuggestDiv.className = 'cVisible';

    ChildLen = ObjSuggestDiv.childNodes.length;
    for(j = 0 ; j < ChildLen; j++)
    {
        //ObjSuggestDiv.childNodes[0].removeNode(true);
        ObjSuggestDiv.removeChild(ObjSuggestDiv.childNodes[0]);
    }

    ObjSuggestDiv.className = 'cSuggestDive';

    var xmlDoc;
    if (window.ActiveXObject)
    {
        xmlDoc = new ActiveXObject("Microsoft.XMLDOM")
        xmlDoc.async="false"
        xmlDoc.loadXML(response)
        xmlObj = xmlDoc.documentElement;
        
        for (i=1 ; i < xmlObj.childNodes.length ; i++)
        {
            CellText = xmlObj.childNodes[i].childNodes[1].text
            divObj = document.createElement("DIV");
//            if(i == 1)
//                divObj.className = 'cSelectedSuggest';
            divObj.innerHTML = CellText;
            divObj.onclick = (
	        function() 
	        {
                SelectSuggest()
            }
            );
            divObj.onmouseover = (
	        function(objSelect) 
	        {
	            if(event != null)
	                event.cancelBubble=true;
	                return function()
                    {
                        MouseoverSelect(objSelect)
                    }
            }
            )(divObj);
            divObj.onmouseout = (
	        function(objSelect) 
	        {
	            if(event != null)
	                event.cancelBubble=true;
	                return function()
                    {
                        MouseooutSelect(objSelect)
                    }
            }
            )(divObj);

                
            ObjSuggestDiv.appendChild(divObj);
        }
        
    }
    else //Firefox
    {
        //debugger
        xmlDoc = document.implementation.createDocument("","",null);
        var oParser = new DOMParser();
        xmlDoc = oParser.parseFromString(response, "text/xml");    
        var Words = xmlDoc.getElementsByTagName ("Word");
        
        //DataLen = Words[8].childNodes[0].nodeValue;
        DataLen = Words.length;
        for (i=0 ; i < DataLen ; i++)
        {
            CellText = Words[i].childNodes[0].nodeValue
            divObj = document.createElement("DIV");
//            if(i == 0)
//                divObj.className = 'cSelectedSuggest';
            divObj.innerHTML = CellText;
            ObjSuggestDiv.appendChild(divObj);
        }
    }
  
}


function MouseooutSelect(objSelectedRow)
{
    ObjSuggestDiv = document.getElementById("SuggestDiv");
    ChildLen = ObjSuggestDiv.childNodes.length;

    for(j = 0 ; j < ChildLen; j++)
    {
        ObjSuggestDiv.childNodes[j].className = ''
    }
}

function MouseoverSelect(objSelectedRow)
{
    objSelectedRow.className ='cSelectedSuggest'
}

function CalculateTotalOffsetLeft(Element)
{
    try{
        CalculatedTotalOffsetLeft = 0;
        while (Element.offsetParent) {
            CalculatedTotalOffsetLeft += Element.offsetLeft ;
            Element = Element.offsetParent ;
        }
        return parseInt(CalculatedTotalOffsetLeft);
    }
    catch(e)
    {
        return 0;
    }
}
function CalculateTotalOffsetTop(Element)
{
    try
    {
        CalculatedTotalOffsetTop = 0;
        while (Element.offsetParent) {
            CalculatedTotalOffsetTop += Element.offsetTop ;
            Element = Element.offsetParent ;
        }
        return parseInt(CalculatedTotalOffsetTop);
    }
    catch(e)
    {
        return 0;
    }
}

function GetSourceLangVal()
{
    for (var i=0; i < document.forms[0].ctl00$CP1$rblSourceLang.length; i++)
    {
    if (document.forms[0].ctl00$CP1$rblSourceLang[i].checked)
      {
        return rad_val = document.forms[0].ctl00$CP1$rblSourceLang[i].value;
      }
    }
}

function CaptureKey(objTextbox, e, Dic)
{
    if(e.keyCode == 13 && GetSourceLangVal() != 'EN')
    {
        document.getElementById('btnTranslate').click();
        return false;
    }
    else if(GetSourceLangVal() != 'EN')
        return;
    switch (e.keyCode) {
    case 27: //Escape
        ObjSuggestDiv = document.getElementById("SuggestDiv");
        ObjSuggestDiv.className = 'cHidden';
        break	
    case 13: //Enter
        SelectSuggest();
        break	
    case 38: //Up Arrow
        GoToUp();
        break	
    case 40: //Down Arrow
        GoToDown();
        break	
    default:
        SearchDic(objTextbox, Dic);
    }
}

function GoToDown()
{
    ObjSuggestDiv = document.getElementById("SuggestDiv");
    ChildLen = ObjSuggestDiv.childNodes.length;
    SelectedIndex = 0;
    //debugger

    for(j = 0 ; j < ChildLen; j++)
    {
        if(ObjSuggestDiv.childNodes[j].className == 'cSelectedSuggest')
        {
            SelectedIndex = j;
            break;
        }
    }

    for(c = 0 ; c < ChildLen; c++)
    {
        ObjSuggestDiv.childNodes[c].className = ''       
    }

    if(SelectedIndex + 1 < ChildLen)
        NextIndex = SelectedIndex + 1;
    else
        NextIndex = SelectedIndex;
    ObjSuggestDiv.childNodes[NextIndex].className = 'cSelectedSuggest'
        
}


function GoToUp()
{
    ObjSuggestDiv = document.getElementById("SuggestDiv");
    ChildLen = ObjSuggestDiv.childNodes.length;
    SelectedIndex = 0;
    //debugger

    for(j = 0 ; j < ChildLen; j++)
    {
        if(ObjSuggestDiv.childNodes[j].className == 'cSelectedSuggest')
        {
            SelectedIndex = j;
            break;
        }
    }

    for(c = 0 ; c < ChildLen; c++)
    {
        ObjSuggestDiv.childNodes[c].className = ''       
    }

    if(SelectedIndex > 0)
        NextIndex = SelectedIndex - 1;
    ObjSuggestDiv.childNodes[NextIndex].className = 'cSelectedSuggest'
}


function SelectSuggest()
{
    ObjSuggestDiv = document.getElementById("SuggestDiv");
    ChildLen = ObjSuggestDiv.childNodes.length;
    SelectedIndex = null;
    //debugger

    for(j = 0 ; j < ChildLen; j++)
    {
        if(ObjSuggestDiv.childNodes[j].className == 'cSelectedSuggest')
        {
            SelectedIndex = j;
            break;
        }
    }
   
    if(SelectedIndex == null)
    {
        document.getElementById('btnTranslate').click();
        return false;
    }
    
    if(ObjSuggestDiv.childNodes.length >0)
    {
        SelectedWord = ObjSuggestDiv.childNodes[SelectedIndex].innerHTML;
        if(CurTextBox != null)
        {
            CurTextBox.value = SelectedWord;
            ObjSuggestDiv.className = 'cHidden';
            
            document.getElementById('btnTranslate').click();
            //debugger
            return false;
        }
    }
       
}


function checkClick(e) {
	e?evt=e:evt=event;
	CSE=evt.target?evt.target:evt.srcElement;
        if(!isChild(CSE,getObj('SuggestDiv')))
        {
            getObj('SuggestDiv').className ='cHidden';
            CurTextBox = null;
        }	


}
function isChild(s,d) {
	while(s) {
		if (s==d) 
			return true;
		s=s.parentNode;
	}
	return false;
}
function getObj(objID)
{
    if (document.getElementById) {return document.getElementById(objID);}
    else if (document.all) {return document.all[objID];}
    else if (document.layers) {return document.layers[objID];}
}

function createCookie(name,value,days) {
	if (days) {
		var date = new Date();
		date.setTime(date.getTime()+(days*24*60*60*1000));
		var expires = "; expires="+date.toGMTString();
	}
	else var expires = "";
	document.cookie = name+"="+value+expires+"; path=/";
}

function readCookie(name) {
	var nameEQ = name + "=";
	var ca = document.cookie.split(';');
	for(var i=0;i < ca.length;i++) {
		var c = ca[i];
		while (c.charAt(0)==' ') c = c.substring(1,c.length);
		if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
	}
	return null;
}

function eraseCookie(name) {
	createCookie(name,"",-1);
}

function InHistoryWords(CheckWord)
{
    for(i =0 ; i < objtblMyWords.rows.length; i++)
    {
        if(objtblMyWords.rows[i].cells[0].innerHTML == CheckWord)
        {
            return true;
        }
    }
    return false;
}


var objtblMyWords;
var myWordsTbody;

//eraseCookie("SavedWords")
function AddtoMyWords(CurWord, SelDic, AddToCookies)
{
    if(AddToCookies)
    {
        CurrentSavedWords = readCookie("SavedWords");
        if(CurrentSavedWords == null)
            NewVal = CurWord + "|" + SelDic;
        else
            NewVal = CurrentSavedWords + "," + CurWord + "|" + SelDic;

        createCookie("SavedWords", NewVal, 365);
    }

    newRow = document.createElement("TR");
    WordCell = document.createElement("TD");
    WordCell.className = 'cHistoryWord';
    WordCell.Dic = SelDic;

    WordCell.innerHTML = CurWord;
    newRow.appendChild(WordCell);

    if (window.ActiveXObject)
    {
        WordCell.onclick = (
        function(objSelect) 
        {
            if(event != null)
                event.cancelBubble=true;
                return function()
                {
                    SelectFromHistory(objSelect)
                }
        }
        )(WordCell);
    }

    myWordsTbody.appendChild(newRow);
    objtblMyWords.appendChild(myWordsTbody);
}

function InitializeMyWords()
{
    objtblMyWords = document.createElement("TABLE");
    objtblMyWords.className = "ctblMyWords"
    myWordsTbody = document.createElement("TBODY");
    objMyWordsDiv = document.getElementById('MyWordsDiv');
    objMyWordsDiv.appendChild(objtblMyWords);

    CurrentSavedWords = readCookie("SavedWords");
    if(CurrentSavedWords != null)
    {
        CurrentSavedWordsArray = CurrentSavedWords.split(',');
        for(i =0 ; i < CurrentSavedWordsArray.length; i++)
        {
            CurWordAndDic = CurrentSavedWordsArray[i];
            CurWordAndDicArray = CurWordAndDic.split('|');
            CookieWord = CurWordAndDicArray[0];
            CookieDic = CurWordAndDicArray[1];
            AddtoMyWords(CookieWord, CookieDic, false)
        }
    }
}


function ShowTranslateWord(response) {
    if(response == null || response == "" || CurrentWord == null || response == "ERROR")
        return;

    ChildLen = ObjResultsDiv.childNodes.length;
    for(j = 0 ; j < ChildLen; j++)
    {
        ObjResultsDiv.removeChild(ObjResultsDiv.childNodes[0]);
    }

    ObjResultsDiv.className = 'cResultsDive';

    objtblResults = document.createElement("TABLE");
    objtblResults.className = "ctblResults"
    myTbody = document.createElement("TBODY");

    var xmlDoc;
    if (window.ActiveXObject) {
        
        xmlDoc = new ActiveXObject("Microsoft.XMLDOM")
        xmlDoc.async="false"
        xmlDoc.loadXML(response)
        xmlObj = xmlDoc.documentElement;

        for (i=1 ; i < xmlObj.childNodes.length ; i++)
        {
            CurWord = xmlObj.childNodes[i].childNodes[1].text
            CurMeaning = xmlObj.childNodes[i].childNodes[2].text
            CurWord = CurWord.replace('\n', '');
            CurWord = CurWord.toLowerCase().replace(CurrentWord.toLowerCase(),'<b>' + CurrentWord.toLowerCase() + '</b>');

            newRow = document.createElement("TR");
            WordCell = document.createElement("TD");
            MeaningCell = document.createElement("TD");
            
            if(CurrentDic == "E2P" || CurrentDic == "E2A")
            {
                WordCell.className = 'cWordCell';
                MeaningCell.className = 'cMeaningCell';
            }
            else
            {
                WordCell.className = 'cWordCellLTR';
                MeaningCell.className = 'cMeaningCellLTR';
            }
            //alert(MeaningCell.className);

            if(i %2)
                newRow.className = 'cResultRow'
            else
                newRow.className = 'cResultRowAlter'

            WordCell.innerHTML = CurWord;
            MeaningCell.innerHTML = CurMeaning;

            newRow.appendChild(WordCell);
            newRow.appendChild(MeaningCell);
            
            myTbody.appendChild(newRow);
        }
    }
    else //Firefox
    {
        xmlDoc = document.implementation.createDocument("","",null);
        var oParser = new DOMParser();
        xmlDoc = oParser.parseFromString(response, "text/xml");    
        var Words = xmlDoc.getElementsByTagName ("Word");
        var Meanings = xmlDoc.getElementsByTagName ("Meaning");
        
        DataLen = Words.length;
        for (i=0 ; i < DataLen ; i++)
        {
            CurWord = Words[i].childNodes[0].nodeValue
            CurMeaning = Meanings[i].childNodes[0].nodeValue
            CurWord = CurWord.replace('\n', '');
            CurWord = CurWord.toLowerCase().replace(CurrentWord.toLowerCase(),'<b>' + CurrentWord.toLowerCase() + '</b>');

            newRow = document.createElement("TR");
            WordCell = document.createElement("TD");
            MeaningCell = document.createElement("TD");
            
            if(CurrentDic == "E2P" || CurrentDic == "E2A")
            {
                WordCell.className = 'cWordCell';
                MeaningCell.className = 'cMeaningCell';
            }
            else
            {
                WordCell.className = 'cWordCellLTR';
                MeaningCell.className = 'cMeaningCellLTR';
            }
            if(i %2)
                newRow.className = 'cResultRow'
            else
                newRow.className = 'cResultRowAlter'

            WordCell.innerHTML = CurWord;
            MeaningCell.innerHTML = CurMeaning;

            newRow.appendChild(WordCell);
            newRow.appendChild(MeaningCell);
            
            myTbody.appendChild(newRow);
        }
    }
    
    objtblResults.appendChild(myTbody);
    ObjResultsDiv.appendChild(objtblResults);

    BoxHeader = document.getElementById('ctl00_ContentPlaceHolder1_lblHeader')
    BoxHeader.innerHTML = 'Search Results for ' + CurrentWord;
    if(CurTextBox != null)
        CurTextBox.select();
    CurrentWord = null;
    CurTextBox = null;
}

document.all?document.attachEvent('onclick',checkClick):document.addEventListener('click',checkClick,false);
document.all?document.attachEvent('onresize',checkClick):document.addEventListener('resize',checkClick,false);
//document.all?document.attachEvent('onload',InitializeMyWords):document.addEventListener('load',InitializeMyWords,false);

CheckBrowser = function () {
    if (navigator.userAgent.indexOf("Firefox") != -1)
        return "FireFox";
    else
        return "IE";
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
