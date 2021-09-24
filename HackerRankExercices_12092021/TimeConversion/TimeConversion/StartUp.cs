using System;

namespace TimeConversion
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = Result.TimeConversion(s);

            Console.WriteLine(result);
        }
    }

    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string TimeConversion(string s)
        {
            DateTime dt;
            bool res = DateTime.TryParse(s, out dt);

            return dt.ToString("HH:mm:ss");
        }
    }
}
