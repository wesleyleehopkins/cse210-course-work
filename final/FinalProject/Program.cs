using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    // The Program class serves as the entry point for the application.
    // It handles the dynamic menu, robust input validation, and routes the user's choices.
    public class Program
    {
        // Main method: Application entry point.
        public static void Main(string[] args)
        {
            // Flag to control when the application should exit.
            bool exitApplication = false;
            
            // Dynamically build the menu options as a list.
            List<string> menuOptions = new List<string>();
            menuOptions.Add("View Food Log for a Specific Day");
            menuOptions.Add("Input Meals for a Specific Day");
            menuOptions.Add("Compare Meal Logs for a Specific Date");
            menuOptions.Add("Exit");

            // Main loop: Keep showing the menu until the user decides to exit.
            while (!exitApplication)
            {
                // Display the dynamic menu.
                DisplayMenu(menuOptions);
                
                // Get the user's choice with robust input validation.
                string userChoice = GetUserChoice(menuOptions.Count);
                
                // Process the user's menu choice.
                try
                {
                    // Parse the validated input to an integer.
                    int choice = int.Parse(userChoice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You selected: View Food Log for a Specific Day.");
                            // Here, you'll later instantiate MealTracker and call its ViewDailyLog method.
                            // Example:
                            // MealTracker tracker = new MealTracker();
                            // tracker.ViewDailyLog();
                            break;
                        case 2:
                            Console.WriteLine("You selected: Input Meals for a Specific Day.");
                            // Later, this will call MealTracker.InputMeals() after obtaining necessary info.
                            break;
                        case 3:
                            Console.WriteLine("You selected: Compare Meal Logs for a Specific Date.");
                            // This will later invoke MealTracker.CompareMealLogs().
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
                    // Catch and display any unexpected errors.
                    Console.WriteLine("An error occurred while processing your choice: " + ex.Message);
                }

                // If not exiting, prompt the user to return to the menu.
                if (!exitApplication)
                {
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        // DisplayMenu: Dynamically prints the menu options to the console.
        public static void DisplayMenu(List<string> options)
        {
            Console.Clear();
            Console.WriteLine("    Welcome to the Meal Tracking System");

            // Loop through each option and display it with its corresponding number.
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, options[i]);
            }
            Console.WriteLine();
        }

        // GetUserChoice: Retrieves the user's menu choice and validates the input.
        public static string GetUserChoice(int numberOfOptions)
        {
            string input = "";
            bool isValidChoice = false;
            while (!isValidChoice)
            {
                Console.Write("Please enter your choice (1-{0}): ", numberOfOptions);
                input = Console.ReadLine();
                int parsedNumber;
                // Validate that the input is a number and within the valid range.
                if (int.TryParse(input, out parsedNumber))
                {
                    if (parsedNumber >= 1 && parsedNumber <= numberOfOptions)
                    {
                        isValidChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("The number entered is out of range. Please try again.");
                    }
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
