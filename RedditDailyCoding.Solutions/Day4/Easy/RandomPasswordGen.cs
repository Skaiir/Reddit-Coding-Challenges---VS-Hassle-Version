using System;

namespace RedditDailyCoding.Solutions.Day4.Easy
{

    // code a random password generator + specify the size and number of passwords to generate
    // output on console

    public class RandomPasswordGen
    {
        public static void Run()
        {

            Random rng = new Random();

            int numberOfPasswords;
            int passwordSize;

            Console.WriteLine("How many passwords?");
            while (!Int32.TryParse(Console.ReadLine(), out numberOfPasswords))
            {
                Console.WriteLine("Enter a number.");
            }

            if (numberOfPasswords < 1)
            {
                numberOfPasswords = 1;
                Console.WriteLine("Defaulted to 1 password");
            }


            Console.WriteLine("Password size:");
            while (!Int32.TryParse(Console.ReadLine(), out passwordSize))
            {
                Console.WriteLine("Enter a number.");
            }

            if (passwordSize < 1)
            {
                passwordSize = 8;
                Console.WriteLine("Defaulted to 8 characters");
            }

            char[] text = new char[passwordSize];

            // Generates {x} passwords of {y} charlengths

            for (int x = 0; x < numberOfPasswords; x++)
            {
                for (int y = 0; y < passwordSize; y++)
                {
                    text[y] = (char)(rng.Next(36, 126));
                }
                Console.WriteLine(text);
            }
        }
    }
}
