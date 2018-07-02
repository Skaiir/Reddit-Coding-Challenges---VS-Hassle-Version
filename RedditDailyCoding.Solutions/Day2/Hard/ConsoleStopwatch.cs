using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RedditDailyCoding.Solutions.Day2.Hard
{
    // Create a stopwatch console app


    public class ConsoleStopwatch
    {
        public static void Run()
        {
            Console.CursorVisible = false;
            List<TimeSpan> timeQueue = new List<TimeSpan>();
            TimeSpan currentTimer = new TimeSpan();
            DateTime timeAtStart = DateTime.Now;
            DateTime timeAtSplit = DateTime.Now;
            ConsoleKeyInfo keyPressed;
            Boolean programIsRunning = true;
            Boolean newTime = false;

            Console.WriteLine("Press x to exit, a to save a time and r to refresh the timer.");

            while (programIsRunning)
            {

                currentTimer = DateTime.Now - timeAtStart;

                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey();

                    if (keyPressed.KeyChar == 'x')
                    {
                        programIsRunning = false;

                        StringBuilder outputString = new StringBuilder();

                        foreach (var time in timeQueue)
                        {
                            outputString.AppendLine(ParseTime(time));
                        }

                        System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "output.txt", outputString.ToString());

                    }

                    else if (keyPressed.KeyChar == 'a')
                    {
                        timeQueue.Insert(0, DateTime.Now - timeAtSplit);
                        timeAtSplit = DateTime.Now;
                        newTime = true;
                    }

                    else if (keyPressed.KeyChar == 'r')
                    {
                        timeQueue.Clear();
                        timeAtStart = timeAtSplit = DateTime.Now;
                        newTime = true;
                        Console.Clear();
                        Console.WriteLine("Press x to exit, a to save a time and r to refresh the timer.");
                    }

                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(false);
                    }
                }

                Console.SetCursorPosition(0, 1);
                Console.WriteLine(ParseTime(currentTimer) + "\n");

                if (newTime)
                {
                    foreach (var element in timeQueue)
                    {
                        Console.WriteLine(ParseTime(element));
                    }
                }

                Thread.Sleep(10);
            }
        }

        static String ParseTime(TimeSpan time)
        {
            return time.Minutes.ToString().PadLeft(2, '0') + ":" + time.Seconds.ToString().PadLeft(2, '0') + "::" + time.Milliseconds.ToString().PadLeft(3, '0');
        }
    }
}
