using RunningSumOf1DArray;

namespace RunningSumOf1DArrayTest;

public class RunningSumOf1DArraySolverTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    public void Test_GivenNumsHasRunningSumThatMatchesExpected(int[] nums, int[] expected)
    {
        var result = RunningSumOf1DArraySolver.RunningSum(nums);
        Assert.Equal(expected, result);
    }
}