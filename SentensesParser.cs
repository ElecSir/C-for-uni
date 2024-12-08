namespace TextAnalysis;

static class SentencesParserTask
{
    public static List<List<string>> ParseSentences(string text)
    {
        var sentencesList = new List<List<string>>();
        // Разделители предложений
        char[] sentenceDelimiters = { '.', '!', '?', ';', ':', '(', ')' };
        string[] rawSentences = text.Split(sentenceDelimiters);

        // Фильтруем предложения, оставляя только непустые и обрезая пробелы
        List<string> sentences = new List<string>();
        foreach (var sentence in rawSentences)
        {
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                sentences.Add(sentence.Trim());
            }
        }

        foreach (var sentence in sentences)
        {
            List<string> words = GetWords(sentence);
            if (words.Count > 0)
            {
                sentencesList.Add(words);
            }
        }

        return sentencesList;
    }

    private static List<string> GetWords(string sentence)
    {
        List<string> words = new List<string>();
        List<char> buffer = new List<char>();

        foreach (char c in sentence)
        {
            if (char.IsLetter(c) || c == '\'')
            {
                buffer.Add(char.ToLower(c));
            }
            else if (buffer.Count > 0)
            {
                // Собираем слово из буфера
                words.Add(new string(buffer.ToArray()));
                buffer.Clear();
            }
        }

        // Добавляем последнее слово, если оно есть
        if (buffer.Count > 0)
        {
            words.Add(new string(buffer.ToArray()));
        }

        return words;
    }
}
