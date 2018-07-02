using System;
using System.Collections.Generic;
using System.Text;

namespace RedditDailyCoding.Solutions.Day7.Easy
{
    public class MorseCodeTranslate
    {
        public static void Run()
        {
            // Text to tanslate
            string code = ".... . .-.. .-.. --- / -.. .- .. .-.. -.-- / .--. .-. --- --. .-. .- -- -- . .-. / --. --- --- -.. / .-.. ..- -.-. -.- / --- -. / - .... . / -.-. .... .- .-.. .-.. . -. --. . ... / - --- -.. .- -.--";

            // Flattening out the binary tree
            char[] treeValues = " TEMNAIOGKDWRUS-.QZYCXBJP?L_FVH09?8???7???????61???????2???3?45".ToCharArray();

            // Initiating the binary tree (it builds itself using recursion)
            MorseCodeTree tree = new MorseCodeTree(treeValues, 0);

            string[] words = code.Split(' ');

            char[] decoded = new char[words.Length];

            for (int x = 0; x < words.Length; x++)
            {
                decoded[x] = tree.DatDit(words[x].ToCharArray(), 0);
                Console.Write(decoded[x]);
            }

            Console.ReadKey();
        }
    }
}
