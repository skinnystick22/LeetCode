namespace SeparateBlackAndWhiteBalls;

public static class SeparateBlackAndWhiteBallsSolver
{
    public static long MinimumSteps(string s) {
        var left = 0;
        var right = s.Length - 1;
        var result = 0L;

        while (left < right)
        {
            while (left < right && s[left] == '0')
                left += 1;

            while (left < right && s[right] == '1')
                right -= 1;

            result += right - left;
            left++;
            right--;
        }

        return result;
    }
}