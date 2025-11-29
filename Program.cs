using System.Numerics;
using ImageSharpFontBrowserComparator;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

const int fontSize = 30;

var htmlTestOutput = new HtmlTestOutput(fontSize);

await AddSimpleTestCaseAsync("Chinese (Simplified)", "./Fonts/NotoSansSC-Regular.ttf", "敏捷的棕色狐狸跳过了懒狗。简体字测试：繁體轉換");
await AddSimpleTestCaseAsync("Chinese (Simplified) Serif", "./Fonts/NotoSerifSC-Regular.ttf", "敏捷的棕色狐狸跳过了懒狗。简体字测试：繁體轉換");
await AddSimpleTestCaseAsync("Chinese (Hong Kong)", "./Fonts/NotoSansHK-Regular.ttf", "敏捷的棕色狐狸跳過了懶狗。繁體字測試：簡体转换");
await AddSimpleTestCaseAsync("Chinese (Hong Kong) Serif", "./Fonts/NotoSerifHK-Regular.ttf", "敏捷的棕色狐狸跳過了懶狗。繁體字測試：簡体转换");
await AddSimpleTestCaseAsync("Korean Sans", "./Fonts/NotoSansKR-Regular.ttf", "빠른 갈색 여우가 게으른 개를 뛰어넘습니다. 한글 조합: 가갸거겨고교");
await AddSimpleTestCaseAsync("Korean Serif", "./Fonts/NotoSerifKR-Regular.ttf", "빠른 갈색 여우가 게으른 개를 뛰어넘습니다. 한글 조합: 가갸거겨고교");
await AddSimpleTestCaseAsync("Armenian", "./Fonts/NotoSerifArmenian-Regular.ttf", "Արագ շագանակագույն աղվեսը ցատկում է ծույլ շան վրայով։ Ligatures: ﬓ ﬔ ﬕ");
await AddSimpleTestCaseAsync("Malayalam Sans", "./Fonts/NotoSansMalayalam-Regular.ttf", "വേഗമേറിയ തവിട്ടുനിറമുള്ള കുറുക്കൻ മടിയനായ നായയുടെ മുകളിലൂടെ ചാടുന്നു। സംയുക്തം: ക്ക ത്ത്");
await AddSimpleTestCaseAsync("Malayalam Serif", "./Fonts/NotoSerifMalayalam-Regular.ttf", "വേഗമേറിയ തവിട്ടുനിറമുള്ള കുറുക്കൻ മടിയനായ നായയുടെ മുകളിലൂടെ ചാടുന്നു। സംയുക്തം: ക്ക ത്ത്");
await AddSimpleTestCaseAsync("Georgian Sans", "./Fonts/NotoSansGeorgian-Regular.ttf", "სწრაფი ყავისფერი მელა ზარმაცი ძაღლის გადახტომა. ქართული ასოები: ა ბ გ დ ე ვ ზ");
await AddSimpleTestCaseAsync("Georgian Serif", "./Fonts/NotoSerifGeorgian-Regular.ttf", "სწრაფი ყავისფერი მელა ზარმაცი ძაღლის გადახტომა. ქართული ასოები: ა ბ გ დ ე ვ ზ");
await AddSimpleTestCaseAsync("Myanmar Sans", "./Fonts/NotoSansMyanmar-Regular.ttf", "မြန်မာစာ စမ်းသပ်မှု။ ဗျည်းပေါင်းစုံ က ခ ဂ ဃ င စ ဆ ည့် န့်");
await AddSimpleTestCaseAsync("Myanmar Serif", "./Fonts/NotoSerifMyanmar-Regular.ttf", "မြန်မာစာ စမ်းသပ်မှု။ ဗျည်းပေါင်းစုံ က ခ ဂ ဃ င စ ဆ ည့် န့်");
await AddSimpleTestCaseAsync("Ethiopic Sans", "./Fonts/NotoSansEthiopic-Regular.ttf", "ፈጣን ቡናማ ቀበሮ ሰነፍ ውሻ ዘለለ። አማርኛ ፊደላት: ሀ ሁ ሂ ሃ ሄ ህ ሆ");
await AddSimpleTestCaseAsync("Ethiopic Serif", "./Fonts/NotoSerifEthiopic-Regular.ttf", "ፈጣን ቡናማ ቀበሮ ሰነፍ ውሻ ዘለለ። አማርኛ ፊደላት: ሀ ሁ ሂ ሃ ሄ ህ ሆ");
await AddSimpleTestCaseAsync("Tamil Sans", "./Fonts/NotoSansTamil-Regular.ttf", "விரைவான பழுப்பு நிற நரி சோம்பேறி நாய் மீது குதிக்கிறது। கூட்டெழுத்து: க்க த்த");
await AddSimpleTestCaseAsync("Tamil Serif", "./Fonts/NotoSerifTamil-Regular.ttf", "விரைவான பழுப்பு நிற நரி சோம்பேறி நாய் மீது குதிக்கிறது। கூட்டெழுத்து: க்க த்த");
await AddSimpleTestCaseAsync("Lao Sans", "./Fonts/NotoSansLao-Regular.ttf", "ໝາຈິ້ງຈອກສີນ້ຳຕານທີ່ວ່ອງໄວກະໂດດຂ້າມໝາຂີ້ຄ້ານ ສະຫຼັບ: ກ່ ງ່ ຍ່");
await AddSimpleTestCaseAsync("Lao Serif", "./Fonts/NotoSerifLao-Regular.ttf", "ໝາຈິ້ງຈອກສີນ້ຳຕານທີ່ວ່ອງໄວກະໂດດຂ້າມໝາຂີ້ຄ້ານ ສະຫຼັບ: ກ່ ງ່ ຍ່");
await AddSimpleTestCaseAsync("Gujarati Sans", "./Fonts/NotoSansGujarati-Regular.ttf", "ઝડપી ભૂરા રંગનું શિયાળ આળસુ કૂતરા પર કૂદી જાય છે। સંયુક્તાક્ષર: ક્ક ત્ત");
await AddSimpleTestCaseAsync("Gujarati Serif", "./Fonts/NotoSerifGujarati-Regular.ttf", "ઝડપી ભૂરા રંગનું શિયાળ આળસુ કૂતરા પર કૂદી જાય છે। સંયુક્તાક્ષર: ક્ક ત્ત");
await AddSimpleTestCaseAsync("Oriya Sans", "./Fonts/NotoSansOriya-Regular.ttf", "ଦ୍ରୁତ ବାଦାମୀ ରଙ୍ଗର ଶୃଗାଳ ଅଳସୁଆ କୁକୁର ଉପରେ ଡେଇଁପଡେ। ସଂଯୁକ୍ତ: କ୍କ ତ୍ତ");
await AddSimpleTestCaseAsync("Oriya Serif", "./Fonts/NotoSerifOriya-Regular.ttf", "ଦ୍ରୁତ ବାଦାମୀ ରଙ୍ଗର ଶୃଗାଳ ଅଳସୁଆ କୁକୁର ଉପରେ ଡେଇଁପଡେ। ସଂଯୁକ୍ତ: କ୍କ ତ୍ତ");
await AddSimpleTestCaseAsync("Cherokee", "./Fonts/NotoSansCherokee-Regular.ttf", "ᏣᎳᎩ ᎠᏂᏴᏫᏯ ᎠᏰᏟ. Cherokee syllabary: Ꭰ Ꭱ Ꭲ Ꭳ Ꭴ Ꭵ Ꭶ Ꭷ Ꭸ");
await AddSimpleTestCaseAsync("Mongolian", "./Fonts/NotoSansMongolian-Regular.ttf", "ᠮᠣᠩᠭᠣᠯ ᠪᠢᠴᠢᠭ᠌ ᠬᠤᠷᠳᠤᠨ ᠬᠦᠷᠡᠨ ᠦᠬᠡᠷ ᠴᠢᠨᠣ Vertical: ᠠ ᠡ ᠢ ᠣ ᠤ ᠥ ᠦ");
await AddSimpleTestCaseAsync("Latin Sans", "./Fonts/NotoSans-Regular.ttf", "The quick brown fox jumps over the lazy dog. Ligatures: fi fl ffi ffl");
await AddSimpleTestCaseAsync("Runic", "./Fonts/NotoSansRunic-Regular.ttf", "ᚠᚢᚦᚨᚱᚲ ᚷᚹ ᚺᚾᛁᛃ ᛇᛈᛉ ᛋᛏᛒ ᛖᛗᛚ ᛜᛟᛞ Runes Elder Futhark");
await AddSimpleTestCaseAsync("Hebrew Sans", "./Fonts/NotoSansHebrew-Regular.ttf", "השועל החום הזריז קופץ מעל הכלב העצלן. ניקוד: בָּרָא אֱלֹהִים");
await AddSimpleTestCaseAsync("Hebrew Serif", "./Fonts/NotoSerifHebrew-Regular.ttf", "השועל החום הזריז קופץ מעל הכלב העצלן. ניקוד: בָּרָא אֱלֹהִים");
await AddSimpleTestCaseAsync("Thai Sans", "./Fonts/NotoSansThai-Regular.ttf", "สุนัขจิ้งจอกสีน้ำตาลที่รวดเร็วกระโดดข้ามสุนัขขี้เกียจ วรรณยุกต์: ก่ ก้ ก๊ ก๋ ำ ั ิ ็");
await AddSimpleTestCaseAsync("Thai Serif", "./Fonts/NotoSerifThai-Regular.ttf", "สุนัขจิ้งจอกสีน้ำตาลที่รวดเร็วกระโดดข้ามสุนัขขี้เกียจ วรรณยุกต์: ก่ ก้ ก๊ ก๋ ำ ั ิ ็");
await AddSimpleTestCaseAsync("Kannada Sans", "./Fonts/NotoSansKannada-Regular.ttf", "ವೇಗವಾದ ಕಂದು ನರಿ ಸೋಮಾರಿ ನಾಯಿ ಮೇಲೆ ಜಿಗಿಯುತ್ತದೆ. ಸಂಯುಕ್ತ: ಕ್ಕ ತ್ತ");
await AddSimpleTestCaseAsync("Kannada Serif", "./Fonts/NotoSerifKannada-Regular.ttf", "ವೇಗವಾದ ಕಂದು ನರಿ ಸೋಮಾರಿ ನಾಯಿ ಮೇಲೆ ಜಿಗಿಯುತ್ತದೆ. ಸಂಯುಕ್ತ: ಕ್ಕ ತ್ತ");
await AddSimpleTestCaseAsync("Telugu Sans", "./Fonts/NotoSansTelugu-Regular.ttf", "వేగవంతమైన గోధుమ రంగు నక్క సోమరి కుక్క మీద దూకుతుంది। సంయుక్తం: క్క త్త");
await AddSimpleTestCaseAsync("Telugu Serif", "./Fonts/NotoSerifTelugu-Regular.ttf", "వేగవంతమైన గోధుమ రంగు నక్క సోమరి కుక్క మీద దూకుతుంది। సంయుక్తం: క్క త్త");
await AddSimpleTestCaseAsync("Latin Serif", "./Fonts/NotoSerif-Regular.ttf", "The quick brown fox jumps over the lazy dog. Ligatures: fi fl ffi ffl");
await AddSimpleTestCaseAsync("Khmer Sans", "./Fonts/NotoSansKhmer-Regular.ttf", "ឆ្កែកញ្ជ្រោងពណ៌ត្នោតរត់លឿនលោតផ្លោះឆ្កែខ្ជិល។ លេខ: ០១២៣៤៥៦៧៨៉");
await AddSimpleTestCaseAsync("Khmer Serif", "./Fonts/NotoSerifKhmer-Regular.ttf", "ឆ្កែកញ្ជ្រោងពណ៌ត្នោតរត់លឿនលោតផ្លោះឆ្កែខ្ជិល។ លេខ: ០១២៣៤៥៦៧៨៉");
await AddSimpleTestCaseAsync("Gurmukhi Sans", "./Fonts/NotoSansGurmukhi-Regular.ttf", "ਤੇਜ਼ ਭੂਰੀ ਲੂੰਬੜੀ ਆਲਸੀ ਕੁੱਤੇ ਉੱਤੇ ਛਾਲ ਮਾਰਦੀ ਹੈ। ਸੰਯੁਕਤ: ੱਕ ੱਤ");
await AddSimpleTestCaseAsync("Gurmukhi Serif", "./Fonts/NotoSerifGurmukhi-Regular.ttf", "ਤੇਜ਼ ਭੂਰੀ ਲੂੰਬੜੀ ਆਲਸੀ ਕੁੱਤੇ ਉੱਤੇ ਛਾਲ ਮਾਰਦੀ ਹੈ। ਸੰਯੁਕਤ: ੱਕ ੱਤ");
await AddSimpleTestCaseAsync("Sinhala Sans", "./Fonts/NotoSansSinhala-Regular.ttf", "වේගවත් දුඹුරු හිවලා කම්මැලි බල්ලා උඩින් පනිනවා। සංයුක්ත: ක්‍ෂ ඥ්‍ඤ");
await AddSimpleTestCaseAsync("Sinhala Serif", "./Fonts/NotoSerifSinhala-Regular.ttf", "වේගවත් දුඹුරු හිවලා කම්මැලි බල්ලා උඩින් පනිනවා। සංයුක්ත: ක්‍ෂ ඥ්‍ඤ");
await AddSimpleTestCaseAsync("Bengali Sans", "./Fonts/NotoSansBengali-Regular.ttf", "দ্রুত বাদামী শিয়াল অলস কুকুরের ওপর লাফ দেয়। সংযুক্ত: ক্ক ত্ত");
await AddSimpleTestCaseAsync("Bengali Serif", "./Fonts/NotoSerifBengali-Regular.ttf", "দ্রুত বাদামী শিয়াল অলস কুকুরের ওপর লাফ দেয়। সংযুক্ত: ক্ক ত্ত");
await AddSimpleTestCaseAsync("Arabic", "./Fonts/NotoSansArabic-Regular.ttf", "الثعلب البني السريع يقفز فوق الكلب الكسول. الشكل: ﻻ ﻹ ﷲ");
await AddSimpleTestCaseAsync("Ogham", "./Fonts/NotoSansOgham-Regular.ttf", "᚛ᚑᚌᚐᚋ᚜ ᚁᚓᚔᚈᚆᚔ ᚄᚉᚏᚔᚑᚁᚆᚈᚐᚏ Ogham stone inscriptions");
await AddSimpleTestCaseAsync("PT Serif", "./Fonts/PTSerif-Regular.ttf", "The quick brown fox jumps over the lazy dog. Cyrillic: Быстрая бурая лиса");
await AddSimpleTestCaseAsync("Raleway", "./Fonts/Raleway-Regular.ttf", "The quick brown fox jumps over the lazy dog. Ligatures: fi fl ffi ffl");
await AddSimpleTestCaseAsync("Tibetan", "./Fonts/NotoSerifTibetan-Regular.ttf", "བོད་ཡིག་གི་དཔེ་མཚོན། རྐ རྒ རྔ སྐ");
await AddSimpleTestCaseAsync("Canadian Aboriginal", "./Fonts/NotoSansCanadianAboriginal-Regular.ttf", "ᐊᓂᔑᓈᐯᒧᐎᓐ ᑲᐅᐸᐱᑫᔭᐣ Syllabics: ᐁ ᐃ ᐅ ᐊ");
await AddSimpleTestCaseAsync("Devanagari Sans", "./Fonts/NotoSansDevanagari-Regular.ttf", "तेज़ भूरी लोमड़ी आलसी कुत्ते के ऊपर कूद गई। संयुक्त: क्क त्त");
await AddSimpleTestCaseAsync("Devanagari Serif", "./Fonts/NotoSerifDevanagari-Regular.ttf", "तेज़ भूरी लोमड़ी आलसी कुत्ते के ऊपर कूद गई। संयुक्त: क्क त्त");
await AddSimpleTestCaseAsync("Coptic", "./Fonts/NotoSansCoptic-Regular.ttf", "Ⲡⲓⲃⲁϣⲟⲣ ⲛ̀ⲃⲣⲱⲙⲡⲓ ⲉⲧϧⲱⲗϩ ϧⲁⲧⲉⲛ ⲡⲓⲟⲩϩⲟⲣ ⲉⲧⲭⲁⲥⲓⲛⲓ Coptic letters");
htmlTestOutput.Save("index.html");


async Task AddSimpleTestCaseAsync(string name, string fontPath, string text)
{
	var fontCollection = new FontCollection();
	var fontFamily = fontCollection.Add(fontPath);

	var font = fontFamily.CreateFont(fontSize, FontStyle.Regular);
	var richTextOptions = new RichTextOptions(font)
	{
		// HintingMode = HintingMode.Standard,
		Origin = new Vector2(0, 7),
	};

	Directory.CreateDirectory("output");

	var image = new Image<Rgba32>(1600, fontSize + 20, Color.White.ToPixel<Rgba32>());
	image.Mutate(x => x.DrawText(richTextOptions, text, Brushes.Solid(Color.Black)));
	await image.SaveAsync($"output/{name}.png");

	htmlTestOutput.AddTest(name, $"output/{name}.png", text, fontPath);
}
