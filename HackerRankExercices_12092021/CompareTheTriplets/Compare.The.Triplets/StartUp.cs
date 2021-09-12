using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Compare.The.Triplets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.CompareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));
        }
    }

    class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> results = new List<int>();
            int alicesResult = 0;
            int bobsResult = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alicesResult++;
                }
                else if (a[i] < b[i])
                {
                    bobsResult++;
                }
            }

            results.Add(alicesResult);
            results.Add(bobsResult);

            return results;
        }

    }
}
