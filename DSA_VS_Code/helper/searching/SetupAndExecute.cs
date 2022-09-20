public partial class SetupAndExecute
{
    public static void Sqrt ()
    {
        Console.Write("Enter number to calculate square root: ");
        int numForSqrt = Convert.ToInt32(Console.ReadLine());

        int res = SquareRoot.Sqrt(numForSqrt);
        Utility.Print<int>($"Square root of {numForSqrt}: ", res);
    }

    public static void TwoSumSortedArray ()
    {
        Console.Write("Enter space separated array elements: ");
        _tempString = Console.ReadLine()!.Split(' ');
        _nums = Array.ConvertAll<string, int>(_tempString, int.Parse);
            
        Console.Write("Enter target sum: ");
        int targetSum = Convert.ToInt32(Console.ReadLine());

        int[] res = TwoSumII.FindIndices(_nums, targetSum);
        Utility.PrintArray<int>(res);
    }

    public static void ValidPerfectSquare ()
    {
        Console.Write("Enter number to find it is valid perfect square or not: ");
        _num = Convert.ToInt32(Console.ReadLine());

        bool res = PerfectSquare.Valid(_num);
        Utility.Print<bool>($"Is {_num} valid perfect square?", res);
    }
}