using System;
using System.Linq;

namespace MinMaxSum
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

            Result.MiniMaxSum(arr);
        }
    }

    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void MiniMaxSum(int[] arr)
        {
            //Solution 1 with Time complexity: O(N)
            long minElement = 0, maxElement = 0, sum = 0;

            minElement = arr[0];
            maxElement = minElement;
            sum = minElement;

            for (int i = 1; i < arr.Length; i++)
            {

                sum += arr[i];

                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }

                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }

            Console.WriteLine((sum - maxElement) + " " +
                              (sum - minElement));

            //Solution 2 with Time complexity: O(NlogN)
            //long min_value = 0;
            //long max_value = 0;
            //int n = arr.Length;

            //Array.Sort(arr);
            //int j = n - 1;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    min_value += arr[i];

            //    max_value += arr[j];
            //    j--;
            //}

            //Console.WriteLine(
            //    min_value + " "
            //    + max_value);
        }

    }
}
