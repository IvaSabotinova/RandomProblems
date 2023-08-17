
Console.WriteLine(string.Join(", ", SumOfTwoNumber(new int[] { 1, -2, 3, 8, 9, 10, 11, 0, 7, 4, 13 }, 11)));
static List<(int, int)> SumOfTwoNumber(int[] array, int number)
{
    List<(int, int)> list = new List<(int, int)>();
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] + array[j] == number)
            {
                list.Add((i, j));
            }
        }
    }
    return list;
}


////ChatGPT version - not covering all cases

//int[] nums1 = { 1, -2, 3, 8, 9, 10, 11, 0, 7, 4, 13 };
//int target1 = 11;
//int[] result1 = TwoSum(nums1, target1);
//Console.WriteLine(string.Join(", ", result1));  // Output: 0, 1

//int[] nums2 = { 3, 2, 4 };
//int target2 = 6;
//int[] result2 = TwoSum(nums2, target2);
//Console.WriteLine(string.Join(", ", result2));  // Output: 1, 2
// static int[] TwoSum(int[] nums, int target)
//{
//    // Create a dictionary to store the complement values and their indices
//    Dictionary<int, int> complementDict = new Dictionary<int, int>();

//    // Iterate through the array
//    for (int i = 0; i < nums.Length; i++)
//    {
//        int complement = target - nums[i];

//        // Check if the complement exists in the dictionary
//        if (complementDict.ContainsKey(complement))
//        {
//            // Return the indices of the two numbers that add up to the target
//            return new int[] { complementDict[complement], i };
//        }

//        // Add the current number and its index to the dictionary
//        if (!complementDict.ContainsKey(nums[i]))
//        {
//            complementDict.Add(nums[i], i);
//        }
//    }

//    // If no valid pair is found, return an empty array
//    return new int[0];
//}