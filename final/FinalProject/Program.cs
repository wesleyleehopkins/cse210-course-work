using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> menuOptions = new List<string>()
            {
                "View Food Log for a Specific Day",
                "Input Meals for a Specific Day",
                "Compare Meal Logs for a Specific Date",
                "Exit"
            };

            bool exitApplication = false;
            while (!exitApplication)
            {
                DisplayMenu(menuOptions);
                string userChoice = GetUserChoice(menuOptions.Count);
                int choice = int.Parse(userChoice);
                switch (choice)
                {
                    case 1:
                        MealTracker tracker1 = new MealTracker();
                        tracker1.ViewDailyLog();
                        break;
                    case 2:
                        MealTracker tracker2 = new MealTracker();
                        tracker2.InputMeals();
                        break;
                    case 3:
                        MealTracker tracker3 = new MealTracker();
                        tracker3.CompareMealLogs();
                        break;
                    case 4:
                        exitApplication = true;
                        break;
                    default:
                        break;
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
            Console.WriteLine("======================================");
            Console.WriteLine("    Welcome to the Meal Tracking System");
            Console.WriteLine("======================================");
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
                int parsedNumber;
                if (int.TryParse(input, out parsedNumber))
                {
                    if (parsedNumber >= 1 && parsedNumber <= numberOfOptions)
                        isValidChoice = true;
                    else
                        Console.WriteLine("The number entered is out of range.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            return input;
        }
    }
}
