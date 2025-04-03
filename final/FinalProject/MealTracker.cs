using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    public class MealTracker
    {
        private FoodLog _foodLog;

        public MealTracker()
        {
            _foodLog = new FoodLog();
        }

        public void ViewDailyLog()
        {
            Console.Write("Enter date (YYYY-MM-DD): ");
            string date = Console.ReadLine();
            _foodLog.LoadFromCSV("foodlog.csv");
            List<Meal> mealsForDate = _foodLog.GetMealsForDate(date);
            if (mealsForDate.Count == 0)
                Console.WriteLine("No meals for " + date);
            else
            {
                Console.WriteLine("Food Log for " + date + ":");
                foreach (Meal meal in mealsForDate)
                    Console.WriteLine(meal.ToString());
            }
        }

        public void InputMeals()
        {
            Console.Write("Enter date (YYYY-MM-DD): ");
            string date = Console.ReadLine();
            Console.Write("How many meals? ");
            int mealCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < mealCount; i++)
            {
                Console.WriteLine("Meal " + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Serving Size: ");
                string servingSize = Console.ReadLine();
                Console.Write("Calories: ");
                double calories = double.Parse(Console.ReadLine());
                Console.Write("Protein: ");
                double protein = double.Parse(Console.ReadLine());
                Console.Write("Carbs: ");
                double carbs = double.Parse(Console.ReadLine());
                Console.Write("Fat: ");
                double fat = double.Parse(Console.ReadLine());
                Meal meal = new Meal(date, name, servingSize, calories, protein, carbs, fat);
                _foodLog.AddMeal(meal);
            }
            _foodLog.SaveToCSV("foodlog.csv");
            Console.WriteLine("Meals added for " + date);
        }

        public void CompareMealLogs()
        {
            Console.Write("Enter date (YYYY-MM-DD): ");
            string date = Console.ReadLine();

            _foodLog.LoadFromCSV("foodlog.csv");
            List<Meal> foodLogMeals = _foodLog.GetMealsForDate(date);
            double foodCalories = 0, foodProtein = 0, foodCarbs = 0, foodFat = 0;
            foreach (Meal meal in foodLogMeals)
            {
                foodCalories += meal.Calories;
                foodProtein += meal.Protein;
                foodCarbs += meal.Carbs;
                foodFat += meal.Fat;
            }

            MyFitnessPalData mfpData = new MyFitnessPalData();
            mfpData.LoadFromCSV("myfitnesspal.csv");
            List<Meal> mfpMeals = mfpData.GetMealsForDate(date);
            double mfpCalories = 0, mfpProtein = 0, mfpCarbs = 0, mfpFat = 0;
            foreach (Meal meal in mfpMeals)
            {
                mfpCalories += meal.Calories;
                mfpProtein += meal.Protein;
                mfpCarbs += meal.Carbs;
                mfpFat += meal.Fat;
            }

            Console.WriteLine("Comparison for " + date);
            Console.WriteLine("Calories: FoodLog=" + foodCalories + ", MyFitnessPal=" + mfpCalories);
            Console.WriteLine("Protein: FoodLog=" + foodProtein + ", MyFitnessPal=" + mfpProtein);
            Console.WriteLine("Carbs: FoodLog=" + foodCarbs + ", MyFitnessPal=" + mfpCarbs);
            Console.WriteLine("Fat: FoodLog=" + foodFat + ", MyFitnessPal=" + mfpFat);
            if (mfpCalories > foodCalories)
                Console.WriteLine("FoodLog is missing some calories.");
            if (mfpProtein > foodProtein)
                Console.WriteLine("FoodLog is missing some protein.");
            if (mfpCarbs > foodCarbs)
                Console.WriteLine("FoodLog is missing some carbs.");
            if (mfpFat > foodFat)
                Console.WriteLine("FoodLog is missing some fat.");
        }
    }
}
