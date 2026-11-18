namespace CargoPlus;

internal static class UiText
{
    private static bool Tr => false;

    public static string Settings => Tr ? "Ayarlar" : "Կարգավորումներ";
    public static string Exit => Tr ? "Çıkış" : "Ելք";
    public static string OpenApp => Tr ? "Aç" : "Բացել";
    public static string Menu => Tr ? "Menü" : "Ընտրացանկ";
    public static string CheckCode => Tr ? "Kodu kontrol et" : "Ստուգել կոդը";
    public static string ReprintReceipt => Tr ? "Mağaza fişini yeniden yazdır" : "Խանութի կտրոնը կրկին";
    public static string Finish => Tr ? "Bitir ve fiş yazdır" : "Ավարտել և տպել";
    public static string PrintStore => Tr ? "Mağaza fişi" : "Խանութի կտրոն";
    public static string PrintCargo => Tr ? "Kargo fişi" : "Բեռի կտրոն";
    public static string AcceptCargo => Tr ? "Yük kabul" : "Ընդունել բեռը";
    public static string Today => Tr ? "Bugün kabul edilenler" : "Այսօր ընդունված";
    public static string TodayReport => Tr ? "Bugünkü rapor" : "Այսօրվա հաշվետվություն";
    public static string TodayEmpty => Tr ? "Bugün henüz çuval kabul edilmedi." : "Այսօր դեռ ոչինչ չի ընդունվել։";
    public static string TodayBags(int count) => Tr ? $"Çuval: {count}" : $"Պարկեր՝ {count}";
    public static string TodayKilo(string kilo) => Tr ? $"Kilogram: {kilo}" : $"Կիլոգրամ՝ {kilo}";
    public static string TodayInsured(int count, int dollars) => Tr
        ? $"Sigorta alındı: {count} çuval, {dollars} $"
        : $"Ապահովագրությամբ՝ {count} պարկ, {dollars} $";
    public static string TodayUninsured(int count) => Tr
        ? $"Sigortasız: {count} çuval"
        : $"Առանց ապահովագրության՝ {count} պարկ";
    public static string TodayLine(string type, int bags, string kilo, int insured, int plain) => Tr
        ? $"{type} — {bags} çuval, {kilo} kg, sigorta {insured}, sigortasız {plain}"
        : $"{type} — {bags} պարկ, {kilo} կգ, ապահովագրություն {insured}, առանց {plain}";
    public static string Reports => Tr ? "Raporlar" : "Հաշվետվություններ";
    public static string ReportFrom => Tr ? "Tarihten" : "Ամսաթիվ՝ սկսած";
    public static string ReportTo => Tr ? "Tarihe" : "Ամսաթիվ՝ մինչև";
    public static string ReportSearch => Tr ? "Bul" : "Գտնել";
    public static string ReportPick => Tr ? "Listeden bir fiş seçin." : "Ընտրեք կտրոնը ցանկից։";
    public static string ReportTitle(int count) => Tr
        ? $"Çuvallar: {count}. Her satır bir çuval."
        : $"Պարկեր՝ {count}։ Ամեն տողը մեկ պարկ է։";
    public static string ReportToday => Tr ? "Bugün" : "Այսօր";
    public static string ReportWeek => Tr ? "Hafta" : "Շաբաթ";
    public static string ReportMonth => Tr ? "Ay" : "Ամիս";
    public static string ExcelSave => Tr ? "Excel'e indir" : "Ներբեռնել Excel";
    public static string ExcelEmpty => Tr ? "İndirilecek satır yok." : "Արտահանելու տող չկա։";
    public static string ExcelSaved(string path) => Tr ? $"Dosya kaydedildi:\n{path}" : $"Ֆայլը պահվել է՝\n{path}";
    public static string ExcelFailed => Tr ? "Excel dosyası yazılamadı.\n" : "Excel ֆայլը չգրվեց։\n";
    public static string ExcelFilter => "Excel (*.xlsx)|*.xlsx";
    public static string Unsynced => Tr ? "Sunucuya gitmeyenler" : "Սերվեր չուղարկված";
    public static string CheckUpdates => Tr ? "Güncellemeleri denetle" : "Ստուգել թարմացումները";
    public static string BackMenu => Tr ? "Menüye dön" : "Ընտրացանկ";
    public static string ClientSection => Tr ? "Müşteri" : "Հաճախորդ";
    public static string ClientCode => Tr ? "Müşteri kodu" : "Հաճախորդի կոդ";
    public static string FindClient => Tr ? "Ad veya telefon" : "Անուն կամ հեռախոս";
    public static string AddClient => Tr ? "Müşteri ekle" : "Ավելացնել";
    public static string AddClientTitle => Tr ? "Yeni müşteri" : "Նոր հաճախորդ";
    public static string ClientName => Tr ? "Ad" : "Անուն";
    public static string ClientSurname => Tr ? "Soyad" : "Ազգանուն";
    public static string ClientPhone => Tr ? "Telefon" : "Հեռախոս";
    public static string ClientPhone2 => Tr ? "İkinci telefon" : "Երկրորդ հեռախոս";
    public static string ClientNotes => Tr ? "Not" : "Նշումներ";
    public static string SaveClient => Tr ? "Kaydet" : "Պահել";
    public static string NeedClientName => Tr ? "Ad zorunlu." : "Անունը պարտադիր է։";
    public static string NeedClientPhone => Tr ? "İlk telefon zorunlu." : "Առաջին հեռախոսը պարտադիր է։";
    public static string ClientNotFound => Tr ? "Böyle müşteri yok. Yeni müşteri ekleyin." : "Այսպիսի հաճախորդ չկա։ Ավելացրեք նոր հաճախորդ։";
    public static string PickClient => Tr ? "Listeden müşteriyi seçin." : "Ընտրեք հաճախորդին ցանկից։";
    public static string ClientSaved(uint kod) => Tr ? $"Müşteri kaydedildi. Kod: {kod}." : $"Հաճախորդը պահվեց։ Կոդ՝ {kod}։";
    public static string ClientSavedOffline(uint kod) => Tr
        ? $"Müşteri programda duruyor. Kod: {kod}. Bağlantı gelince sunucuya gider."
        : $"Հաճախորդը պահվեց ծրագրում։ Կոդ՝ {kod}։ Կապ լինի՝ կգնա սերվեր։";
    public static string ClientsNotLoaded => Tr
        ? "Müşteri listesi henüz inmedi. Bir kez internet gerekir."
        : "Հաճախորդների ցանկը դեռ չի ներբեռնվել։ Մեկ անգամ կապ է պետք։";
    public static string ClientWaiting => Tr ? "Müşteri henüz sunucuya gitmedi." : "Հաճախորդը դեռ սերվեր չի գնացել։";
    public static string StoreSection => Tr ? "Mağaza ve çuval" : "Խանութ և պարկ";
    public static string StorePhone => Tr ? "Mağaza telefonu" : "Խանութի հեռախոս";
    public static string StoreName => Tr ? "Mağaza adı" : "Խանութի անուն";
    public static string Type => Tr ? "Gönderi türü" : "Ուղարկման տեսակ";
    public static string Insurance => Tr ? "Sigorta, $" : "Ապահովագրություն, $";
    public static string Note => Tr ? "Not" : "Նշում";
    public static string Kilos => Tr ? "Kilogram" : "Կիլոգրամ";
    public static string PhonePrefix => Tr ? "Telefon: " : "Հեռախոս՝ ";
    public static string PhoneEmpty => Tr ? "Telefon: —" : "Հեռախոս՝ —";
    public static string CodeUnchecked => Tr ? "Kod henüz kontrol edilmedi" : "Կոդը դեռ չի ստուգվել";
    public static string EnterCode => Tr ? "Ad veya telefonun son rakamlarını yazın." : "Գրեք անունը կամ հեռախոսի վերջին թվերը։";
    public static string CodeMissing => Tr ? "Bu kod veritabanında yok." : "Այսպիսի կոդ բազայում չկա։";
    public static string CodeMissingBag => Tr ? "Bu kod veritabanında yok. Çuval kabul edilmez." : "Այսպիսի կոդ բազայում չկա։ Պարկ չենք ընդունում։";
    public static string CodeOk => Tr ? "Kod var. Çuval kabul edilebilir." : "Կոդը բազայում կա։ Կարելի է պարկ ընդունել։";
    public static string CheckingCode => Tr ? "Kod sunucuda kontrol ediliyor..." : "Կոդը ստուգվում է սերվերում...";
    public static string ServerRejected => Tr ? "Sunucu kodu doğrulamadı." : "Սերվերը կոդը չհաստատեց։";
    public static string SessionOpen => Tr ? "Kapanmamış kabul. Kod daha önce doğrulandı." : "Չփակված հանձնում։ Կոդն արդեն ստուգված էր։";
    public static string NeedCode => Tr ? "Müşteri kodunu yazın." : "Գրեք հաճախորդի կոդը։";
    public static string CodeNumber => Tr ? "Müşteri kodu sayı olmalı." : "Հաճախորդի կոդը թիվ է։";
    public static string CloseSessionFirst(uint kod) => Tr
        ? $"Şu an {kod} kodunun kabulü açık. Önce fişleri yazdırın."
        : $"Հիմա ընթանում է {kod} կոդի հանձնումը։ Նախ տպեք կտրոնները։";
    public static string DbNotReady => Tr
        ? "Veritabanı bağlantısı ayarlanmadı. Bunu ana yönetici yapar."
        : "Բազայի կապը դեռ կարգավորված չէ։ Դա անում է գլխավոր ադմինիստրատորը։";
    public static string CodeNotConfirmed => Tr ? "Kod doğrulanmadı. Kabul başlamadı.\n" : "Կոդը հաստատված չէ։ Ընդունումը չի սկսվել։\n";
    public static string NeedClientFirst => Tr ? "Önce müşteriyi seçin." : "Նախ ընտրեք հաճախորդին։";
    public static string LabelFailed(string kodId, string message) => Tr
        ? $"Çuval {kodId} etiketi yazdırılamadı. {message}"
        : $"Պարկի {kodId} պիտակը չտպվեց։ {message}";
    public static string PickBag => Tr ? "Tablodan bir çuval seçin." : "Ընտրեք պարկը աղյուսակից։";
    public static string NoBags => Tr ? "Bu kabulde henüz çuval yok." : "Այս հանձնման մեջ դեռ պարկ չկա։";
    public static string ReceiptFailed => Tr
        ? "Fişler yazdırılamadı. Kabul kapanmadı, yeniden deneyebilirsiniz.\n"
        : "Կտրոնները չտպվեցին։ Հանձնումը փակված չէ, կարելի է նորից փորձել։\n";
    public static string CloseApp => Tr ? "Cargo Plus kapatılsın mı?" : "Փակե՞լ Gokor Cargo-ն։";
    public static string CloseAppOpen => Tr
        ? "Kabul kapanmadı, fiş yazdırılmadı. Program kapatılsın mı? Çuvallar durur ve bağlantı gelince sunucuya gider."
        : "Հանձնումը դեռ փակված չէ, կտրոնները չեն տպվել։ Փակե՞լ ծրագիրը։ Պարկերը կմնան և կապ լինելիս կգնան սերվեր։";
    public static string LogoutAsk => Tr ? "Giriş ekranına dönülsün mü?" : "Դուրս գա՞լ դեպի մուտքի էկրան։";
    public static string LogoutOpen => Tr
        ? "Kabul kapanmadı. Çıkılsın mı? Çuvallar durur, fiş sonraki girişte yazdırılabilir."
        : "Հանձնումը փակված չէ։ Դուրս գա՞լ։ Պարկերը կպահվեն, կտրոնը կարելի է տպել հաջորդ մուտքից հետո։";
    public static string TitleCode => Tr ? "Kod" : "Կոդ";
    public static string TitleSession => Tr ? "Kabul" : "Հանձնում";
    public static string TitleDb => Tr ? "Veritabanı" : "Բազա";
    public static string TitleBag => Tr ? "Çuval" : "Պարկ";
    public static string TitleStore => Tr ? "Mağaza" : "Խանութ";
    public static string TitleInsurance => Tr ? "Sigorta" : "Ապահովագրություն";
    public static string TitleKilo => Tr ? "Kilogram" : "Կիլոգրամ";
    public static string TitleLabel => Tr ? "Etiket" : "Պիտակ";
    public static string TitleReceipt => Tr ? "Fiş" : "Կտրոն";
    public static string TitleExit => Tr ? "Çıkış" : "Ելք";
    public static string TitleNumbers => Tr ? "Çuval numaraları" : "Պարկերի համարներ";
    public static string Bags(int count) => Tr ? $"Çuval: {count}" : $"Պարկեր՝ {count}";
    public static string StoreLine(int length) => Tr
        ? $"Mağaza adı: {length} / {CargoRules.StoreNameMax}"
        : $"Խանութի անուն՝ {length} / {CargoRules.StoreNameMax}-ից";
    public static string WindowTitle(string? company)
    {
        var firm = company?.Trim() ?? "";
        return firm.Length == 0 ? AppRelease.Product : firm + " — " + AppRelease.Product;
    }

    public static string Header(string company, string name, string level, string next) => Tr
        ? $"{company}     {name}  ·  {level}  ·  sonraki çuval {next}"
        : $"{company}     {name}  ·  {level}  ·  հաջորդ պարկ {next}";
    public static string StationLetterLabel => Tr ? "Depo harfi" : "Պահեստի տառ";
    public static string StationLetterBad => Tr
        ? "Depo harfi bir veya iki Latin harfidir."
        : "Պահեստի տառը մեկ կամ երկու լատինական տառ է։";
    public static string StationLetterHint => Tr
        ? "Boş bırakılırsa depo adının ilk harfi kullanılır. Elle değiştirirseniz ad değişse de harf kalır."
        : "Եթե տառը չփոխեք, այն վերցվում է պահեստի անվան առաջին տառից։";
    public static string NumbersAutomatic => Tr
        ? "Çuval numarası otomatik verilir. Aralık elle yazılmaz."
        : "Պարկի համարը տրվում է ինքնըստինքյան։ Միջակայքը ձեռքով չի գրվում։";
    public static string LettersNotAccepted => Tr
        ? "Sunucu henüz harfli çuval numarası kabul etmiyor."
        : "Սերվերը դեռ չի ընդունում տառերով համարներ։";
    public static string About => Tr ? "Hakkında" : "About";
    public static string AboutTitle => Tr ? "Hakkında" : "About";
    public static string LevelTitle(string code) => code switch
    {
        AccessLevels.Admin => Tr ? "Ana yönetici" : "Գլխավոր ադմինիստրատոր",
        AccessLevels.Operator => Tr ? "Operatör" : "Օպերատոր",
        _ => code,
    };
    public static string CategoryTitle(string category) =>
        category == AccessLevels.AdminCategory ? (Tr ? "Yönetim" : "Վարչություն") : category;
    public static string AboutProgram => Tr ? "Program" : "Ծրագիր";
    public static string AboutDeveloper => Tr ? "Geliştirici" : "Մշակող";
    public static string AboutDate => Tr ? "Sürüm tarihi" : "Տարբերակի ամսաթիվ";
    public static string AboutVersion => Tr ? "Sürüm" : "Տարբերակ";
    public static string ZeroForbidden => Tr
        ? "Çuval numarası 0 ve müşteri kodu 0 kaydedilmez."
        : "0 համարով պարկ կամ 0 հաճախորդի կոդ չի գրանցվում։";
    public static string ZeroGuardDenied => Tr
        ? "Sunucu kullanıcısının TRIGGER yetkisi yok. Sıfırlı çuval yasağı tabloya yazılamadı."
        : "Բազայի օգտատերը TRIGGER իրավունք չունի։";
    public static string NumbersEnded => Tr
        ? "Çuval numaraları bitti. Ana yöneticiyi çağırın: yeni aralık gerekir."
        : "Պարկերի համարներն ավարտվեցին։ Կանչեք գլխավոր ադմինիստրատորին։";
    public static string NumbersLow(int left) => Tr
        ? $"Çuval numaralarının bitmesine {left} kaldı. Numaraları güncellemek gerekir."
        : $"Պարկերի համարների վերջին մնացել է {left}։";
    public static string DbMissingStatus => Tr
        ? "Veritabanı ayarlı değil. Yönetici sunucuyu yazmadan kod kabul edilmez."
        : "Բազան կարգավորված չէ։ Կոդի ընդունումը հասանելի չէ, մինչև ադմինիստրատորը նշի սերվերը։";
    public static string Offline(int pending, string? error) => Tr
        ? $"İnternet yok. Program kendi içinde çalışıyor. Gönderilmeyen {pending}. {error}"
        : $"Ինտերնետ չկա։ Ծրագիրն աշխատում է տեղում։ Չուղարկված՝ {pending}։ {error}";
    public static string AllSent(string when) => Tr ? $"Bağlı. Hepsi gitti. {when}" : $"Կապ կա։ Ամեն ինչ ուղարկված է։ {when}";
    public static string SomePending(int pending, string when) => Tr
        ? $"Bağlı. Gönderilmeyen {pending}. {when}"
        : $"Կապ կա։ Չուղարկված՝ {pending}։ {when}";
    public static string Speed(double? value) => value is { } amount
        ? amount >= 1024 ? $"{amount / 1024:0.0} MB/s" : $"{amount:0} KB/s"
        : "—";
    public static string Lag(int? ms) => ms is { } value
        ? Tr ? $"{value} ms" : $"{value} մվ"
        : Tr ? "yanıt yok" : "պատասխան չկա";
    public static string SyncOk(int synced, string lag, string speed) => Tr
        ? $"Eşitleme normal. Sunucuda {synced}, gönderilmeyen 0. Gecikme {lag}. Hat {speed}."
        : $"Համաժամեցումը նորմալ է։ Սերվերում {synced}, չուղարկված՝ 0։ Ուշացում {lag}։ Գիծ {speed}։";
    public static string SyncDb => Tr ? "Veritabanı ayarlı değil." : "Բազան կարգավորված չէ։";
    public static string SyncOffline(string? error) => Tr
        ? $"İnternet yok. Program şu an kendi içinde çalışıyor. {error}"
        : $"Ինտերնետ չկա։ Հիմա ծրագիրն աշխատում է տեղում։ {error}";
    public static string SyncPending => Tr ? "Henüz sunucuya gitmemiş çuvallar var." : "Կան պարկեր, որոնք դեռ սերվեր չեն գնացել։";
    public static string SyncLine(int pending, int synced, string lag, string speed, string reason) => Tr
        ? $"Gönderilmeyen {pending}. Sunucuda {synced}. Gecikme {lag}. Hat {speed}. {reason}"
        : $"Չուղարկված՝ {pending}։ Սերվերում {synced}։ Ուշացում {lag}։ Գիծ {speed}։ {reason}";
    public static string SyncIdle => Tr ? "Eşitleme henüz kontrol edilmedi" : "Համաժամեցումը դեռ չի ստուգվել";
    public static string HomeNote => Tr
        ? "Kabul edilenler programda 20 gün durur. 20 günden eski olanlar Backups klasörüne gider ve sunucuda kalır."
        : "Ընդունվածը ծրագրում մնում է 20 օր։ 20 օրից հինը գնում է Backups պանակ և մնում սերվերում։";
    public static string ColBag => Tr ? "Çuval" : "Պարկ";
    public static string ColTrack => Tr ? "Takip" : "Հետագծում";
    public static string ColKilo => Tr ? "Kg" : "Կգ";
    public static string ColType => Tr ? "Tür" : "Տեսակ";
    public static string ColInsurance => Tr ? "Sigorta" : "Ապահովագրություն";
    public static string ColStore => Tr ? "Mağaza" : "Խանութ";
    public static string ColTime => Tr ? "Saat" : "Ժամ";
    public static string ColServer => Tr ? "Sunucu" : "Սերվեր";
    public static string ColCode => Tr ? "Kod" : "Կոդ";
    public static string ColError => Tr ? "Hata" : "Սխալ";
    public static string OnServer => Tr ? "sunucuda" : "սերվերում";
    public static string InQueue => Tr ? "sırada" : "հերթում";
    public static string SyncError => Tr ? "hata" : "սխալ";
    public static string TodayTitle => Tr ? "Bugünkü kabuller" : "Այսօրվա ընդունումներ";
    public static string ReportsTitle => Tr ? "20 günlük kabuller" : "Ընդունումներ 20 օրվա";
    public static string VisitTitle(string title, int count) => Tr
        ? $"{title}: {count}. Çuvalları açmak için satıra basın."
        : $"{title}: {count}։ Սեղմեք տողը՝ պարկերը բացելու համար։";
    public static string VisitHead(uint kod, int count, string track) => Tr
        ? $"Kod {kod} · {count} çuval · takip {track}"
        : $"Կոդ {kod} · {count} պարկ · հետագծում {track}";
    public static string UnsyncedTitle(int count) => count == 0
        ? Tr ? "Sunucuya gitmeyen: boş" : "Սերվեր չուղարկված՝ դատարկ է"
        : Tr ? $"Sunucuya gitmeyen: {count}" : $"Սերվեր չուղարկված՝ {count}";
    public static string LoginSubtitle => Tr ? "Yük kabul" : "Բեռի ընդունում";
    public static string Enter => Tr ? "Giriş" : "Մտնել";
    public static string AccessLevel => Tr ? "Erişim düzeyi" : "Մուտքի մակարդակ";
    public static string Category => Tr ? "Kategori" : "Կատեգորիա";
    public static string OperatorName => Tr ? "Operatör adı" : "Օպերատորի անուն";
    public static string Pin => "PIN";
    public static string FirstPin => Tr
        ? "İlk giriş: Ադմինիստրատոր, PIN 0000. Girişten sonra ayarlardan PIN'i değiştirin."
        : "Առաջին մուտք՝ Ադմինիստրատոր, PIN 0000։ Մուտքից հետո PIN-ը փոխեք կարգավորումներում։";
    public static string PrinterNone => Tr ? "— seçilmedi —" : "— ընտրված չէ —";
    public static string NetworkMark => Tr ? "Ağ" : "Ցանց";
    public static string ScanLooking => Tr ? "Yerel ağda yazıcı aranıyor…" : "Փնտրում եմ տպիչներ տեղական ցանցում…";
    public static string ScanNone => Tr ? "Bu ağda yazdırma portu yanıt vermedi. IP'yi elle yazın." : "Այս ցանցում տպման պորտին ոչ ոք չպատասխանեց։ Գրեք IP-ն ձեռքով։";
    public static string ScanFound(int count) => Tr
        ? $"Bulunan: {count}. Rol doğruysa Kaydet'e basın."
        : $"Գտնվել է՝ {count}։ Եթե դերը ճիշտ է, սեղմեք Պահել։";
    public static string ScanStopped => Tr ? "Arama durdu." : "Որոնումը կանգնեց։";
    public static string PickFoundPrinter => Tr ? "Listeden bulunan yazıcıyı seçin." : "Ընտրեք գտնված տպիչը ցանկից։";
    public static string EnterIp => Tr ? "IP yazın, örneğin 192.168.1.50." : "Գրեք IP, օրինակ 192.168.1.50։";
    public static string PrinterAssigned(string role, string address) => Tr
        ? $"{role}: {address}. Kaydet'e basın."
        : $"{role}: {address}։ Սեղմեք Պահել։";
    public static string Port9100 => Tr ? "port 9100" : "պորտ 9100";
    public static string LabelRole => Tr ? "etiket" : "պիտակներ";
    public static string ScanProgress(int current, int total, int found) => Tr
        ? $"Kontrol {current} / {total}. Bulunan {found}."
        : $"Ստուգված է {current} / {total}։ Գտնված՝ {found}։";
    public static string ReadingNames => Tr ? "Yazıcı adları okunuyor…" : "Կարդում եմ տպիչների անունները…";
    public static string PickOperator => Tr ? "Operatör seçin." : "Ընտրեք օպերատորին։";
    public static string BadPin => Tr ? "PIN yanlış." : "Սխալ PIN։";
    public static string TitleLogin => Tr ? "Giriş" : "Մուտք";
    public static string Save => Tr ? "Kaydet" : "Պահել";
    public static string Close => Tr ? "Kapat" : "Փակել";
    public static string Saved => Tr ? "Ayarlar kaydedildi." : "Կարգավորումները պահվել են։";
    public static string TabFirm => Tr ? "Firma" : "Ընկերություն";
    public static string TabDb => Tr ? "Veritabanı" : "Բազա";
    public static string TabPrinters => Tr ? "Yazıcılar" : "Տպիչներ";
    public static string TabNumbers => Tr ? "Çuval numaraları" : "Պարկերի համարներ";
    public static string TabOperators => Tr ? "Operatörler" : "Օպերատորներ";
    public static string TabPreview => Tr ? "Etiket ve fiş" : "Պիտակ և կտրոններ";
    public static string PreviewLabel => Tr ? "Çuval etiketi" : "Պարկի պիտակ";
    public static string PreviewStore => Tr ? "Mağaza fişi" : "Խանութի կտրոն";
    public static string PreviewFirm => Tr ? "Firma fişi" : "Ընկերության կտրոն";
    public static string PreviewReceipts => Tr ? "Fiş yazıları" : "Գրություններ կտրոնների վրա";
    public static string PreviewHint => Tr
        ? "İşaretli yazı basılır. İşareti kaldırılan yazı etikete ve fişe çıkmaz. Hepsi başlangıçta işaretlidir."
        : "Նշված գրությունը տպվում է։ Հանված նշումը այն հանում է պիտակից և կտրոններից։";
    public static string PartLabelNumber => Tr ? "Çuval numarası" : "Պարկի համար";
    public static string PartLabelDate => Tr ? "Tarih" : "Ամսաթիվ";
    public static string PartLabelBarcode => Tr ? "Barkod" : "Շտրիխկոդ";
    public static string PartLabelStore => Tr ? "Mağaza" : "Խանութ";
    public static string PartLabelMark => Tr ? "Bölüm harfi" : "Բաժնի տառ";
    public static string PartLabelFirm => Tr ? "Firma adı" : "Ընկերության անուն";
    public static string PartLabelKilo => Tr ? "Kilogram" : "Կիլոգրամ";
    public static string PartLabelCode => Tr ? "Müşteri kodu" : "Հաճախորդի կոդ";
    public static string PartReceiptFirm => Tr ? "Firma" : "Ընկերություն";
    public static string PartReceiptBranch => Tr ? "Şube" : "Մասնաճյուղ";
    public static string PartReceiptCopy => Tr ? "Nüsha adı" : "Օրինակի անուն";
    public static string PartReceiptKind => Tr ? "Gönderi türü" : "Ուղարկման տեսակ";
    public static string PartReceiptTrack => Tr ? "Takip" : "Հետագծում";
    public static string PartReceiptDate => Tr ? "Tarih ve saat" : "Ամսաթիվ և ժամ";
    public static string PartReceiptWho => Tr ? "Kabul eden" : "Ով է ընդունել";
    public static string PartReceiptCode => Tr ? "Müşteri Bilgileri ve kodu" : "Հաճախորդի տվյալներ և կոդ";
    public static string PartReceiptName => "Müşteri Adı";
    public static string PartReceiptPhone => "Müşteri Telefon";
    public static string PartReceiptStore => Tr ? "Mağaza ve telefon, altta" : "Խանութ և հեռախոս, ներքևում";
    public static string PartReceiptTable => Tr ? "Çuval tablosu" : "Պարկերի աղյուսակ";
    public static string PartReceiptTotal => Tr ? "Toplam" : "Ընդամենը";
    public static string PartReceiptQr => Tr ? "QR, yalnız mağaza fişi" : "QR, միայն խանութի կտրոն";
    public static string PartReceiptNote => Tr ? "Not, yalnız firma fişi" : "Նշում, միայն ընկերության կտրոն";
    public static string RightTitle => Tr ? "Operatörün hakkı" : "Օպերատորի իրավունքներ";
    public static string RightHint => Tr
        ? "Operatör yazıcıları her zaman seçer. Veritabanını hiç görmez. Diğerleri yalnızca işaretliyken açıktır."
        : "Օպերատորը միշտ կարող է ընտրել տպիչները։ Բազան նա չի տեսնում։ Մնացածը բացվում է միայն նշումով։";
    public static string RightPrinters => Tr ? "Yazıcılar" : "Տպիչներ";
    public static string RightDatabase => Tr ? "Veritabanı" : "Տվյալների բազա";
    public static string RightFirm => Tr ? "Firma, dil, logo ve bölümler" : "Ընկերություն և լոգո";
    public static string RightNumbers => Tr ? "Çuval numaraları" : "Պարկերի համարներ";
    public static string RightOperators => Tr ? "Operatör ekleme ve silme" : "Ավելացնել և ջնջել օպերատորներ";
    public static string RightPreview => Tr ? "Etiket ve fiş görünümü" : "Պիտակի և կտրոնների տեսք";
    public static string Company => Tr ? "Firma adı" : "Ընկերության անուն";
    public static string Branch => Tr ? "Şube" : "Մասնաճյուղ";
    public static string BolumToggles => Tr
        ? "Listede görünen gönderi türleri. İşareti kaldırılan tür kabul ekranında çıkmaz."
        : "Ընդունումը միայն տիր է։";
    public static string OfficeColumn => Tr ? "Şube" : "Մասնաճյուղ";
    public static string OperatorColumn => Tr ? "Kabul eden" : "Ընդունեց";
    public static string Language => Tr ? "Program dili" : "Ծրագրի լեզու";
    public static string LanguageHint => Tr
        ? "Dil programı, etiketi ve fişi değiştirir. Türkçe veya Rusça. Kaydet'e basın. Logo, etiket ve fişte firma adının yanında basılır."
        : "Ծրագիրը հայերեն է։ Կտրոնը և պիտակը՝ թուրքերեն։ Լոգոն տպվում է ընկերության անվան կողքին։";
    public static string ChooseLogo => Tr ? "Logo seç" : "Ընտրել լոգո";
    public static string ClearLogo => Tr ? "Logoyu kaldır" : "Հանել լոգոն";
    public static string LogoTitle => Tr ? "Logo" : "Լոգո";
    public static string LogoBad => Tr ? "Bu dosya logo olarak açılamadı." : "Այս ֆայլը որպես լոգո չի բացվում։";
    public static string UseSsl => Tr ? "SSL kullan" : "Օգտագործել SSL";
    public static string TestConnection => Tr ? "Bağlantıyı dene" : "Ստուգել կապը";
    public static string ServerAddress => Tr ? "Sunucu adresi" : "Սերվերի հասցե";
    public static string Port => Tr ? "Port" : "Պորտ";
    public static string Database => Tr ? "Veritabanı" : "Բազա";
    public static string LoginName => Tr ? "Kullanıcı" : "Մուտքանուն";
    public static string Password => Tr ? "Parola" : "Գաղտնաբառ";
    public static string UnlockDb => Tr ? "Sunucu ayarlarını aç" : "Բացել սերվերի կարգավորումները";
    public static string UnlockDbAsk => Tr ? "Sunucu ayarları parolası" : "Սերվերի գաղտնաբառ";
    public static string UnlockDbDenied => Tr ? "Parola yanlış. Ayarlar kilitli." : "Գաղտնաբառը սխալ է։";
    public static string ReceiptScale => Tr ? "Fiş yazı boyutu, %" : "Կտրոնի տառաչափ, %";
    public static string Connecting => Tr ? "Bağlanılıyor..." : "Միանում եմ...";
    public static string Connected(string table, string client) => Tr
        ? "Bağlantı var. " + table + " " + client + " Kabulün bu veriyi kullanması için Kaydet'e basın."
        : "Կապ կա։ " + table + " " + client + " Սեղմեք «Պահել», որ ընդունումն օգտագործի այս տվյալները։";
    public static string PriemTable => Tr ? "Çuval tablosu" : "Պարկերի աղյուսակ";
    public static string ClientTable => Tr ? "Müşteri tablosu" : "Հաճախորդների աղյուսակ";
    public static string WrittenFields => Tr
        ? "Program yalnız bu sütunlara yazar. Tabloyu kurmaz ve değiştirmez."
        : "Ծրագիրը գրում է միայն այս սյունակներում։";
    public static string WrittenFieldList => Tr
        ? "KODID — çuval numarası\nKOD — müşteri kodu\nKILO — kilogram\nTESLIM_EDEN — mağaza telefonu ve adı\nSIGORTA — sigorta\nNOT1 — not\nTARIH — bu bilgisayarın tarihi\ntrack_code — takip\nBOLUM — bölüm\nsube — şube\nkabul_eden — kabul eden"
        : "mkab — պարկի համար\nmkod — հաճախորդի կոդ\nmkg — կիլոգրամ\nmmal — ապրանք\nteslim_eden — խանութ\nsigorta — ապահովագրություն\nnot1 — նշում\ntarih — ամսաթիվ\ntrack_code — հետագծում\nbolum — տիր\nkabul_eden — ով է ընդունել";
    public static string TableNameBad => Tr
        ? "Tablo adı yalnız harf, rakam ve alt çizgi olabilir."
        : "Աղյուսակի անունը կարող է ունենալ միայն տառեր, թվեր և ընդգծում։";
    public static string TableMissing(string table) => Tr
        ? $"{table} tablosu yok veya gereken sütunlar yok. Program tabloyu oluşturmaz ve değiştirmez."
        : $"«{table}» աղյուսակը չկա կամ անհրաժեշտ սյունակները չկան։";
    public static string TableCreated(string table) => Tr
        ? $"{table} tablosu yoktu, program oluşturdu. Asıl priem_ob kullanılmıyor."
        : $"«{table}» աղյուսակը չկար, ծրագիրը այն ստեղծեց։";
    public static string TrackAdded(string table) => Tr
        ? $"{table} var. track_code kolonu eklendi. Asıl priem_ob kullanılmıyor."
        : $"«{table}» աղյուսակը կա։ Ավելացվել է track_code սյունակը։";
    public static string TableReady(string table) => Tr
        ? $"Kayıt {table} tablosuna gider. Tablo değiştirilmez."
        : $"Գրանցումը գնում է {table} աղյուսակ։ Աղյուսակը չի փոխվում։";
    public static string ClientOk => Tr ? "Müşteri kodu resmi client tablosundan okunur." : "Հաճախորդի կոդը կարդացվում է հաճախորդների աղյուսակից։";
    public static string ClientMissing => Tr ? "Sunucuda client tablosu yok, müşteri kodu kontrol edilemez." : "Սերվերում հաճախորդների աղյուսակը չկա, կոդը ստուգել չի լինի։";
    public static string NeedConnection => Tr ? "Önce adres, veritabanı ve kullanıcıyı doldurun." : "Նախ լրացրեք հասցեն, բազան և մուտքանունը։";
    public static string ConnectionFields => Tr ? "Veritabanı için adres, ad ve kullanıcı gerekir." : "Բազայի համար լրացրեք հասցեն, բազայի անունը և մուտքանունը։";
    public static string PortRange => Tr ? "Port 1 ile 65535 arasında bir sayıdır. MySQL için genelde 3306." : "Պորտը թիվ է 1-ից 65535։ MySQL-ի համար սովորաբար 3306։";
    public static string CheckBagNumbers => Tr ? "Başlangıç, bitiş ve sonraki çuval numarasını kontrol edin." : "Ստուգեք սկիզբը, վերջը և հաջորդ պարկի համարը։";
    public static string LabelPrinter => Tr ? "Etiket yazıcısı" : "Պիտակների տպիչ";
    public static string ReceiptPrinter => Tr ? "Fiş yazıcısı" : "Կտրոնի տպիչ";
    public static string FindNetwork => Tr ? "Ağda ara" : "Գտնել ցանցում";
    public static string ThisLabels => Tr ? "Bu etiket" : "Սա պիտակներն են";
    public static string ThisReceipts => Tr ? "Bu fiş" : "Սա կտրոններն են";
    public static string IpLabels => Tr ? "IP etiketlere" : "IP պիտակների համար";
    public static string IpReceipts => Tr ? "IP fişlere" : "IP կտրոնների համար";
    public static string ManualIp => Tr ? "IP elle" : "IP ձեռքով";
    public static string PrinterHint => Tr
        ? "Önce Windows listesi. «Ağda ara» Argox 214 Plus ve fiş yazıcılarını IP ile arar. Bulunan adres düğmeyle atanır. Sonra Kaydet."
        : "Նախ Windows-ի ցանկն է։ «Գտնել ցանցում» փնտրում է տպիչները IP-ով։ Հետո սեղմեք Պահել։";
    public static string RangeStart => Tr ? "Başlangıç" : "Սկիզբ";
    public static string RangeEnd => Tr ? "Bitiş" : "Վերջ";
    public static string RangeNext => Tr ? "Sonraki numara" : "Հաջորդ համար";
    public static string RestartRange => Tr ? "Baştan başla" : "Սկսել սկզբից";
    public static string LastOnServer => Tr ? "Sunucudaki son numara" : "Վերջին համարը սերվերում";
    public static string RangeExplain => Tr
        ? "Aralığı siz yazarsınız: hangi numaradan hangi numaraya. Program bu sayıyı saklar. Yedek ve 20 günlük arşiv numarayı sıfırlamaz."
        : "Միջակայքը գրում եք դուք։ Ծրագիրը հիշում է ընթացիկ համարը։";
    public static string AskingServer => Tr ? "Sunucuya soruluyor..." : "Հարցնում եմ սերվերին...";
    public static string NoServerNumbers => Tr ? "Bu aralıkta sunucuda henüz numara yok." : "Այս միջակայքում սերվերում համար դեռ չկա։";
    public static string ServerMax(int max) => Tr ? $"Bu aralıkta sunucudaki son numara: {max}." : $"Այս միջակայքում սերվերի վերջին համարը՝ {max}։";
    public static string RangeBad => Tr ? "Aralık sayılarını kontrol edin." : "Ստուգեք միջակայքի թվերը։";
    public static string RangeEmpty => Tr ? "Boş numara kalmadı." : "Ազատ համարներ չկան։";
    public static string RangeFree(int remaining, int next) => Tr
        ? $"Boş numara: {remaining}. Sonraki çuval {next} alır."
        : $"Ազատ համարներ՝ {remaining}։ Հաջորդ պարկը կստանա {next}։";
    public static string Add => Tr ? "Ekle" : "Ավելացնել";
    public static string ChangePin => Tr ? "PIN değiştir" : "Փոխել PIN-ը";
    public static string Delete => Tr ? "Sil" : "Ջնջել";
    public static string Cancel => Tr ? "Vazgeç" : "Չեղարկել";
    public static string NewOperator => Tr ? "Yeni operatör" : "Նոր օպերատոր";
    public static string OperatorNeed => Tr ? "Ad ve dört haneli PIN gerekir." : "Պետք են անուն և չորս թվանշանի PIN։";
    public static string TitleOperator => Tr ? "Operatör" : "Օպերատոր";
    public static string DeleteOperator(string name) => Tr ? $"{name} silinsin mi?" : $"Ջնջե՞լ {name} օպերատորին։";
    public static string NewPin => Tr ? "Yeni PIN" : "Նոր PIN";
    public static string RepeatPin => Tr ? "PIN tekrar" : "PIN-ի կրկնություն";
    public static string PinMismatch => Tr ? "İki alan da aynı dört haneli PIN olmalı." : "Երկու դաշտերում էլ նույն չորս թվանշանի PIN-ն է։";
    public static string NeedOperatorName => Tr ? "Operatör adını yazın." : "Գրեք օպերատորի անունը։";
    public static string NeedCategory => Tr ? "Kategori yazın." : "Գրեք կատեգորիան։";
    public static string BadLevel => Tr ? "Bilinmeyen erişim düzeyi." : "Անհայտ մուտքի մակարդակ։";
    public static string PinFour => Tr ? "PIN dört hanedir." : "PIN-ը չորս թվանշան է։";
    public static string NameExists => Tr ? "Bu ad zaten var." : "Այս անունն արդեն կա։";
    public static string OperatorMissing => Tr ? "Operatör bulunamadı." : "Օպերատորը չի գտնվել։";
    public static string CannotDeleteSelf => Tr ? "Şu an giriş yapan operatör silinemez." : "Հնարավոր չէ ջնջել հիմա մտած օպերատորին։";
    public static string NeedOneAdmin => Tr ? "En az bir ana yönetici kalmalı." : "Պետք է մնա առնվազն մեկ գլխավոր ադմինիստրատոր։";
    public static string NeedStorePhone => Tr ? "Mağaza telefonunu yazın." : "Գրեք խանութի հեռախոսը։";
    public static string NeedPhoneSeven => Tr
        ? "Telefon numarasını yazın. En az 7 rakam gerekli."
        : "Գրեք հեռախոսահամարը։ Պետք է առնվազն 7 թվանշան։";
    public static string OfflineAccept => Tr
        ? "İnternet yok. Kod bağlantı gelince kontrol edilecek. Kabul programda sürer."
        : "Ինտերնետ չկա։ Կոդը կստուգվի, երբ կապ լինի։ Ընդունումը գնում է ծրագրում։";
    public static string AcceptedOffline => Tr ? "Çevrimdışı kabul edildi" : "Ընդունվել է առանց կապի";
    public static string OfflineNote => AcceptedOffline;
    public static string DuplicateBag(string kodId) => Tr
        ? $"{kodId} numaralı çuval zaten var. Sunucu kabul etmedi. Çuval numarası tek olmalı."
        : $"{kodId} պարկն արդեն բազայում կա։ Սերվերը այն չընդունեց։ Պարկի համարը պետք է եզակի լինի։";
    public static string CodeMissingHold(uint kod) => Tr
        ? $"{kod} kodu yok. Kodu değiştirin. Yük internetsiz kabul edilmişti."
        : $"{kod} կոդը բազայում չկա։ Կոդը պետք է փոխել։ Բեռն ընդունվել էր առանց ինտերնետի։";
    public static string NewClientCode => Tr ? "Yeni müşteri kodu" : "Հաճախորդի նոր կոդ";
    public static string NeedStoreName => Tr ? "Mağaza adını yazın." : "Գրեք խանութի անունը։";
    public static string StoreTooLong(int length) => Tr
        ? $"Mağaza adı {length} karakter. En fazla {CargoRules.StoreNameMax}."
        : $"Խանութի անունը {length} նիշ է։ Առավելագույնը {CargoRules.StoreNameMax}։";
    public static string NeedType => Tr ? "Tür seçin: avia, tır, emanet, paket veya ihracat." : "Ընդունումը միայն տիր է։";
    public static string InsuranceNumber => Tr ? "Sigorta tam sayıdır. Varsayılan 10, başka sayı veya 0 yazılabilir." : "Ապահովագրությունը ամբողջ թիվ է։ Սկզբում 10 է, կարելի է այլ թիվ կամ 0։";
    public static string NoteTooLong => Tr ? "Not 100 karakterden uzun." : "Նշումը 100 նիշից երկար է։";
    public static string KiloFormat => Tr ? "Kilogramı sayı yazın, küsurat nokta ile. Örneğin 12.5." : "Կիլոգրամը գրեք թվով, կոտորակը՝ կետով։ Օրինակ 12.5։";
    public static string CommaNotAllowed => Tr ? "Virgül yazılmaz. Nokta kondu." : "Ստորակետ գրել չի կարելի։ Դրվել է կետ։";
    public static string KiloLong => Tr ? "Ağırlık 11 karakterden uzun." : "Քաշը 11 նիշից երկար է։";
    public static string KiloZero => Tr ? "Ağırlık sıfırdan büyük olmalı." : "Քաշը պետք է զրոյից մեծ լինի։";
    public static string RangeNegative => Tr ? "Çuval numaraları eksi olamaz." : "Պարկերի համարները չեն կարող բացասական լինել։";
    public static string RangeEndSmall => Tr ? "Aralık sonu başlangıçtan küçük." : "Միջակայքի վերջը սկզբից փոքր է։";
    public static string RangeNextSmall => Tr ? "Sonraki numara başlangıçtan küçük." : "Հաջորդ համարը միջակայքի սկզբից փոքր է։";
    public static string RangeNextFar => Tr ? "Sonraki numara aralık sonundan ileri." : "Հաջորդ համարը միջակայքի վերջից առաջ է։";
    public static string NoLabelPrinter => Tr ? "Ayarlarda etiket yazıcısı seçilmedi." : "Կարգավորումներում պիտակների տպիչը ընտրված չէ։";
    public static string NoReceiptPrinter => Tr ? "Ayarlarda fiş yazıcısı seçilmedi." : "Կարգավորումներում կտրոնի տպիչը ընտրված չէ։";
    public static string PrinterMissing(string name) => Tr ? $"«{name}» yazıcısı Windows'ta yok." : $"«{name}» տպիչը Windows-ում չկա։";
    public static string NoLabelPage => Tr ? "Yazıcı etiket sayfası vermedi." : "Տպիչը պիտակի թերթ չտվեց։";
    public static string NoReceiptPage => Tr ? "Yazıcı fiş sayfası vermedi." : "Տպիչը կտրոնի թերթ չտվեց։";
    public static string PrinterSilent(string kind, string address) => Tr ? $"{kind} yazıcısı {address} yanıt vermiyor." : $"{kind} տպիչը {address} չի պատասխանում։";
    public static string KindLabels => Tr ? "etiket" : "պիտակների";
    public static string KindReceipts => Tr ? "fiş" : "կտրոնների";
    public static string NoServer => Tr ? "Sunucuyla bağlantı yok." : "Սերվերի հետ կապ չկա։";
    public static string BadLogin => Tr ? "Sunucu kullanıcıyı veya parolayı reddetti." : "Սերվերը մերժեց մուտքանունը կամ գաղտնաբառը։";
    public static string BadDatabase => Tr ? "Sunucuda böyle bir veritabanı yok." : "Այսպիսի բազա սերվերում չկա։";
    public static string BadTable => Tr ? "Sunucuda gereken tablo yok." : "Սերվերում անհրաժեշտ աղյուսակը չկա։";
    public static string Timeout => Tr ? "Sunucu zamanında yanıt vermedi." : "Սերվերը ժամանակին չպատասխանեց։";
    public static string UpdateOffer(Version remote, Version current) => Tr
        ? $"GitHub'da {remote} var. Sizde {current}. İndirip program değiştirilsin mi?"
        : $"GitHub-ում կա {remote} տարբերակը։ Ձեզ մոտ {current} է։ Ներբեռնե՞լ և փոխարինել ծրագիրը։";
    public static string UpdateTitle => Tr ? "Güncelleme" : "Թարմացում";
    public static string UpdateFailed => Tr ? "Güncelleme indirilemedi.\n" : "Թարմացումը չներբեռնվեց։\n";
    public static string UpdateMissingFile => Tr ? "Çalışan programın dosyası bulunamadı." : "Գործարկված ծրագրի ֆայլը չի գտնվել։";
    public static string UpToDate(Version current) => Tr
        ? $"Güncelleme gerekmez. Son sürüm yüklü: {current}."
        : $"Թարմացում պետք չէ։ Կանգնած է վերջին տարբերակը {current}։";
    public static string UpdateCheckFailed => Tr ? "GitHub kontrol edilemedi.\n" : "GitHub-ը չստուգվեց։\n";
    public static string UpdateBusy => Tr ? "Kontrol zaten sürüyor." : "Ստուգումն արդեն գնում է։";
    public static string UpdateProgress(int doneMb, int totalMb) => Tr
        ? (totalMb > 0 ? $"Güncelleme indiriliyor: {doneMb} / {totalMb} MB" : $"Güncelleme indiriliyor: {doneMb} MB")
        : (totalMb > 0 ? $"Թարմացումը ներբեռնվում է՝ {doneMb} / {totalMb} ՄԲ" : $"Թարմացումը ներբեռնվում է՝ {doneMb} ՄԲ");
    public static string UpdateAskAdmin => Tr
        ? "Dosya indi. Windows yönetici izni soracak. Evet deyin: program kapanır ve yeni sürüm açılır."
        : "Ֆայլը ներբեռնվեց։ Windows-ը թույլտվություն կխնդրի։ Սեղմեք Այո. ծրագիրը կփակվի և նորից կբացվի։";
    public static string UpdateNeedAdmin => Tr
        ? "Güncelleme Program Files içine yazmak için yönetici izni ister. Pencerede Evet denmezse sürüm değişmez."
        : "Ծրագիրը փոխելու համար Windows-ը թույլտվություն կխնդրի։ Եթե սեղմեք Ոչ, տարբերակը չի փոխվի։";
    public static string DeletePicked => Tr ? "Seçilenleri sil" : "Ջնջել ընտրվածները";
    public static string WholeBatch => Tr ? "Tüm parti" : "Ամբողջ խմբաքանակը";
    public static string DeleteNone => Tr ? "Silmek için çuval işaretleyin." : "Նշեք պարկերը, որոնք պետք է ջնջել։";
    public static string TitleDelete => Tr ? "Çuvalı sil" : "Պարկի ջնջում";
    public static string DeleteBagAsk(string kodId) => Tr
        ? $"{kodId} numaralı çuval silinsin mi? Fişe girmez."
        : $"Ջնջե՞լ {kodId} պարկը։ Կտրոնում այն չի լինի։";
    public static string DeleteBagsAsk(int count) => Tr
        ? $"Seçilen {count} çuval silinsin mi? Fişe girmez."
        : $"Ջնջե՞լ ընտրված {count} պարկը։ Կտրոնում չեն լինի։";
    public static string ContentsTitle => Tr ? "Mal listesi" : "Պարկի կազմ";
    public static string ContentsClear => Tr ? "Temizle" : "Մաքրել";
    public static string ContentsSaveBag => Tr ? "Kabul et" : "Ընդունել";
    public static string ContentsEdit => Tr ? "Düzenle" : "Խմբագրել";
    public static string ContentsRequired => Tr
        ? "TIR ve İhracat için en az bir mal satırı gerekli."
        : "Ապրանքի տողը պարտադիր չէ։";
    public static string ItemNameLong => Tr ? "Ürün adı en fazla 120 karakter." : "Ապրանքի անունը 120 նիշից երկար չպետք է լինի։";
    public static string ItemLinesMax => Tr ? "Bir çuvalda en fazla 50 satır." : "Պարկում 50 տողից ավելի չի կարող լինել։";
    public static string ItemQtyBad => Tr ? "Miktar 0'dan büyük olmalı. Örnek: 12.5" : "Քանակը պետք է 0-ից մեծ լինի։ Օրինակ 12.5";
    public static string InvoiceNoLabel => Tr ? "Fatura no" : "Ֆակտուրայի համար";
    public static string InvoiceDateFull => Tr ? "Fatura kesim tarihi" : "Ֆակտուրայի դուրսգրման ամսաթիվ";
    public static string AddGoodsTip => Tr ? "Mal satırı ekle" : "Ավելացնել ապրանք";
    public static string TipClientCode => Tr ? "Ad, telefon veya son rakamlar. Enter seçer." : "Անուն, հեռախոս կամ վերջին թվերը։ Enter-ը ընտրում է։";
    public static string TipCheckCode => Tr ? "Listede yoksa yeni müşteri ekler." : "Եթե ցանկում չկա, ավելացնում է նոր հաճախորդ։";
    public static string TipStorePhone => Tr ? "Mağaza telefonu. Yoksa boş bırakın." : "Խանութի հեռախոսը։ Չկա՝ թողեք դատարկ։";
    public static string TipStoreName => Tr ? "Mağazanın adı." : "Խանութի անուն.";
    public static string TipType => Tr ? "Gönderinin türü." : "Ուղարկման տեսակը։";
    public static string TipNote => Tr ? "Çuvala not." : "Նշում պարկի մասին։";
    public static string TipKilos => Tr ? "Ağırlık, kilogram." : "Քաշը կիլոգրամով։";
    public static string TipInvoice => Tr ? "Fatura numarası." : "Ֆակտուրայի համար։";
    public static string TipGoodsName => Tr ? "Malın adı." : "Ապրանքի անունը։";
    public static string TipQty => Tr ? "Malın miktarı." : "Ապրանքի քանակը։";
    public static string TipUnit => Tr ? "Ölçü birimi." : "Չափման միավորը։";
    public static string RemoveLineTip => Tr ? "Satırı sil" : "Ջնջել տողը";
    public static string DeleteBagTip => Tr ? "Çuvalı sil" : "Ջնջել պարկը";
    public static string GoodsName => Tr ? "Ürün adı" : "Ապրանքի անուն";
    public static string GoodsQty => Tr ? "Miktar" : "Քանակ";
    public static string GoodsUnit => Tr ? "Birim" : "Միավոր";
    public static string InvoiceDateLabel => Tr ? "Fatura tarihi" : "Ֆակտուրայի ամսաթիվ";
    public static string InvoiceNoLong => Tr ? "Fatura numarası en fazla 40 karakter." : "Ֆակտուրայի համարը 40 նիշից երկար չպետք է լինի։";
    public static string InvoiceDateBad => Tr ? "Fatura tarihini gün.ay.yıl yazın. Örnek: 18.11.2026" : "Ֆակտուրայի ամսաթիվը գրեք օր.ամիս.տարի։ Օրինակ 18.11.2026";
    public static string InvoiceColumnsMissing => Tr
        ? "Sunucudaki mal tablosunda fatura sütunları yok. invoice_no ve invoice_date eklenmeli."
        : "Սերվերի ապրանքների աղյուսակում ֆակտուրայի սյունակներ չկան։ Պետք են invoice_no և invoice_date։";
    public static string UnitAdet => Tr ? "Adet" : "Հատ";
    public static string UnitKg => "Kg";
    public static string UnitLitre => Tr ? "Litre" : "Լիտր";
    public static string UnitMetre => "MT";
    public static string UnitPair => "ÇFT";
    public static string UnitLabel(string unit) => ItemUnitCode(unit) switch
    {
        "kg" => "kg",
        "litre" => Tr ? "litre" : "լիտր",
        "mt" => "MT",
        "cift" => "ÇFT",
        _ => Tr ? "adet" : "հատ",
    };
    private static string ItemUnitCode(string unit) => CargoRules.ItemUnit(unit);
    public static string ItemsTableMissing => "Sunucuda bag_items tablosu yok";
    public static string MalColumn => "Mal";
    public static string ExportContents => Tr ? "Mal listesini kaydet" : "Պահել կազմը";
    public static string ExportContentsEmpty => Tr ? "Kaydedilecek mal listesi yok." : "Պահելու կազմ չկա։";
    public static string ExportContentsDone => Tr ? "Mal listesi kaydedildi." : "Կազմը պահվել է ֆայլում։";
    public static string LocalDbFailed => Tr ? "Yerel veritabanı açılamadı: " : "Տեղական բազան չբացվեց՝ ";
    public static string OpenFailed => Tr ? "Program açılamadı.\n" : "Ծրագիրը չբացվեց։\n";
}
