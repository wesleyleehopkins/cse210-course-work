using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DisplayWelcome());

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, SquaredNumber);


    }

    static string DisplayWelcome()
    {
        string welcome ="Welcome to The program!";
        return welcome;
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your username?");

        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int SquaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquaredNumber}");
    }


}