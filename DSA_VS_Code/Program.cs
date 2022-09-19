// int[] nums = new int[] { 5, 0, 1, 2, 3, 4 };
// BuildArrayFromPermutation.Build(nums);

// int[] nums = new int[] {1,2,1};
// Utility.PrintArray(ConcatenationOfArray.Concat(nums));

// Utility.PrintArray(nums);

var algoToRun = Constants.Sqrt;

#region Common Variables

bool flag = true;
int[] nums;
string[] tempString;

#endregion


while (flag)
{
    Console.Write("\nEnter algo to be run: ");
    Enum.TryParse<Constants>(Console.ReadLine() ?? "None", true, out algoToRun);

    switch (algoToRun)
    {
        #region searching

        case Constants.Sqrt:
            Console.Write("Enter number to calculate square root: ");
            int numForSqrt = Convert.ToInt32(Console.ReadLine());
            SetupAndExecute.Sqrt(numForSqrt);
            break;

        case Constants.TwoSumSortedArray:            
            Console.Write("Enter space separated array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);

            Console.Write("Enter target sum: ");
            int targetSum = Convert.ToInt32(Console.ReadLine());

            SetupAndExecute.TwoSumSortedArray(nums, targetSum);
            break;

        #endregion

        default:
            flag = false;
            break;
    }
}