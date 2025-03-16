using System;

class Program
{
    static void Main()
    {
        QuestManager questManager = new QuestManager();
        questManager.LoadQuestsFromFile();

        bool isRunning = true; // 🔥 Keeps the menu running

        while (isRunning) // 🔥 Loop until user exits
        {
            Console.WriteLine("\n=== Eternal Quest Menu ===");
            Console.WriteLine("1. Add a Quest");
            Console.WriteLine("2. View Quests");
            Console.WriteLine("3. Complete a Quest");
            Console.WriteLine("4. Load Quests");
            Console.WriteLine("5. Save Quests");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nChoose a quest type:");
                    Console.WriteLine("1. Normal Quest");
                    Console.WriteLine("2. Eternal Quest");
                    Console.WriteLine("3. Checklist Quest");
                    Console.Write("Enter your choice: ");
                    
                    string questTypeChoice = Console.ReadLine();

                    Console.Write("Enter quest name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter quest description: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter quest points: ");
                    int points = int.Parse(Console.ReadLine());

                    Quest newQuest;
                    if (questTypeChoice == "2")
                    {
                        newQuest = new EternalQuest(name, description, points);
                    }
                    else if (questTypeChoice == "3")
                    {
                        Console.Write("Enter the number of steps required: ");
                        int steps = int.Parse(Console.ReadLine());
                        newQuest = new ChecklistQuest(name, description, points, steps);
                    }
                    else
                    {
                        newQuest = new Quest(name, description, points);
                    }

                    questManager.AddQuest(newQuest);
                    Console.WriteLine("✅ Quest added successfully!");
                    break;

                case "2":
                    questManager.ListQuests();
                    break;

                case "3":
                    questManager.ListQuests();
                    Console.Write("\nEnter the number of the quest to complete: ");
                    int questIndex = int.Parse(Console.ReadLine());

                    questManager.CompleteQuest(questIndex);
                    break;

                case "4":
                    questManager.LoadQuestsFromFile();
                    break;

                case "5":
                    questManager.SaveQuestsToFile();
                    break;

                case "6":
                    Console.WriteLine("👋 Exiting Eternal Quest...");
                    isRunning = false; // 🔥 Exits the loop
                    break;

                default:
                    Console.WriteLine("⚠️ Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
