namespace MinimumCommonValue;

public static class MinimumCommonValueSolver
{
    public static int GetCommon(int[] nums1, int[] nums2)
    {
        int n = nums1.Length, m = nums2.Length, i = 0, j = 0, ans = 1;

        while (i < n && j < m)
        {
            if (nums1[i] == nums2[j])
            {
                ans = nums1[i];
                break;
            }

            if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                i++;
            }
        }

        return ans;
    }
}