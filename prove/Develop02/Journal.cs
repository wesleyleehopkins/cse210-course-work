using System.Linq.Expressions;

public class Journal
{

    public List<Entery> enteryList;

    public Journal()
    {
        enteryList = new List<Entery>();
    }

    public void Write()
    {
        string Prompt = getPrompt();
        Console.WriteLine(Prompt);

        string Response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entery entery01 = new Entery(Prompt, dateText, Response);

        enteryList.Add(entery01);
    }
    public string getPrompt()
    {
        Random Number = new Random();
        int prompt = Number.Next(0, 20); // Now selecting from 20 options

        if (prompt == 0)
        {
            return "Who was the most interesting person I interacted with today?";
        }
        else if (prompt == 1)
        {
            return "What was the best part of my day?";
        }
        else if (prompt == 2)
        {
            return "How did I see the hand of the Lord in my life today?";
        }
        else if (prompt == 3)
        {
            return "What was the strongest emotion I felt today?";
        }
        else if (prompt == 4)
        {
            return "If I had one thing I could do over today, what would it be?";
        }
        else if (prompt == 5)
        {
            return "What is one thing I learned today?";
        }
        else if (prompt == 6)
        {
            return "What made me smile or laugh today?";
        }
        else if (prompt == 7)
        {
            return "Did I step outside of my comfort zone today? If so, how?";
        }
        else if (prompt == 8)
        {
            return "What is something I did today that I am proud of?";
        }
        else if (prompt == 9)
        {
            return "Did I help someone today? If so, how?";
        }
        else if (prompt == 10)
        {
            return "What is one thing I am grateful for today?";
        }
        else if (prompt == 11)
        {
            return "What was the biggest challenge I faced today?";
        }
        else if (prompt == 12)
        {
            return "How did I handle stress or pressure today?";
        }
        else if (prompt == 13)
        {
            return "If I could give advice to myself at the start of today, what would it be?";
        }
        else if (prompt == 14)
        {
            return "What is one goal I worked towards today?";
        }
        else if (prompt == 15)
        {
            return "How did I show kindness or love today?";
        }
        else if (prompt == 16)
        {
            return "What is something I want to improve on tomorrow?";
        }
        else if (prompt == 17)
        {
            return "Did I make time for myself today? If so, how?";
        }
        else if (prompt == 18)
        {
            return "What is something that surprised me today?";
        }
        else if (prompt == 19)
        {
            return "How did I take care of my mental or physical health today?";
        }
        else
        {
            return "Try again.";
        }
    }


    public void Display()
    {
        foreach (Entery i in enteryList)
        {
            Console.WriteLine(i.Display());
        }
    }

    public void Save()
    {

        Console.Write("Enter filename to save journal (example: Journal.txt)");

        string fileName = Console.ReadLine();
        try
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entery entery in enteryList)
                {
                    outputFile.WriteLine($" | {entery.date} | {entery.prompt} | {entery.response}");
                }
            }
            Console.WriteLine("Thank you, your Journal has been updated!");
        }
        catch (Exception)
        {
            Console.WriteLine("There has been a problem updateing your journal. Please try again!");

        }
    }

    public void Load()
    {

        Console.WriteLine("Please enter the name of the journal. (e.g. journal.txt) ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("Error: File not found, check name and try again plese");
            return;
        }
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(" | ");

                string printDate = parts[0];
                string printPrompt = parts[1];
                string printEntery = parts[2];

                Entery entery = new Entery(printPrompt, printDate, printEntery);
                enteryList.Add(entery);
            }
        
            Console.WriteLine("Journal Loaded.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error loading Journal");
        }
    }
}

