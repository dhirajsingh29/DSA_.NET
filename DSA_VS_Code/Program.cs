#region array

// int[] nums = new int[] { 5, 0, 1, 2, 3, 4 };
// BuildArrayFromPermutation.Build(nums);
// Utility.PrintArray(nums);

// int[] nums = new int[] {1,2,1};
// Utility.PrintArray(ConcatenationOfArray.Concat(nums));

// int[] nums = new int[] {1,2,3,4};
// RunningSumOfArray.Sum(nums);
// Utility.PrintArray(nums);

int[][] accounts = new int[][] 
{
    new int[] {1,5},
    new int[] {7,3},
    new int[] {3,5}
};

Utility.Print("Richest customer wealth", RichestCustomerWealth.GetMaxWealth(accounts));

#endregion