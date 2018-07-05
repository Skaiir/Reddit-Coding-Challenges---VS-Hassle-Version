using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RedditDailyCoding.Solutions.Day8.Medium
{
    public class IntToSpelledNumber
    {

        static readonly private string[] numGrpBig = { "", "thousand", "million", "billion", "trillion", "quadrillion" };
        static readonly private string[] numGrpMed = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static readonly private string[] numGrpSmall = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        public static void Run()
        {
            Console.WriteLine("Enter a number");
            int valueParsed;

            // TryParse checks for proper int input. Value is stored as a string. 
            while (!Int32.TryParse(Console.ReadLine(), out valueParsed))
                Console.WriteLine("Please enter valid integers only.");

            // Zero case
            if (valueParsed == 0) { Console.WriteLine("zero"); Console.ReadKey(); return; }

            string valueParsedString = valueParsed.ToString();
            StringBuilder sb = new StringBuilder();

            // Iterate over the string from the end of the string in blocks of 3, we prepend everything since we'll start from small to big
            for (int x = valueParsedString.Length - 1, counter = 0; x >= 0; x -= 3, counter++)
            {
                sb.Insert(0, intToText(counter, valueParsedString.Substring(Math.Max(x - 2, 0), Math.Min(x+1,3))));
            }

            Console.WriteLine(Regex.Replace(sb.ToString(), @"\s+", " "));

            // Close on any key.
            Console.ReadKey();
            return;
        }


        // Turns a 3 char int into their written form, appends the multiplier (mil, bil,l tril, ect)
        private static string intToText(int macroScale, string _x)
        {
            int x = int.Parse(_x);

            // CheckZero
            if (x == 0) { return ""; }

            StringBuilder sb = new StringBuilder();

            // CheckHundreds
            if (x > 99)
                sb.Append(numGrpSmall[x / 100] + " hundred ");


            // Special case for 1 - 19
            if (x % 100 < 20)
            {
                sb.Append(numGrpSmall[x % 100] + " ");
                return sb.ToString() + numGrpBig[macroScale] + " ";
            }
                
            if (x % 100 > 9)
            {
                sb.Append(numGrpMed[(x % 100) / 10] + " ");
            }

            sb.Append(numGrpSmall[x % 10] + " ");

            return sb.ToString() + numGrpBig[macroScale] + " ";
        }
    }
}
