using System;

namespace MealTrackingSystem
{
    // The Meal class represents a single meal entry.
    // It encapsulates all nutritional details and the date the meal was consumed.
    public class Meal
    {
        // Private fields for encapsulation.
        private string _date;
        private string _name;
        private string _servingSize;
        private int _calories;
        private int _protein;
        private int _carbs;
        private int _fat;

        // Constructor: Initializes all properties of a Meal.
        public Meal(string date, string name, string servingSize, int calories, int protein, int carbs, int fat)
        {
            this._date = date;
            this._name = name;
            this._servingSize = servingSize;
            this._calories = calories;
            this._protein = protein;
            this._carbs = carbs;
            this._fat = fat;
        }

        // Public property for Date with full getter and setter.
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Public property for Name.
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Public property for ServingSize.
        public string ServingSize
        {
            get { return this._servingSize; }
            set { this._servingSize = value; }
        }

        // Public property for Calories.
        public int Calories
        {
            get { return this._calories; }
            set { this._calories = value; }
        }

        // Public property for Protein.
        public int Protein
        {
            get { return this._protein; }
            set { this._protein = value; }
        }

        // Public property for Carbs.
        public int Carbs
        {
            get { return this._carbs; }
            set { this._carbs = value; }
        }

        // Public property for Fat.
        public int Fat
        {
            get { return this._fat; }
            set { this._fat = value; }
        }

        // Overrides ToString() to provide a readable description of the meal.
        public override string ToString()
        {
            return "Date: " + this._date +
                   ", Name: " + this._name +
                   ", Serving Size: " + this._servingSize +
                   ", Calories: " + this._calories +
                   ", Protein: " + this._protein +
                   ", Carbs: " + this._carbs +
                   ", Fat: " + this._fat;
        }
    }
}
