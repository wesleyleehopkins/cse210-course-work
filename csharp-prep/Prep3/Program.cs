using System;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,1001);
        Console.WriteLine("Welcome to our NUMBER GENERATOR");
        Console.Write("Please input a number to try and guess ours!");


       int guess;
       do 
       {
         guess = int.Parse(Console.ReadLine());

            if (guess >= number)
            {
               
                Console.Write("Your guess was high, please try again!");
                
            }
            else if (guess <= number)
            {
                Console.Write("Your guess was to low! please try again!");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
       }while (number != guess );
    }
}