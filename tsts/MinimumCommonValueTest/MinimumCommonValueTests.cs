using MinimumCommonValue;

namespace MinimumCommonValueTest;

public class MinimumCommonValueTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 4 }, 2)]
    [InlineData(new[] { 1, 2, 3, 6 }, new[] { 2, 3, 4, 5 }, 2)]
    public void Test_MinimumCommonValue(int[] nums1, int[] nums2, int expected)
    {
        var result = MinimumCommonValueSolver.GetCommon(nums1, nums2);
        Assert.Equal(expected, result);
    }
}