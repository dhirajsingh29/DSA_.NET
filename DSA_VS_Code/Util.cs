public static class Utility
{
    public static void PrintArray<T> (T[] items)
    {
        Console.WriteLine($"index\tnums");

        foreach (var (item, index) in items.WithIndex())
        {
            Console.WriteLine($"{index}\t{item}");
        }
    }

    public static void Print<T> (string message, T item)
    {
        Console.WriteLine($"{message}: {item}");
    }

    public static void PrintList<T> (IList<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine($"{item}");
        }
    }

    public static void PrintListWithIndex<T> (IList<T> list)
    {
        Console.WriteLine($"index\tnums");

        foreach (var (item, index) in list.WithIndex())
        {
            Console.WriteLine($"{index}\t{item}");
        }
    }
}