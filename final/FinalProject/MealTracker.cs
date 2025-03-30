using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    // The MealTracker class handles the core business logic.
    // It is responsible for operations like viewing the food log, adding meals, etc.
    public class MealTracker
    {
        // Private field: FoodLog is composed within MealTracker.
        private FoodLog _foodLog;

        // Constructor: Initializes the FoodLog and loads sample data.
        public MealTracker()
        {
            this._foodLog = new FoodLog();
            // For demonstration, we load sample data.
            this._foodLog.LoadSampleData();
        }

        // ViewDailyLog: Displays the meals for a given date.
        public void ViewDailyLog(string date)
        {
            // Retrieve meals from the FoodLog for the specified date.
            List<Meal> mealsForDate = this._foodLog.GetMealsForDate(date);

            // If no meals are found, notify the user.
            if (mealsForDate.Count == 0)
            {
                Console.WriteLine("No meals found for the date: " + date);
            }
            else
            {
                Console.WriteLine("Food Log for " + date + ":");
                // Iterate over each meal and print its details.
                foreach (Meal meal in mealsForDate)
                {
                    Console.WriteLine(meal.ToString());
                }
            }
        }

        // (Other methods for Option 2 and Option 3 will be added later.)
    }
}
