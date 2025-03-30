using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exitApplication = false;
            List<string> menuOptions = new List<string>
            {
                "View Food Log for a Specific Day",
                "Input Meals for a Specific Day",
                "Compare Meal Logs for a Specific Date",
                "Exit"
            };

            while (!exitApplication)
            {
                DisplayMenu(menuOptions);
                string userChoice = GetUserChoice(menuOptions.Count);

                try
                {
                    int choice = int.Parse(userChoice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You selected: View Food Log for a Specific Day.");
                            break;
                        case 2:
                            Console.WriteLine("You selected: Input Meals for a Specific Day.");
                            break;
                        case 3:
                            Console.WriteLine("You selected: Compare Meal Logs for a Specific Date.");
                            break;
                        case 4:
                            Console.WriteLine("Exiting the application. Goodbye!");
                            exitApplication = true;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please choose a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                if (!exitApplication)
                {
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        public static void DisplayMenu(List<string> options)
        {
            Console.Clear();
            Console.WriteLine("    Welcome to the Meal Tracking System");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, options[i]);
            }
            Console.WriteLine();
        }

        public static string GetUserChoice(int numberOfOptions)
        {
            string input = "";
            bool isValidChoice = false;
            while (!isValidChoice)
            {
                Console.Write("Please enter your choice (1-{0}): ", numberOfOptions);
                input = Console.ReadLine();
                if (int.TryParse(input, out int parsedNumber) && parsedNumber >= 1 && parsedNumber <= numberOfOptions)
                {
                    isValidChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            return input;
        }
    }
}
