//Logika

//-Berilgan jumlani xohlagancha qismlarga ajrating ( gap, so'z va hk ) va quyidagilarni tekshiring
//- CalcalateIfLessThan500 - split (, . ! ? ) shundan uzunligini hisoblaymiz
//- CalculateIfHasExtremeDoubleWords - split (, . ! ? ), distint so'zlar sonidan array qilib iterate qilib, barcha so'zlarda nechtaligini sanaymiz, length / 5 < count 
//- CalculateIfFirstWordCapital - split ( . ! ? ), gaplarni iterate qilib, birinchi so'zni 2 ta substring va to upper va to lower
//- CalculateIfOtherWordsIsLower - split ( . ! ? ), gaplarni iterate qilib, index + 1, to lower ga tengligi
//- CalculateIfAllWordsLessThan20Chars - split ( . ! ? ' ' ) -so'zlarni iterate qilib, har bittasini uzunligi 20 dan kichikligi

// KISS - Keep It Stupid Simple

var document = new Document
{
    Content = "Lorem ipsum dolor sit amet consectetursdfsdfsdfsdfsdfsdfsdfsdfsd adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!"
};
var analyzer = new DocumentAnalyzer();

analyzer.Analyze(document);
Console.WriteLine(document.Score);

// Model
// Document modelini yaratish(Content, Score )
public class Document
{
    public string Content;
    public int Score = 100;
}

// Service
// DocumentAnalyzer servicini yaratish( Analiz )
public class DocumentAnalyzer
{
    public int Analyze(Document document)
    {
        CalcalateIfLessThan500(document);
        CalculateIfHasExtremeDoubleWords(document);
        CalculateIfFirstWordCapital(document);
        CalculateIfOtherWordsIsLower(document);
        CalculateIfAllWordsLessThan20Chars(document);

        return document.Score;
    }

    public void CalcalateIfLessThan500(Document document)
    {
        var words = document.Content.Split(',', '.', '!', '?');
        if (words.Length < 500)
            document.Score -= 5;
    }

    public void CalculateIfHasExtremeDoubleWords(Document document)
    {
        var words = document.Content.Split(',', '.', '!', '?', ' ');
        var distinctWords = words.Distinct().ToList();
        foreach (var distinctWord in distinctWords)
        {
            var count = 0;

            foreach (var word in words)
                if (distinctWord == word)
                    count++;

            if (words.Length / 5 < count)
                document.Score -= 5;
        }
    }

    public void CalculateIfFirstWordCapital(Document document)
    {
        var sentences = document.Content.Split('.', '!', '?');
        foreach (var sentence in sentences)
        {
            var words = sentence.Trim().Split(',', ' ');
            if (!string.IsNullOrWhiteSpace(words[0])
                && words[0] != words[0].Substring(0, 1).ToUpper() +
                        words[0].Substring(1).ToLower())
                document.Score -= 5;
        }
    }

    public void CalculateIfOtherWordsIsLower(Document document)
    {
        var sentences = document.Content.Split('.', '!', '?');
        foreach (var sentence in sentences)
        {
            var words = sentence.Trim().Split(',', ' ');
            for (var index = 1; index < words.Length; index++)
            {
                if (!string.IsNullOrWhiteSpace(words[index])
                    && words[index] != words[index].ToLower())
                    document.Score -= 5;
            }
        }
    }

    public void CalculateIfAllWordsLessThan20Chars(Document document)
    {
        var words = document.Content.Split(',', '.', '!', '?', ' ');
        foreach (var word in words)
            if (word.Trim().Length > 20)
                document.Score -= 5;
    }
}