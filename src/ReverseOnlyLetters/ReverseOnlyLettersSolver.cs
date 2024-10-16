using System.Text;

namespace ReverseOnlyLetters;

public static class ReverseOnlyLettersSolver
{
    public static string ReverseOnlyLetters(string s)
    {
        StringBuilder sb = new();
        for (var i = s.Length - 1; i >= 0; i--)
        {
            while (sb.Length < s.Length && !char.IsLetter(s[sb.Length]))
                sb.Append(s[sb.Length]);
            if (char.IsLetter(s[i]))
                sb.Append(s[i]);
            while (sb.Length < s.Length && !char.IsLetter(s[sb.Length]))
                sb.Append(s[sb.Length]);
        }

        return sb.ToString();
    }
}