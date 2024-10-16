namespace MergeSortedArray;

public static class MergeSortedArraySolver
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var ansCounter = 0;
        var array1 = nums1[..m];
        var array2 = nums2;

        var array1Counter = 0;
        var array2Counter = 0;

        while (ansCounter < nums1.Length)
        {
            if (array1Counter == array1.Length)
            {
                nums1[ansCounter] = array2[array2Counter];
                ansCounter++;
                array2Counter++;
            }
            else if (array2Counter == array2.Length)
            {
                nums1[ansCounter] = array1[array1Counter];
                ansCounter++;
                array1Counter++;
            }
            else if (array1[array1Counter] == array2[array2Counter])
            {
                nums1[ansCounter] = array1[array1Counter];
                ansCounter++;
                nums1[ansCounter] = array2[array2Counter];
                ansCounter++;
                array1Counter++;
                array2Counter++;
            }
            else if (array1[array1Counter] <= array2[array2Counter])
            {
                nums1[ansCounter] = array1[array1Counter];
                ansCounter++;
                array1Counter++;
            }
            else
            {
                nums1[ansCounter] = array2[array2Counter];
                ansCounter++;
                array2Counter++;
            }
        }
    }

}