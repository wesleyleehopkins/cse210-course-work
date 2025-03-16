using System;
using System.Collections.Generic;
using System.IO;

class QuestManager
{
    private List<Quest> _quests;
    private string _filePath;

    public QuestManager()
    {
        _quests = new List<Quest>();

        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // CHANGED: Line 12 - Fixed capitalization error (`baseDirectory` instead of `baseDirectory`)
        string fileName = "quest.csv";
        _filePath = Path.Combine(baseDirectory, fileName);
    }

    public void AddQuest(Quest quest)
    {
        _quests.Add(quest);
    }

    public void ListQuests()
    {
        Console.WriteLine("\n🔹 Available Quests:");
        for (int i = 0; i < _quests.Count; i++)
        {
            Console.WriteLine($"[{i}]");
            _quests[i].DisplayQuest();
        }
    }

    public void CompleteQuest(int index)
    {
        if (index >= 0 && index < _quests.Count)
        {
            _quests[index].Complete();
        }
        else
        {
            Console.WriteLine("❌ Quest not available.");
        }
    }

    public void SaveQuestsToFile()
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            foreach (Quest quest in _quests)
            {
                writer.WriteLine(quest.ToCsvString());
            }
        }
        Console.WriteLine($"💾 Quests saved at: {_filePath}");
    }

    public void LoadQuestsFromFile()
    {
        if (File.Exists(_filePath)) // CHANGED: Line 49 - Added missing `File.Exists()` check before reading file
        {
            _quests.Clear();
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                _quests.Add(Quest.FromCsvString(line));
            }
            Console.WriteLine($"📂 Quests loaded successfully from: {_filePath}");
        }
        else
        {
            Console.WriteLine($"⚠️ No saved quests found. Creating new file at: {_filePath}");
            File.WriteAllText(_filePath, ""); // CHANGED: Line 56 - Ensured empty file is created if no quests exist
        }
    }
}
