using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditDailyCoding.Solutions.Day3.Hard
{
    // Unscramble text by comparing it to a word list

    public class TextUnscramble
    {
        public static void Run()
        {

            // the basis of the challenge is to descramble these words using the wordbank

            string[] wordsToDecipher = new string[]
            {
            "mkeart", "sleewa", "edcudls", "iragoge", "usrlsle", "nalraoci", "nsdeuto", "amrhat", "inknsy", "iferkna"
            };

            string[] textContent = System.IO.File.ReadAllLines(@"C:\Users\Valentin\Source\Repos\RChall3H\RChall3H-Solution\RChall3H-Solution\wordbank.txt");

            foreach (string word in wordsToDecipher)
            {
                Console.WriteLine(Unscramble(word, textContent));
                Console.ReadLine();
            }

        }

        static string Unscramble(string word, string[] _textContent)
        {

            // Init Block

            Boolean letterMatch;

            // CORE

            foreach (string textWord in _textContent)
            {
                letterMatch = true;

                foreach (char character in word)
                {
                    if (!textWord.Contains(character))
                    {
                        letterMatch = false;
                        break;
                    }
                }

                // if all letters match, then we check for proportions
                if (letterMatch)
                    if (ConfirmWord(textWord, word))
                        return textWord;
            }

            return "NOTFOUND";
        }

        static Boolean ConfirmWord(string word_a, string word_b)
        {
            if (word_a.Length != word_b.Length)
                return false;
            int index;

            List<char> list_a = new List<char>();
            list_a.AddRange(word_a);

            List<char> list_b = new List<char>();
            list_b.AddRange(word_b);

            while (list_a.Count != 0)
            {
                index = list_b.FindIndex(x => x == list_a[0]);

                if (index == -1)
                    return false;

                list_a.RemoveAt(0);
                list_b.RemoveAt(index);
            }
            return true;
        }
    }
}

