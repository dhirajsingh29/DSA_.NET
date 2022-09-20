var algoToRun = Constants.None;

#region Common Variables

bool flag = true;

#endregion

while (flag)
{
    Console.Write("\nEnter algo to be run: ");
    Enum.TryParse<Constants>(Console.ReadLine() ?? "None", true, out algoToRun);

    switch (algoToRun)
    {
        #region array

        case Constants.BuildArrayFromPermutation:
            SetupAndExecute.BuildArray();
            break;

        case Constants.ConcatenationOfArray:
            SetupAndExecute.ConcatenateArrays();
            break;

        case Constants.KidsWithGreatestCandies:
            SetupAndExecute.KidsHavingGreatestCandies();
            break;

        case Constants.RichestCustomerWealth:
            SetupAndExecute.RichestCustomer();
            break;

        case Constants.RunningSumOfArray:
            SetupAndExecute.RunningSum();
            break;

        case Constants.ShuffleArray:
            SetupAndExecute.ShufflingArray();
            break;
        #endregion

        #region searching

        case Constants.Sqrt:
            SetupAndExecute.Sqrt();
            break;

        case Constants.TwoSumSortedArray:
            SetupAndExecute.TwoSumSortedArray();
            break;

        case Constants.ValidPerfectSquare:
            SetupAndExecute.ValidPerfectSquare();
            break;
        #endregion

        default:
            flag = false;
            break;
    }
}