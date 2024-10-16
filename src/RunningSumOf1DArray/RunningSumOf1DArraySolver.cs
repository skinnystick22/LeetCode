namespace RunningSumOf1DArray;

public static class RunningSumOf1DArraySolver
{
    public static int[] RunningSum(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }

        return nums;
    }
}