using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int guess;

        do        
        {
            Console.WriteLine("Enter List of numbers, type 0 when finished.");
            guess = int.Parse(Console.ReadLine());
            numbers.Add(guess);

        } while  (guess != 0);
        int total = 0;
        foreach (int number in numbers)
        {
            total+= number;
        }
        int average = total/ numbers.Count;
        double largestNumber = -5;
        double smallestNumber = 99999999999;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
            
        }
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"the average is {average}");
        Console.WriteLine($"Largest number is {largestNumber}");
        Console.WriteLine($"Smallest number is {smallestNumber}");
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        // Console.WriteLine(words.Count);
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i <words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
    }
}