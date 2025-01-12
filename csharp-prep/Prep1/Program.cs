using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();


        Console.WriteLine($" Your name is {lastName}, {name} {lastName}.");

    
        // This is to calculate grades from percentages
       Console.WriteLine("What is your % in your class? ");
       string userInput = Console.ReadLine();
       int grade = int.Parse(userInput);
       int ones = grade % 10;
       string letter = "N/A";
       string modifier = "";
        if (grade >= 90)
        {
           letter ="A"; 
        }
        else if (grade >= 80 )
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
             letter = "C";
        }
        else if (grade >= 60)
        {
             letter = "D";
        }
        else
        {
             letter = "F";
        }

        if (letter != "F" )
        {
            if (ones >= 7)
            {
                modifier = "+";
            }
            else if (ones >= 3)
            {
                modifier = "-";
            }
        }

        if (letter == "A")
        {
            if (ones <= 3)
            {
                modifier = "-";
            }
            else 
            {
                modifier = "";
            }
        }
        

        Console.WriteLine($"Your calculated grade is: {letter}{modifier}");
        // Shun/encourage
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You need to work harder.");
        }
    }
    
}