using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class QuestManager
{
    private List<Quest> _quests = new List<Quest>();

    private string _filePath = "quest.csv";


    public void AddQuest (Quest quest)
    {
        _quests.Add(quest);
    }

    public void ListQuests()
    {
        Console.WriteLine("\n Types of Goals");
        for(int i = 0; i < _quests.Count; i++)
        {
            Console.WriteLine($"[{i}]");
            _quests[i].DisplayQuest();
        }

        PublicKey void CompleteQuests(int index)
        {
            if (index >- 0 && index < _quests.Count)
            {
                _quests[index].Complete();
            }
            else{
                Console.WriteLine("Quest not available.");
            }
        }

    }

    public void SaveQuestsToFile()
    {
        using (StreamWriter writer = new StreamWriter )
    }
}