public class BuildArrayFromPermutation
{
    public static void Build (int[] nums)
    {
        /* as per constarints, 0 <= nums[i] <= nums.Length
         * max value for nums.Length can be 1000.
         * Hence, mask is 1023 which has binary represenation of (1111111111).
         */
        int mask = 1023;
        int bits = 10;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = ((nums[nums[i]] & mask) << bits) | (nums[i] & mask);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] >> bits;
        }
    }
}