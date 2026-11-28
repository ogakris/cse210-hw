
using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "4")
            {
                Console.Clear();

                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.RunActivity();
                        break;

                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.RunActivity();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.RunActivity();
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                        break;
                }

                if (choice != "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                }
            }
        }
    }
}
