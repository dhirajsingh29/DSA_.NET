public class RichestCustomerWealth
{
    public static int GetMaxWealth (int[][] accounts)
    {
        int max = 0;

        foreach (int[] account in accounts)
        {
            int totalWealth = 0;

            foreach (int amount in account)
            {
                totalWealth += amount;
            }

            max = max > totalWealth ? max : totalWealth;
        }

        return max;
    }
}