using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    // The FoodLog class manages meals entered by the user.
    // It aggregates Meal objects and provides methods to add and retrieve meals.
    public class FoodLog
    {
        // Private list to store Meal objects.
        private List<Meal> _meals;

        // Constructor: Initializes the meals list.
        public FoodLog()
        {
            this._meals = new List<Meal>();
        }

       
        public List<Meal> Meals
        {
            get { return this._meals; }
        }

        // Adds a new Meal to the food log.
        public void AddMeal(Meal meal)
        {
            if (meal != null)
            {
                this._meals.Add(meal);
            }
        }

        // Returns a list of meals for a given date.
        public List<Meal> GetMealsForDate(string date)
        {
            // Create a new list to hold meals that match the provided date.
            List<Meal> mealsForDate = new List<Meal>();
            foreach (Meal meal in this._meals)
            {
                if (meal.Date == date)
                {
                    mealsForDate.Add(meal);
                }
            }
            return mealsForDate;
        }


        public void LoadSampleData()
        {
            // Create sample Meal objects with explicit types.
            Meal sampleMeal1 = new Meal("2023-10-10", "Oatmeal", "1 bowl", 150, 5, 27, 3);
            Meal sampleMeal2 = new Meal("2023-10-10", "Chicken Salad", "1 plate", 300, 30, 10, 15);
            Meal sampleMeal3 = new Meal("2023-10-11", "Fruit Smoothie", "1 glass", 200, 4, 35, 2);
            
            // Add the sample meals to the food log.
            this.AddMeal(sampleMeal1);
            this.AddMeal(sampleMeal2);
            this.AddMeal(sampleMeal3);
        }
    }
}
