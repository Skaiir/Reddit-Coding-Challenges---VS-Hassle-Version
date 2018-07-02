using System;
using System.IO;

namespace RedditDailyCoding.Solutions.Day5.Medium
{
    // write a program that can find the number of anagrams within a text file (exercise poorly defined)

    public class findAnagrams
    {
        public static void Run()
        {

            string[] wordBank;
            string[] sortedWordBank;
            int counter = 0;

            using (StreamReader reader = new StreamReader(@"C:\Users\Valentin\source\repos\RChall5Med\RChall5Med\text.txt"))
            {
                wordBank = reader.ReadToEnd().Replace(Environment.NewLine, "").Replace(",", "").Replace(".", "").ToLower().Split(' ');
            }

            sortedWordBank = new string[wordBank.Length];

            // Sort the word bank char

            for (int x = 0; x < wordBank.Length; x++)
            {
                sortedWordBank[x] = SortString(wordBank[x]);
            }

            for (int x = 0; x < sortedWordBank.Length; x++)
            {

                // skip if word length is 1 (either already coupled, or not in the file)
                if (sortedWordBank[x].Length == 1)
                    continue;

                for (int y = 0; (y + x + 1) < wordBank.Length; y++)
                {
                    if (sortedWordBank[x] == sortedWordBank[x + y + 1])
                        if (wordBank[x] != wordBank[x + y + 1])
                        {
                            Console.WriteLine(wordBank[x] + " : " + wordBank[x + y + 1]);
                            sortedWordBank[x] = sortedWordBank[x + y + 1] = "X";
                            counter++;
                            break;
                        }
                }
            }

            Console.WriteLine("There are a total of " + counter + " anagrams in this text");
        }

        static string SortString(string wordToSort)
        {
            char[] temp = wordToSort.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
    }
}
