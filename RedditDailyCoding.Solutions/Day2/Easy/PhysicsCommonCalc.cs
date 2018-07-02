using System;

namespace RedditDailyCoding.Solutions.Day2.Easy
{

    // Create a physics command interface to process some simple calc

    public class PhysicsCommonCalc
    {
        public static void Run()
        {

            bool close = false;

            while (!close)
            {

                Console.Clear();
                Console.Write("Which operation are we using this time?\n\n1 - Force from acceleration and mass\n2 - Acceleration from mass and force\n3 - Mass from force and acceleration.\n4 - Exit calculator.\n\n");

                ConsoleKeyInfo KeyPressed = Console.ReadKey();

                float A, B;

                switch (KeyPressed.KeyChar)
                {
                    case '1':

                        Console.WriteLine(" - Enter in order: acceleration, then mass.");

                        while (!float.TryParse(Console.ReadLine(), out A))
                            Console.WriteLine("Invalid acceleration, make sure you write something in this format: XX.XX");

                        while (!float.TryParse(Console.ReadLine(), out B))
                            Console.WriteLine("Invalid mass, make sure you write something in this format: XX.XX");

                        Console.WriteLine("The force needed to accelerate an object of mass " + B.ToString("0.00") + " kg at rate of " + A.ToString("0.00") + " ms^-2 is " + (A * B).ToString("0.00") + " Newtons.");

                        break;

                    case '2':

                        Console.WriteLine(" - Enter in order: mass, then force.");

                        while (!float.TryParse(Console.ReadLine(), out A))
                            Console.WriteLine("Invalid mass, make sure you write something in this format: XX.XX");

                        while (!float.TryParse(Console.ReadLine(), out B))
                            Console.WriteLine("Invalid force, make sure you write something in this format: XX.XX");

                        Console.WriteLine("An object of mass " + A.ToString("0.00") + " kg on which a force of " + B.ToString("0.00") + " Newtons is applied will accelerate at a rate of " + (B / A).ToString("0.00") + " ms^-2.");

                        break;

                    case '3':

                        Console.WriteLine(" - Enter in order: force, then acceleration.");

                        while (!float.TryParse(Console.ReadLine(), out A))
                            Console.WriteLine("Invalid force, make sure you write something in this format: XX.XX");

                        while (!float.TryParse(Console.ReadLine(), out B))
                            Console.WriteLine("Invalid acceleration, make sure you write something in this format: XX.XX");

                        Console.WriteLine("An object accelerated at a rate of " + B.ToString("0.00") + " ms^-2 when under a force of " + A.ToString("0.00") + " Newtons must weight " + (A / B).ToString("0.00") + " kg.");

                        break;

                    case '4':
                        Console.WriteLine(" - Press X to cancel, or any other key to close the calculator.");
                        KeyPressed = Console.ReadKey();

                        if (!(KeyPressed.KeyChar == 'X' || KeyPressed.KeyChar == 'x'))
                            return;

                        break;
                }

                Console.WriteLine("\n\nPress any key to continue.");
                Console.ReadKey();

            }

            return;
        }

    }
}
