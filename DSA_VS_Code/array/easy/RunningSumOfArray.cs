public class RunningSumOfArray
{
    public static void Sum (int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            nums[i] = sum;
        }
    }
}