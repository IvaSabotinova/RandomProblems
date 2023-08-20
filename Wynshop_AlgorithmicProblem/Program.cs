namespace Wynshop_AlgorithmicProblem
{
  
    using System;    

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

            // If sum is even, it is our answer
            if (pos_sum % 2 == 0)
            {
                return pos_sum;
            }                

            // Traverse the array to find the maximum sum by adding a
            // positive odd or subtracting a negative odd
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
