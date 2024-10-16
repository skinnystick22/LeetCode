using System.Text;

namespace ReverseWordsInStringIII;

public static class ReverseWordsInStringIIISolver
{
    public static string ReverseWords(string s)
    {
        var reversedWordStringBuilder = new StringBuilder();
        var wordArray = s.Split(' ');
        foreach (var word in wordArray)
        {
            var wordCharArray = word.ToCharArray();
            Array.Reverse(wordCharArray);
            reversedWordStringBuilder.Append(wordCharArray).Append(' ');
        }

        return reversedWordStringBuilder.ToString().TrimEnd();
    }
}