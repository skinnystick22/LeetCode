using System;

namespace ReverseOnlyLetters;

public static class ReverseOnlyLettersSolver
{
    public static string ReverseOnlyLetters(string s)
    {
        var arr = s.ToCharArray();
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetter(arr[left]))
            {
                left++;
            }
            else if (!char.IsLetter(arr[right]))
            {
                right--;
            }
            else
            {
                // Swap the letters
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }

        return new string(arr);
    }
}