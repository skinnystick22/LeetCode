namespace KRadiusSubArrayAverages;

public static class KRadiusSubArrayAveragesSolver
{
    public static int[] GetAverages(int[] nums, int k)
    {
        if (k == 0)
            return nums;

        var windowSize = k * 2 + 1;
        var n = nums.Length;
        var averages = new int[n];
        Array.Fill(averages, -1);

        if (windowSize > n)
            return averages;

        var prefix = new long[n + 1];
        for (var i = 0; i < n; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        for (int i = k; i < (n - k); i++)
        {
            var left = i - k;
            var right = i + k;
            var subArraySum = prefix[right + 1] - prefix[left];
            var average = (int)(subArraySum / windowSize);
            averages[i] = average;
        }

        return averages;
    }
}