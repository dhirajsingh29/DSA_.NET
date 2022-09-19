public class SetupAndExecute
{
    public static void Sqrt (int num)
    {
        int res = SquareRoot.Sqrt(num);
        Utility.Print<int>($"Square root of {num}: ", res);
    }

    public static void TwoSumSortedArray (int[] nums, int target)
    {
        int[] res = TwoSumII.FindIndices(nums, target);
        Utility.PrintArray<int>(res);
    }
}