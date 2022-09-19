var algoToRun = Constants.None;

#region Common Variables

bool flag = true;
int[] nums;
string[] tempString;
int numOfElements;

#endregion

while (flag)
{
    Console.Write("\nEnter algo to be run: ");
    Enum.TryParse<Constants>(Console.ReadLine() ?? "None", true, out algoToRun);

    switch (algoToRun)
    {
        #region array

        case Constants.BuildArrayFromPermutation:
            Console.Write("Enter space separated array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);

            SetupAndExecute.BuildArray(nums);
            break;

        case Constants.ConcatenationOfArray:
            Console.Write("Enter space separated array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);

            SetupAndExecute.ConcatenateArrays(nums);
            break;

        case Constants.KidsWithGreatestCandies:
            Console.Write("Enter space separated candies array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);

            Console.Write("Enter extra candies: ");
            int extraCandies = Convert.ToInt32(Console.ReadLine());

            SetupAndExecute.KidsHavingGreatestCandies(candies: nums, extraCandies);
            break;

        case Constants.RichestCustomerWealth:
            Console.Write("Provide number of customers: ");
            int numOfCustomers = Convert.ToInt32(Console.ReadLine());

            int[][] accounts = new int[numOfCustomers][];
            for (int i = 0; i < numOfCustomers; i++)
            {
                Console.Write("Enter space separated amounts array per client: ");
                tempString = Console.ReadLine()!.Split(' ');
                nums = Array.ConvertAll<string, int>(tempString, int.Parse);
                accounts[i] = nums;
            }

            SetupAndExecute.RichestCustomer(accounts);
            break;

        case Constants.RunningSumOfArray:
            Console.Write("Enter space separated array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);

            SetupAndExecute.RunningSum(nums);
            break;

        case Constants.ShuffleArray:
            Console.Write("Enter space separated array elements: ");
            tempString = Console.ReadLine()!.Split(' ');
            nums = Array.ConvertAll<string, int>(tempString, int.Parse);
            
            Console.Write("Number of elements(2n): ");
            numOfElements = Convert.ToInt32(Console.ReadLine());

            SetupAndExecute.ShufflingArray(nums, numOfElements);
            break;
        #endregion

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