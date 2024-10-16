namespace MoveZeroes;

public static class MoveZeroesSolver
{
    public static int[] MoveZeroes(int[] nums)
    {
        int i = 0, j = 1, n = nums.Length;

        while (i < n && j < n)
        {
            var leftVal = nums[i];
            var rightVal = nums[j];
            if (leftVal == 0 && rightVal != 0)
            {
                nums[i] = rightVal;
                nums[j] = leftVal;
                i++;
                j++;
                continue;
            }
            if (leftVal == 0 && rightVal == 0)
            {
                j++;
                continue;
            }

            i++;
            j++;
        }

        return nums;
    }
}