using MergeSortedArray;
using Xunit;

namespace MergeSortedArrayTest;

public class MergeSortedArrayTests
{
    [Fact]
    public void Merge_BothArraysEmpty_ShouldReturnEmptyArray()
    {
        int[] nums1 = [];
        int[] nums2 = [];
        const int m = 0;
        const int n = 0;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(Array.Empty<int>(), nums1);
    }

    [Fact]
    public void Merge_OneArrayEmpty_ShouldReturnCompleteArray()
    {
        int[] nums1 = [1, 2, 3];
        int[] nums2 = [];
        const int m = 3;
        const int n = 0;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 3 }, nums1);
    }

    [Fact]
    public void Merge_OtherArrayEmpty_ShouldMergeCorrectly()
    {
        int[] nums1 = [0, 0, 0];
        int[] nums2 = [1, 2, 3];
        int m = 0, n = 3;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 3 }, nums1);
    }

    [Fact]
    public void Merge_BothArraysNonEmpty_ShouldMergeCorrectly()
    {
        int[] nums1 = [1, 3, 5, 0, 0, 0];
        int[] nums2 = [2, 4, 6];
        int m = 3, n = 3;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, nums1);
    }

    [Fact]
    public void Merge_WithDuplicates_ShouldMergeCorrectly()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int[] nums2 = [2, 3, 4];
        int m = 3, n = 3;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 2, 3, 3, 4 }, nums1);
    }

    [Fact]
    public void Merge_SecondArrayLarger_ShouldMergeCorrectly()
    {
        int[] nums1 = [1, 1, 1, 0, 0, 0, 0, 0, 0];
        int[] nums2 = [0, 2, 2, 3, 4, 5];
        int m = 3, n = 6;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 0, 1, 1, 1, 2, 2, 3, 4, 5 }, nums1);
    }

    [Fact]
    public void Merge_FirstArrayLarger_ShouldMergeCorrectly()
    {
        int[] nums1 = [1, 2, 3, 4, 5, 0, 0, 0];
        int[] nums2 = [6, 7, 8];
        int m = 5, n = 3;

        MergeSortedArraySolver.Merge(nums1, m, nums2, n);

        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, nums1);
    }
}