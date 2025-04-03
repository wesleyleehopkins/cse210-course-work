using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    public class MyFitnessPalData
    {
        private List<Meal> _meals;
        private FileHandler _fileHandler;

        public MyFitnessPalData()
        {
            _meals = new List<Meal>();
            _fileHandler = new FileHandler();
        }

        public List<Meal> Meals { get { return _meals; } }

        public void LoadFromCSV(string filePath)
        {
            _meals.Clear();
            List<string[]> csvData = _fileHandler.ReadCSV(filePath);
            int startRow = 0;
            if (csvData.Count > 0 && csvData[0].Length > 0 && csvData[0][0].Equals("Date", StringComparison.OrdinalIgnoreCase))
                startRow = 1;
            for (int i = startRow; i < csvData.Count; i++)
            {
                if (csvData[i].Length >= 15)
                {
                    string date = csvData[i][0].Trim();
                    string name = csvData[i][1].Trim();
                    string servingSize = "";
                    double calories = double.Parse(csvData[i][2].Trim());
                    double fat = double.Parse(csvData[i][3].Trim());
                    double carbs = double.Parse(csvData[i][11].Trim());
                    double protein = double.Parse(csvData[i][14].Trim());
                    Meal meal = new Meal(date, name, servingSize, calories, protein, carbs, fat);
                    _meals.Add(meal);
                }
            }
        }

        public List<Meal> GetMealsForDate(string date)
        {
            List<Meal> mealsForDate = new List<Meal>();
            foreach (Meal meal in _meals)
            {
                if (meal.Date == date)
                    mealsForDate.Add(meal);
            }
            return mealsForDate;
        }
    }
}
