using System;

namespace RedditDailyCoding.Solutions.Day1.Hard
{
    /*
    Create a reverse number guessing game (computer guesses, you answer)
    */

    // NOTE: Should add error checking

    public class GuessANumber
    {
        public static void Run()
        {

            String userResponse = null;
            int morethen = 0, lessthen = 101;
            int guess = 0;

            Console.WriteLine("User, think of a number between 1 and 100, I will try to guess it. Press any key when you've got one.");
            Console.WriteLine("Possible answers are higher, lower and yup");
            Console.ReadKey();

            while (userResponse != "yup")
            {
                guess = (morethen + lessthen) / 2;
                Console.WriteLine("Is your number " + guess + "?");
                userResponse = Console.ReadLine();

                if (userResponse == "lower")
                {
                    lessthen = guess;
                }

                else if (userResponse == "higher")
                {
                    morethen = guess;
                }

                else if (userResponse == "yup")
                {
                    Console.WriteLine("I knew it all along!");
                }
            }

            Console.ReadKey();

        }
    }
}
