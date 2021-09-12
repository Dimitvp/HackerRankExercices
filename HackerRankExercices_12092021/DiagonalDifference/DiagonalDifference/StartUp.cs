using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.DiagonalDifference(arr);

            Console.WriteLine(result);
        }
    }

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftToRightDiagonal = 0;
            int rightToLeftDiagonal = 0;
            int leftDiagonalPosition = 0;
            int rightDiagonalPostion = arr.Count;

            for (int i = 0; i < arr.Count; i++)
            {
                leftToRightDiagonal += arr[i].IndexOf(leftDiagonalPosition);
                rightToLeftDiagonal += arr[i].IndexOf(rightDiagonalPostion);

                leftDiagonalPosition++;
                rightDiagonalPostion--;
            }

            return Math.Abs(leftToRightDiagonal - rightToLeftDiagonal);
        }

    }
}
