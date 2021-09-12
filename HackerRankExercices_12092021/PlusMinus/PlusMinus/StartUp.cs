using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

            Result.PlusMinus(arr);
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void PlusMinus(int[] arr)
        {
            decimal positiveValuesRatio = 0.0M;
            decimal negativeValuesRatio = 0.0M;
            decimal zeroRatio = 0.0M;

            decimal positiveCount = arr.Where(p => p > 0).Count();
            decimal negativeCount = arr.Where(n => n <0).Count();

            if (arr.Contains(0))
            {
                zeroRatio = Math.Round((decimal)arr.Where(n => n == 0).Count() / (decimal)arr.Length, 5);
            }

            positiveValuesRatio = Math.Round(positiveCount / arr.Length, 5);
            negativeValuesRatio = Math.Round(negativeCount / arr.Length, 5);

            Console.WriteLine(positiveValuesRatio);
            Console.WriteLine(negativeValuesRatio);
            Console.WriteLine(zeroRatio);
        }

    }
}
