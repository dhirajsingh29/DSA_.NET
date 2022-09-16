#region array

// int[] nums = new int[] { 5, 0, 1, 2, 3, 4 };
// BuildArrayFromPermutation.Build(nums);
// Utility.PrintArray(nums);

// int[] nums = new int[] {1,2,1};
// Utility.PrintArray(ConcatenationOfArray.Concat(nums));

// int[] nums = new int[] {1,2,3,4};
// RunningSumOfArray.Sum(nums);
// Utility.PrintArray(nums);

// int[][] accounts = new int[][] 
// {
//     new int[] {1,5},
//     new int[] {7,3},
//     new int[] {3,5}
// };
// Utility.Print("Richest customer wealth", RichestCustomerWealth.GetMaxWealth(accounts));

int[] nums = new int[] {2,5,1,3,4,7};
int n = 3;
// Utility.PrintArray(ShuffleArray.Shuffle_1(nums, n));
// ShuffleArray.Shuffle_2(nums, n);
// ShuffleArray.Shuffle_3(nums, n);
// Utility.PrintArray(nums);

int[] candies = new int[] {2,3,5,1,3};
int extraCandies = 3;
IList<bool> res = KidsWithGreatestCandies.KidsWithCandies(candies, extraCandies);
Utility.PrintListWithIndex<bool>(res);

#endregion