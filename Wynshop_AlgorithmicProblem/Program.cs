namespace Wynshop_AlgorithmicProblem
{
    // C# program to find longest
    // even sum subsequence.
    using System;

    //    The approach to the problem can be shorted down to points:

    //1.Sum up all positive numbers
    //2. If the sum is even then that will be the max sum possible
    //3. If the sum is not even then either subtract a positive odd number from it, or add a negative odd.
    //-Find maximum max odd of negative odd numbers, hence sum+a[I] (as a[I] is itself negative) 
    //-Find minimum min odd of positive odd numbers, hence sum-a[I]. 
    //-The maximum of the both the results will be the answer.

    class GFG
    {

        // Returns sum of maximum even sum
        // subsequence
        static int maxEvenSum(List<int> arr, int n)
        {

            // Find sum of positive numbers
            int pos_sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] > 0)
                {
                    pos_sum += arr[i];
                }                    
            }                

            // If sum is even, it is our
            // answer
            if (pos_sum % 2 == 0)
            {
                return pos_sum;
            }                

            // Traverse the array to find the
            // maximum sum by adding a
            // positive odd or subtracting a
            // negative odd
            int ans = int.MinValue;

            for (int i = 0; i < n; ++i)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] > 0)
                    {
                        ans = (ans > (pos_sum - arr[i]))
                          ? ans : (pos_sum - arr[i]);
                    }
                    else
                    {
                        ans = (ans > (pos_sum + arr[i]))
                            ? ans : (pos_sum + arr[i]);
                    }
                }
            }

            return ans;
        }

        public static void Main()
        {
            //List<int> list = new List<int> { -2, 2, -3, 1 };
            //List<int> list = new List<int> { 10, 8, 6, -5, 7 };
            // List<int> list = new List<int>{ 0, 50 ,10, 18 };
            //List<int> list = new List<int>{ -2, 7, 10, 0, -4, -55 };
            //List<int> list = new List<int>{ 11, -50, 50, 80, -3, -5 };
            //List<int> list = new List<int>{ -50, 50, 80, 11 };
            List<int> list = new List<int> { 15, 35, 45};

            Console.WriteLine(maxEvenSum(list, list.Count));

        }
    }
}