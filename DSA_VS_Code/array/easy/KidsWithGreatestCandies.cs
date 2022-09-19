public class KidsWithGreatestCandies
{
    public static IList<bool> KidsWithCandies (int[] candies, int extraCandies)
    {
        int max = candies.Max();

        bool[] res = new bool[candies.Length];
    
        for (int i = 0; i < candies.Length; i++)
        {
            res[i] = candies[i] + extraCandies >= max ? true : false;
        }
    
        return res;
    }
}