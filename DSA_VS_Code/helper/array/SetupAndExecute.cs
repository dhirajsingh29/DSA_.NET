public partial class SetupAndExecute
{
    public static void BuildArray ()
    {
        Console.Write("Enter space separated array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);

        BuildArrayFromPermutation.Build(_nums);
        Utility.PrintArray<int>(_nums);
    }

    public static void ConcatenateArrays ()
    {
        Console.Write("Enter space separated array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);

        int[] ans = ConcatenationOfArray.Concat(_nums);
        Utility.PrintArray<int>(ans);
    }

    public static void KidsHavingGreatestCandies ()
    {
        Console.Write("Enter space separated candies array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);

        Console.Write("Enter extra candies: ");
        int extraCandies = Convert.ToInt32(Console.ReadLine());

        IList<bool> res = KidsWithGreatestCandies.KidsWithCandies(candies: _nums, extraCandies);
        Utility.PrintList<bool>(res);
    }

    public static void RichestCustomer ()
    {
        Console.Write("Provide number of customers: ");
        int numOfCustomers = Convert.ToInt32(Console.ReadLine());

        int[][] accounts = new int[numOfCustomers][];
        for (int i = 0; i < numOfCustomers; i++)
        {
            Console.Write("Enter space separated amounts array per client: ");
            _tempString = Console.ReadLine()!.Split(' ');
            _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);
            accounts[i] = _nums;
        }

        int wealth = RichestCustomerWealth.GetMaxWealth(accounts);
        Utility.Print<int>("Customer with highest wealth", wealth);
    }

    public static void RunningSum ()
    {
        Console.Write("Enter space separated array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);

        RunningSumOfArray.Sum(_nums);
        Utility.PrintArray<int>(_nums);
    }

    public static void ShufflingArray ()
    {
        Console.Write("Enter space separated array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);
            
        Console.Write("Number of elements(2n): ");
        _numOfElements = Convert.ToInt32(Console.ReadLine());

        int[] shuffledArray = ShuffleArray.Shuffle_1(_nums, _numOfElements);
        Console.WriteLine("Shuffling array using basic approach");
        Utility.PrintArray<int>(shuffledArray);

        int[] nums_1 = _nums;
        ShuffleArray.Shuffle_2(nums_1, _numOfElements);
        Console.WriteLine("Shuffling array optimized");
        Utility.PrintArray<int>(nums_1);

        int[] nums_2 = _nums;
        ShuffleArray.Shuffle_3(nums_2, _numOfElements);
        Console.WriteLine("Shuffling array optimized using bits");
        Utility.PrintArray<int>(nums_2);
    }
}