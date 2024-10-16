using MinimumValueGetPositiveStepByStepSum;

namespace MinimumValueGetPositiveStepByStepSumTest;

public class UnitTest1
{
    [Theory]
    [InlineData(new [] {-3,2,-3,4,2}, 5)]
    public void Test1(int[] nums, int expected)
    {
        var result = MinimumValueGetPositiveStepByStepSumSolver.MinStartValue(nums);
        Assert.Equal(expected, result);
    }
}