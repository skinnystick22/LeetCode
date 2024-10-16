using KRadiusSubArrayAverages;

namespace KRadiusSubArrayAveragesTest;

public class KRadiusSubArrayAveragesSolverTests
{
    [Theory]
    [InlineData(new[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3, new[] { -1, -1, -1, 5, 4, 4, -1, -1, -1 })]
    [InlineData(new[] { 100_000 }, 0, new[] { 100_000 })]
    [InlineData(new[] { 8 }, 100_000, new[] { -1 })]
    public void Test1(int[] nums, int k, int[] expected)
    {
        var result = KRadiusSubArrayAveragesSolver.GetAverages(nums, k);
        Assert.Equal(expected, result);
    }
}