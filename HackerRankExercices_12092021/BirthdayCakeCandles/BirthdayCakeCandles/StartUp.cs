using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            int[] candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToArray();

            int result = Result.BirthdayCakeCandles(candles);

            Console.WriteLine(result);
        }
    }

    class Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int BirthdayCakeCandles(int[] candles)
        {
            int maxHigh = 0;
            int numOfCandles = 0;

            for (int i = 0; i < candles.Length; i++)
            {
                if (candles[i] > maxHigh)
                {
                    maxHigh = candles[i];
                    numOfCandles = 1;
                    continue;
                }

                if (candles[i] == maxHigh)
                {
                    numOfCandles++;
                }
            }

            return numOfCandles;
        }
    }
}
