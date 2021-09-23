using System;

namespace Staircase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.Staircase(n);
        }
    }

    class Result
    {

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void Staircase(int n)
        {
            char staircaseMaterial = '#';

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String(staircaseMaterial, i + 1).PadLeft(n, ' '));
            }
        }

    }
}
