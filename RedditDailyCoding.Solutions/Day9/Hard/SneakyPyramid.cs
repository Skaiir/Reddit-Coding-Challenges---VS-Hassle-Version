using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyCoding.Solutions.Day9.Hard
{

    // Create a program which can return the xth element of the 1 - 11 - 21 - 1211 logic chain

    public class SneakyPyramid
    {
        private static string startString = "1";

        public static void Run()
        {

            int numberOfPasses;

            Console.WriteLine("Enter the x'th element you want from the chain: 1 - 11 - 21 - 1211\n");

            while (!Int32.TryParse(Console.ReadLine(), out numberOfPasses) && numberOfPasses > 0) {
                Console.WriteLine("Make sure to enter a number");
            }

            String saverString = new String(startString.ToCharArray());
            StringBuilder sb = new StringBuilder(startString);

            

            for (int i = 0; i < numberOfPasses - 1; i++)
            {

                sb.Clear();
                char saverChar = ' ';
                int counter = 0;

                // Process saverString x-1 number of times

                foreach (char _char in saverString)
                {
                    if (saverChar != _char)
                    {
                        if (counter != 0)
                            sb.Append(counter.ToString() + saverChar);

                        counter = 1;
                        saverChar = _char;
                    }

                    else
                        counter++;
                }

                // Final append as string is exited
                sb.Append(counter.ToString() + saverChar);

                // Store string for next pass
                saverString = sb.ToString();
                
            }

            Console.WriteLine(saverString);

            return;

        }
    }
}
