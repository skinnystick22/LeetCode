using RemoveDuplicatesFromSortedArray;

namespace RemoveDuplicatesFromSortedArrayTest;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new int[0], 0)]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicateTest(int[] nums, int expectedK)
    {
        var solver = new Solution();
        var result = solver.RemoveDuplicates(nums);
        Assert.Equal(expectedK, result);
    }
}