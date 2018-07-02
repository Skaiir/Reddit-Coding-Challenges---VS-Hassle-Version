using System;

namespace RedditDailyCoding.Solutions.Day3.Medium
{

    // Reddit Challenge - Create a program that can take a piece of text and encrypt it with an alphabetical 
    // substitution cipher.This can ignore white space, numbers, and symbols. 

    public static class AlphaCypher
    {
        public static void Run()
        {

            char[] alphabet = "abcdefghijklmnopqrst".ToCharArray();
            char[] shuffledAlphabet = (char[])alphabet.Clone();

            // Implementing extension method
            new Random().ShuffleCharArray(shuffledAlphabet);

            Console.WriteLine(AlphaSub("Hello world!", alphabet, shuffledAlphabet));

        }

        static String AlphaSub(String toCypher, char[] mapFrom, char[] mapOnto)
        {

            if (mapFrom.Length != mapOnto.Length)
            {
                return "Array size missmatch";
            }

            char[] cypherInputArr = toCypher.ToLower().ToCharArray();
            char[] cypherOutputArr = (char[])cypherInputArr.Clone();

            for (int i1 = 0; i1 < mapFrom.Length; i1++)
            {
                for (int i2 = 0; i2 < cypherInputArr.Length; i2++)
                {
                    if (cypherInputArr[i2] == mapFrom[i1])
                        cypherOutputArr[i2] = mapOnto[i1];
                }
            }

            return new string(cypherOutputArr);
        }

        // Fisher-Yates courtesy of stackoverflow - learned about extension methods :D
        static void ShuffleCharArray(this Random rng, char[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                char temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
