public class SquareRoot
{
    public static int Sqrt (int x)
    {
        int start = 1;
        int end = x / 2;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (mid * mid == x)
            {
                return mid;
            }

            if (mid * mid < x)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        // when number doesn't have perfect square root
        return end;
    }
}