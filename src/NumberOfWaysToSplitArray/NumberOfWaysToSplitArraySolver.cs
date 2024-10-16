namespace NumberOfWaysToSplitArray;

public static class NumberOfWaysToSplitArraySolver
{
    public static int WaysToSplitArray(int[] nums)
    {
        var leftSum = 0L;
        var total = 0L;

        foreach (var num in nums)
        {
            total += num;
        }

        var ans = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            leftSum += nums[i];
            var rightSum = total - leftSum;
            if (leftSum >= rightSum)
                ans++;
        }

        return ans;
    }
}