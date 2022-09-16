public static class Utility
{
    public static void PrintArray (int[] nums)
    {
        Console.WriteLine($"index\tnums");

        foreach (var (num, index) in nums.WithIndex())
        {
            Console.WriteLine($"{index}\t{num}");
        }
    }
}