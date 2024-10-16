using NumberOfWaysToSplitArray;

namespace NumberOfWaysToSplitArrayTest;

public class NumberOfWaysToSplitArrayTests
{
    [Theory]
    [InlineData(2, new[] { 10, 4, -8, 7 })]
    [InlineData(2, new[] { 2, 3, 1, 0 })]
    public void Test_GivenArrayReturnsExpected(int expected, int[] nums)
    {
        var result = NumberOfWaysToSplitArraySolver.WaysToSplitArray(nums);
        Assert.Equal(expected, result);
    }
}