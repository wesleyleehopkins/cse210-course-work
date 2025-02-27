using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        Description = "In this activity you will list things you are grateful for.\nAfter each item PRESS ENTER.";
    }

    public void RunListActivity()
    {
        Console.WriteLine("Think of things you are grateful for."); 
        Console.WriteLine("When you are ready, press Enter to begin.");
        Console.ReadLine();
        ShowSpinner(3);

        Console.WriteLine("Start listing your items. You can enter as many as you like!");

        int entryCount = 0;
        int elapsedTime = 0;

        while (elapsedTime < DurationInSeconds)
        {
            Console.Clear();
            Console.WriteLine($"Time remaining: {DurationInSeconds - elapsedTime} seconds");
            Console.Write(">> ");

            // Check for user input while the timer is running
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    entryCount++;
                }
            }

            // Ensure 1-second interval even if user is not typing
            Thread.Sleep(1000);
            elapsedTime += 1;
        }

        Console.WriteLine($"Time is up! You listed {entryCount} items. Thank you for your blessings.");
        ShowSpinner(3);
    }

}
