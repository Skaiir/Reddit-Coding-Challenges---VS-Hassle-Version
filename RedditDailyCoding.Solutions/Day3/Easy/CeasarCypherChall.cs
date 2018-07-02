using System;
using System.Text;

namespace RedditDailyCoding.Solutions.Day3.Easy
{
    // Implement a ceasar cypher method

    public class CeasarCypherChall
    {
        public static void Run()
        {
            Console.WriteLine(CeasarCypher(2, "abcdefghijklmnopqrstuvwxyz"));
        }

        static string CeasarCypher(int shift, string input)
        {

            StringBuilder outputBuilder = new StringBuilder();

            foreach (char letter in input)
            {
                outputBuilder.Append((char)(((letter + shift) - 97) % 26 + 97));
            }

            return outputBuilder.ToString();
        }
    }
}
