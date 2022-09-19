public partial class SetupAndExecute
{
    public static void BuildArray (int[] nums)
    {
        BuildArrayFromPermutation.Build(nums);
        Utility.PrintArray<int>(nums);
    }

    public static void ConcatenateArrays (int[] nums)
    {
        int[] ans = ConcatenationOfArray.Concat(nums);
        Utility.PrintArray<int>(ans);
    }

    public static void KidsHavingGreatestCandies (int[] candies, int extraCandies)
    {
        IList<bool> res = KidsWithGreatestCandies.KidsWithCandies(candies, extraCandies);
        Utility.PrintList<bool>(res);
    }

    public static void RichestCustomer (int[][] accounts)
    {
        int wealth = RichestCustomerWealth.GetMaxWealth(accounts);
        Utility.Print<int>("Customer with highest wealth", wealth);
    }

    public static void RunningSum (int[] nums)
    {
        RunningSumOfArray.Sum(nums);
        Utility.PrintArray<int>(nums);
    }

    public static void ShufflingArray (int[] nums, int n)
    {
        int[] shuffledArray = ShuffleArray.Shuffle_1(nums, n);
        Console.WriteLine("Shuffling array using basic approach");
        Utility.PrintArray<int>(shuffledArray);

        int[] nums_1 = nums;
        ShuffleArray.Shuffle_2(nums_1, n);
        Console.WriteLine("Shuffling array optimized");
        Utility.PrintArray<int>(nums_1);

        int[] nums_2 = nums;
        ShuffleArray.Shuffle_3(nums_2, n);
        Console.WriteLine("Shuffling array optimized using bits");
        Utility.PrintArray<int>(nums_2);
    }
}