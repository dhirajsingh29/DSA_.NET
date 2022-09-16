public class ShuffleArray
{
    public static int[] Shuffle_1 (int[] nums, int n)
    {
        int[] res = new int[2 * n];

        for (int i = 0, j = 0; i < n; i++, j += 2)
        {
            res[j] = nums[i];
            res[j + 1] = nums[i + n];
        }

        return res;
    }

    public static void Shuffle_2(int[] nums, int n)
    {
        for (int i = 0; i < n; i++)
        {
            // multiply and mod with 1000 as that is highest number which array can have
            nums[i + n] = nums[i] + (1000 * (nums[i + n] % 1000));
        }

        for (int i = 0, j = 0; i < n; i++, j += 2)
        {
            nums[j] = nums[i + n] % 1000;
            nums[j + 1] = nums[i + n] / 1000;
        }
    }

    public static void Shuffle_3 (int[] nums, int n)
    {
        int mask = 1023;
        int bits = 10;
    
        for (int i = 0; i < n; i++)
        {
            nums[i + n] = (nums[i] & mask) | ((nums[i + n] & mask) << bits); 
        }
    
        for (int i = 0, j = 0; i < n; i++, j += 2)
        {
            nums[j] = nums[i + n] & mask;
            nums[j + 1] = nums[i + n] >> bits;
        }
    }
}