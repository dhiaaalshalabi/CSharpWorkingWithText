namespace WorkingWithText;

public class StringUtils
{
    public static string summerizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;
        var words = text.Split(' ');
        var totalChar = 0;
        var summaryWords = new List<String>();
        foreach (var word in words)
        {
            summaryWords.Add(word);
            totalChar += word.Length + 1;
            if (totalChar > maxLength)
                break;
        }

        // sentence.Substring(0, maxLength);
        return String.Join(" ", summaryWords) + "...";
    }
}