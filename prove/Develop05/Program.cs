using System;

class Program
{
    static void Main(string[] args)
    {
        Quest myQuest = new Quest("Slay the dragon", "Defeat the mighty dragon terrorizing the villiage.", 100);
        myQuest.DisplayQuest();

        Console.WriteLine("Press Enter to complete the quest...");
        Console.ReadLine();

        myQuest.Complete();
        myQuest.DisplayQuest();

    }        
}