using System;

namespace MealTrackingSystem
{
    public class Meal
    {
        private string _date;
        private string _name;
        private string _servingSize;
        private double _calories;
        private double _protein;
        private double _carbs;
        private double _fat;

        public Meal(string date, string name, string servingSize, double calories, double protein, double carbs, double fat)
        {
            _date = date;
            _name = name;
            _servingSize = servingSize;
            _calories = calories;
            _protein = protein;
            _carbs = carbs;
            _fat = fat;
        }

        public string Date { get { return _date; } set { _date = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string ServingSize { get { return _servingSize; } set { _servingSize = value; } }
        public double Calories { get { return _calories; } set { _calories = value; } }
        public double Protein { get { return _protein; } set { _protein = value; } }
        public double Carbs { get { return _carbs; } set { _carbs = value; } }
        public double Fat { get { return _fat; } set { _fat = value; } }

        public override string ToString()
        {
            return "Date: " + _date +
                   ", Name: " + _name +
                   ", Serving Size: " + _servingSize +
                   ", Calories: " + _calories +
                   ", Protein: " + _protein +
                   ", Carbs: " + _carbs +
                   ", Fat: " + _fat;
        }
    }
}
