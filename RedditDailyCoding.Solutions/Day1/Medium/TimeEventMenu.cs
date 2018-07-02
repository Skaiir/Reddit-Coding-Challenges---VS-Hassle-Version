using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RedditDailyCoding.Solutions.Day1.Medium
{

    /*
    
    TASK:    

    Create a menu driven program
    Using the menu driven program allow a user to add/delete items
    The menu should be based on an events calender where users enter the events by hour
    No events should be hard-coded. 
    
    */


    // NOTE: TO REFORMAT
   
    public class TimeEventMenu
    {
        public static void Run()
        {

            List<Tuple<string, string>> EventsList = new List<Tuple<string, string>>();

            int MenuState = 0;

            while (MenuState != -1)
            {
                Console.Clear();

                switch (MenuState)
                {
                    case 0:
                        Console.WriteLine("Welcome to the day planner app.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        MenuState = 1;
                        break;

                    case 1:
                        Console.WriteLine("Select an option:");
                        Console.WriteLine("See events - Press 1");
                        Console.WriteLine("Add an event - Press 2");
                        Console.WriteLine("Remove an event - Press 3");
                        Console.WriteLine("Exit the program - Press 4");
                        ConsoleKeyInfo KeyPressed = Console.ReadKey();
                        switch (KeyPressed.KeyChar)
                        {
                            case '1':
                                MenuState = 2;
                                break;

                            case '2':
                                MenuState = 3;
                                break;

                            case '3':
                                if (EventsList.Count > 0)
                                {
                                    MenuState = 4;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("The list is currently empty");
                                    Console.ReadKey();
                                    MenuState = 1;
                                }
                                break;

                            case '4':
                                MenuState = -1;
                                break;
                        }
                        break;

                    case 2:
                        if (EventsList.Count > 0)
                        {

                            Console.WriteLine("Current events are:");

                            foreach (Tuple<string, string> Event in EventsList)
                            {
                                Console.WriteLine(Event.Item1.PadRight(8) + " - " + Event.Item2);
                            }
                        }

                        else
                        {
                            Console.WriteLine("There are currently no events in the list");
                        }

                        Console.ReadKey();
                        MenuState = 1;
                        break;

                    case 3:
                        Tuple<string, string> temp = FetchEvent();

                        int counter = 0;
                        bool wasAdded = false;

                        foreach (Tuple<string, string> Event in EventsList)
                        {
                            if (String.Compare(temp.Item1, Event.Item1) == -1)
                            {
                                EventsList.Insert(counter, temp);
                                wasAdded = true;
                                break;
                            }
                            counter++;
                        }

                        if (!wasAdded)
                        {
                            EventsList.Add(temp);
                        }

                        Console.WriteLine("Event was added.");
                        Console.ReadKey();
                        MenuState = 1;
                        break;

                    case 4:

                        string deleteIndexString = "";
                        int deleteIndex = -1;

                        for (int x = 0; x < EventsList.Count; x++)
                        {
                            Console.WriteLine((x) + ": " + EventsList[x].Item1.PadRight(8) + " - " + EventsList[x].Item2);
                        }

                        Console.WriteLine("\nWhich event to delete? X to cancel");


                        deleteIndexString = Console.ReadLine();

                        bool inputIsInt = Int32.TryParse(deleteIndexString, out deleteIndex);

                        while (!inputIsInt || (deleteIndex >= EventsList.Count))
                        {

                            if (deleteIndexString == "X")
                                break;

                            Console.WriteLine("Enter a valid number.");

                            deleteIndexString = Console.ReadLine();

                            inputIsInt = Int32.TryParse(deleteIndexString, out deleteIndex);

                        }

                        if (deleteIndexString != "X")
                        {
                            EventsList.RemoveAt(deleteIndex);
                        }

                        MenuState = 1;
                        break;

                    default:
                        break;

                }
            }
        }

        static Tuple<string, string> FetchEvent()
        {

            Regex TimeFormat = new Regex("[0-2][0-9]:[0-5][0-9]");

            String RetrieveTime = "";
            String RetrieveEvent = "";

            while (!(TimeFormat.IsMatch(RetrieveTime) && (RetrieveEvent.Length > 0) && (RetrieveEvent.Length <= 40)))
            {
                Console.Clear();

                Console.Write("Event Time (hh:mm):".PadRight(50));

                RetrieveTime = Console.ReadLine();

                Console.Write("Event Description/Name (40 chars max):".PadRight(50));

                RetrieveEvent = Console.ReadLine();
            }

            return Tuple.Create(RetrieveTime, RetrieveEvent);
        }
    }
}
