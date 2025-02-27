using System;
using System.Runtime.InteropServices;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string ActivityName {get;protected set;}
    public string Description {get; protected set;}
    public int DurationInSeconds {get; protected set;}


    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {ActivityName} Activity.");
        Console.WriteLine(Description);
        Console.WriteLine("How long would you like to do this activity in seconds? ");

        try{
            DurationInSeconds = int.Parse(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input, please enter a numeric value");
            StartActivity();
        }
        Console.WriteLine("Beginning in...");
        ShowSpinner(3);
    }


    public void EndActivity()
    {
        Console.WriteLine("Well Done. You astound me!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {ActivityName} with the time of {DurationInSeconds} seconds utlized!");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

protected void ShowCountdown(int seconds)
{
     for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }



}





