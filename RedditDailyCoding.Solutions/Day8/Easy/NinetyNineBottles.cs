using System;
using System.Threading;

namespace RedditDailyCoding.Solutions.Day8.Easy
{
    public class NinetyNineBottles
    {
        public static void Run()
        {
            int counter = 99;

            string fulltext = "X of beer on the wall, X of beer. Take one down and pass it around, @ of beer on the wall. #";
            string fulltext0 = "No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall. #";


            string toPrint = fulltext;

            while (true)
            {
                foreach (string word in toPrint.Split(' '))
                {

                    if (word == "X")
                    {
                        Console.Write(counter + " bottle");
                        if (counter > 1) { Console.Write("s"); }
                    }
                        

                    else if (word == "@")
                    {
                        if (counter == 1)
                            Console.Write("no more bottles");
                        else
                        {
                            Console.Write((counter - 1) + " bottle");
                            if (counter > 2) { Console.Write("s"); }
                        }
                    }

                    else if (word == "#")
                    {
                        Console.Clear();

                        if (counter == 1)
                            toPrint = fulltext0;

                        else if (counter == 0)
                        {
                            counter = 99;
                            toPrint = fulltext;
                            break;
                        }

                        counter--;
                        break;
                    }

                    else 
                        Console.Write(word);

                    Console.Write(" ");
                    Thread.Sleep(160);

                } 
            }
        }
    }
}
