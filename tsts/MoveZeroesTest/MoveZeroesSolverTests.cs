using MoveZeroes;

namespace MoveZeroesTest;

public class MoveZeroesSolverTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1, 0 }, new[] { 1, 0 })]
    [InlineData(new[] { 1, 0, 1 }, new[] { 1, 1, 0 })]
    public void Test_MoveZeroes(int[] nums, int[] expected)
    {
        var result = MoveZeroesSolver.MoveZeroes(nums);
        Assert.Equal(expected, result);
    }
}