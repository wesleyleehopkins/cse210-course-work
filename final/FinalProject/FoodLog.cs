using System;
using System.Collections.Generic;

namespace MealTrackingSystem
{
    public class FoodLog
    {
        private List<Meal> _meals;
        private FileHandler _fileHandler;

        public FoodLog()
        {
            _meals = new List<Meal>();
            _fileHandler = new FileHandler();
        }

        public List<Meal> Meals { get { return _meals; } }

        public void AddMeal(Meal meal)
        {
            _meals.Add(meal);
        }

        public List<Meal> GetMealsForDate(string date)
        {
            List<Meal> mealsForDate = new List<Meal>();
            for (int i = 0; i < _meals.Count; i++)
            {
                if (_meals[i].Date == date)
                    mealsForDate.Add(_meals[i]);
            }
            return mealsForDate;
        }

        public void LoadFromCSV(string filePath)
        {
            _meals.Clear();
            List<string[]> csvData = _fileHandler.ReadCSV(filePath);
            int startRow = 0;
            if (csvData.Count > 0 && csvData[0].Length > 0 && csvData[0][0].Equals("Date", StringComparison.OrdinalIgnoreCase))
                startRow = 1;
            for (int i = startRow; i < csvData.Count; i++)
            {
                if (csvData[i].Length >= 7)
                {
                    string date = csvData[i][0].Trim();
                    string name = csvData[i][1].Trim();
                    string servingSize = csvData[i][2].Trim();
                    double calories = double.Parse(csvData[i][3].Trim());
                    double protein = double.Parse(csvData[i][4].Trim());
                    double carbs = double.Parse(csvData[i][5].Trim());
                    double fat = double.Parse(csvData[i][6].Trim());
                    Meal meal = new Meal(date, name, servingSize, calories, protein, carbs, fat);
                    AddMeal(meal);
                }
            }
        }

        public void SaveToCSV(string filePath)
        {
            List<string[]> csvData = new List<string[]>();
            string[] header = { "Date", "Name", "ServingSize", "Calories", "Protein", "Carbs", "Fat" };
            csvData.Add(header);
            for (int i = 0; i < _meals.Count; i++)
            {
                string[] row = {
                    _meals[i].Date,
                    _meals[i].Name,
                    _meals[i].ServingSize,
                    _meals[i].Calories.ToString(),
                    _meals[i].Protein.ToString(),
                    _meals[i].Carbs.ToString(),
                    _meals[i].Fat.ToString()
                };
                csvData.Add(row);
            }
            _fileHandler.WriteCSV(filePath, csvData);
        }
    }
}
