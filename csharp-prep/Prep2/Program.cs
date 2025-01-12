using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
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