public class TwoSumII
{
    public static int[] FindIndices (int[] nums, int target)
    {
        int l = 0; 
        int r = nums.Length - 1;

        int[] res = new int[] {-1, -1};

        while (l < r)
        {
            if (nums[l] + nums[r] == target)
            {
                res[0] = l;
                res[1] = r;
                return res;
            }

            if (nums[l] + nums[r] > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return res;
    }
}