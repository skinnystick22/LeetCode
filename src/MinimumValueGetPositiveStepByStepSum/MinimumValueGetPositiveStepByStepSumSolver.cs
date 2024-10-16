namespace MinimumValueGetPositiveStepByStepSum;

public static class MinimumValueGetPositiveStepByStepSumSolver
{
    public static int MinStartValue(int[] nums)
    {
        // return MinStartValueWithBinarySearch(nums);
        return MinStartValueWith0Start(nums);
    }

    private static int MinStartValueWith0Start(int[] nums)
    {
        var minVal = 0;
        var total = 0;

        foreach (var num in nums)
        {
            total += num;
            minVal = Math.Min(minVal, total);
        }

        return -minVal + 1;
    }

    private static int MinStartValueWithBinarySearch(int[] nums)
    {
        var n = nums.Length;
        const int m = 100;

        var left = 1;
        var right = m * n + 1;
        while (left < right)
        {
            var mid = (left + right) / 2;
            var total = mid;
            var isValid = true;

            foreach (var num in nums)
            {
                total += num;
                if (total < 1)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}