<%@ Control Language="C#" AutoEventWireup="true" EnableViewState="false" Inherits="UserControls_Menu" CodeBehind="Menu.ascx.cs" %>
<div id="MainMenuAccordion" class="accordion">
    <h3 class="title"><span>اخبار</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/News/NewsByCatCode.aspx?Code=1" runat="server">اجتماعي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/News/NewsByCatCode.aspx?Code=2" runat="server">اقتصادي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink3" NavigateUrl="~/News/NewsByCatCode.aspx?Code=3" runat="server">سياسي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink4" NavigateUrl="~/News/NewsByCatCode.aspx?Code=4" runat="server">ورزشي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink5" NavigateUrl="~/News/NewsByCatCode.aspx?Code=5" runat="server">علمي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink6" NavigateUrl="~/News/NewsByCatCode.aspx?Code=6" runat="server">فرهنگي</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink7" NavigateUrl="~/News/NewsByCatCode.aspx?Code=7" runat="server">ادب و هنر</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink8" NavigateUrl="~/News/NewsByCatCode.aspx?Code=8" runat="server">بين‌الملل</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink9" NavigateUrl="~/News/NewsByCatCode.aspx?Code=9" runat="server">حوادث</asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>فرهنگی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink10" NavigateUrl="~/Culture/Quran/" runat="server" Text="قرآن"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink11" NavigateUrl="~/Culture/Nahj/" runat="server" Text="نهج البلاغه"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink12" NavigateUrl="~/Culture/Poems/" runat="server" Text="اشعار"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink13" NavigateUrl="~/Culture/History/" runat="server" Text="تقویم تاریخ"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink14" NavigateUrl="~/GWords" runat="server" Text="سخن بزرگان"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>سرگرمی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink15" NavigateUrl="~/Games" runat="server">بازی</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink16" NavigateUrl="~/Galleries" runat="server">گالری عکس</asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="hplSMS" ClientIDMode="Static" NavigateUrl="~/SMS" runat="server" Text="اس ام اس (جدید)"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink17" NavigateUrl="~/Fun/Tabir" Text="تعبیر خواب" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink18" NavigateUrl="~/Fun/Omen" Text="فال حافظ" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink19" NavigateUrl="~/Fun/Names" Text="نامها" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink20" NavigateUrl="~/Inter" Text="مصاحبه" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink21" NavigateUrl="~/Fun/Horoscope" Text="طالع بینی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink22" NavigateUrl="~/Dic" runat="server" Text="فرهنگ لغات"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink23" NavigateUrl="~/Greetings/" Text="کارت تبریک" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink24" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=2" Text="فال و طالع بینی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink25" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=3" Text="مطالب طنز و خنده دار" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink26" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=4" Text="معما و تست هوش" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink27" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=5" Text="خواندنیهای دیدنی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink28" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=6" Text="دنیای بازیگران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink29" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=7" Text="شهر حکایت" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink30" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=8" Text="داستانهای خواندنی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink31" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=9" Text="کاریکاتور و تصاویر طنز" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink32" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=10" Text="دنیای ضرب المثل" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink33" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=11" Text="بازیهای محلی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink34" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=12" Text="کارت پستال و تصاویر متحرک" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink35" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=13" Text="تصاویر ویژه روز" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink36" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=14" Text="اس ام اس های جالب" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink37" NavigateUrl="~/Wallpapers" Text="کاغذ دیواری" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>سلامت</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink38" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=16" Text="بیماری ها و راه درمان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink39" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=17" Text="پیشگیری بهتر از درمان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink40" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=18" Text="داروهای گیاهی و طب سنتی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink41" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=19" Text="بهداشت بانوان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink42" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=20" Text="تغذیه سالم" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink43" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=21" Text="بهداشت کودکان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink44" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=22" Text="رژیم درمانی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink45" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=23" Text="ورزش درمانی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink46" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=24" Text="ایدز و انواع اعتیاد" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink47" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=25" Text="ابزار پزشکی آنلاین" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>اسرار خانه داری</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink48" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=27" Text="تزئینات عقد و عروسی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink49" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=28" Text="شستشو ، نظافت" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink50" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=29" Text="هنر در خانه" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink51" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=30" Text="نگه داری مواد غذایی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink52" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=31" Text="مهارتهای زندگی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink53" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=32" Text="متفرقه" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>دنیای مد</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink54" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=34" Text="لباس و کیف و کفش" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink55" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=35" Text="دکوراسیون و چیدمان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink56" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=36" Text="مد و مدگرایی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink57" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=37" Text="طلا و جواهرات" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink58" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=38" Text="اخبار مد و ستاره ها" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>روان شناسی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink59" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=40" Text="مشاوره خانواده" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink60" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=41" Text="تست روانشناسی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink61" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=42" Text="روانشناسی زناشویی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink62" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=43" Text="رفتارهای کودکان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink63" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=44" Text="برای زندگی بهتر" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink64" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=45" Text="والدین موفق" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink65" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=46" Text="فرزندان و امتحانات" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>آرایش و زیبایی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink66" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=48" Text="لوازم آرایشی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink67" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=49" Text="آرایش صورت" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink68" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=50" Text="آرایش موها" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink69" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=51" Text="سلامت پوست" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink70" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=52" Text="سلامت موها" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>گردشگری</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink71" NavigateUrl="~/Know/Iran" Text="نقشه ایران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink72" NavigateUrl="~/Know/Tehran" Text="نقشه تهران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink73" NavigateUrl="~/Know/Cities" Text="شهرهای ایران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink74" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=54" Text="مکانهای تفریحی ايران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink75" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=55" Text="مكانهاي تاريخي ايران" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink76" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=56" Text="مکانهای زيارتي ايران و جهان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink77" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=57" Text="عجایب گردشگری" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink78" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=58" Text="مکانهای تفریحی جهان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink79" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=59" Text="مكانهاي تاريخي جهان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink80" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=60" Text="دانستنی های سفر" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>زناشویی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink81" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=62" Text="دانستنیهای قبل از ازدواج" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink82" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=63" Text="نامزدی، عقد و بعد از ازدواج" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink83" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=64" Text="دانستنیهای جنسی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink84" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=65" Text="بارداری و زایمان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink85" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=66" Text="رازهای موفقیت" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink86" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=67" Text="کوچه پس کوچه های تفاهم" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink87" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=68" Text="دوران سالمندی" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>آشپزی و تغذیه</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink88" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=70" Text="آموزش انواع غذاها" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink89" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=71" Text="آموزش شیرینی پزی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink90" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=72" Text="انواع مربا و ترشیجات" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink91" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=73" Text="خواص مواد غذایی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink92" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=74" Text="غذاهای رژیمی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink93" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=75" Text="نکات مهم آشپزی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink94" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=76" Text="نگه داری مواد غذایی" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>کودکان و والدین</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink95" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=90" Text="شعر و ترانه" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink96" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=91" Text="فرهنگ زندگی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink97" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=92" Text="هنر و هنرمند" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink98" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=93" Text="تاریخ و تمدن" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink99" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=94" Text="هنرهای دستی و ترسیمی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink100" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=95" Text="فرش و گلیم" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink101" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=96" Text="مناسبتها در ایران و جهان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink102" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=97" Text="اخبار فرهنگی و هنری" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>مذهبی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink103" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=99" Text="زندگینامه بزرگان دینی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink104" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=100" Text="اصول و فروع دین" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink105" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=101" Text="داروخانه معنوی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink106" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=102" Text="احادیث و سخنان بزرگان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink107" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=103" Text="آرامش سبز" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink108" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=104" Text="اعمال مستحبی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink109" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=105" Text="احکام دینی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink110" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=106" Text="متفرقه دینی" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>کامپیوتر و اینترنت</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink111" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=108" Text="موبایل ، لپ تاپ و تبلت" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink112" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=109" Text="اختراعات جدید" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink113" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=110" Text="ترفندهای کامپیوتری" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink114" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=111" Text="ترفندهای اینترنتی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink115" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=112" Text="متفرقه اينترنت و كامپيوتر" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink116" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=113" Text="گرافیک دستی و کامپیوتری" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>علمی و آموزشی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink117" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=115" Text="زندگینامه شعرا و دانشمندان" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink118" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=116" Text="چرا ، زیرا و چگونه" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink119" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=117" Text="گزارشهای علمی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink120" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=118" Text="گیاهان،حیوانات و آکواریوم" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink121" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=119" Text="آیا می دانید ؟" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink122" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=120" Text="نوآوری و کشفیات علمی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink123" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=121" Text="معرفی رشته های تحصیلی" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>ورزش و تندرستی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink124" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=123" Text="زیبایی اندام" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink125" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=124" Text="درمان با ورزش" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink126" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=125" Text="ورزش عمومی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink127" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=126" Text="تاریخچه رشته های ورزشی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink128" NavigateUrl="~/Contents/ShowSubCat.aspx?Code=127" Text="ورزشکاران" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
    <h3 class="title"><span>اطلاعات عمومی</span></h3>
    <div class="MVCCont">
        <ul>
            <li>
                <asp:HyperLink ID="HyperLink129" NavigateUrl="~/Data" Text="آدرس مکانهای عمومی" runat="server"></asp:HyperLink></li>
            <li>
                <asp:HyperLink ID="HyperLink130" NavigateUrl="~/Info" Text="مشاغل" runat="server"></asp:HyperLink></li>
        </ul>
    </div>
</div>
<script>$(function () { $("#MainMenuAccordion").accordion({ heightStyle: "content", active: false, collapsible: true }); });</script>
<div class="Clear"></div>
