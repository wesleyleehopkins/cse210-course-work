using System;
using System.Runtime.CompilerServices;

class Quest 
{
    private string _name;

    private string _description;

    private int _points;

    private bool _isCompleted;


    public Quest( string name, string description, int points, bool isCompleted = false)
    {
        _name = name;

        _description = description;

        _points = points;

        _isCompleted = false;
    }

    public void Complete()
    {
        _isCompleted = true;

        Console.WriteLine($" Quest Complete: {_name}! {_points} points were earned");
    }

    public string getStatus()
    {
        return _isCompleted ? "Completed": "Not Complete";

    }

    public void DisplayQuest()
    {
        Console.WriteLine($"Quest: {_name}\n {_description} \n Points: {_points} \n");
    }

    public string ToCsvString()
    {
        return $"{_name}^{_description}^{_points}^{_isCompleted}";
    }

     public static Quest FromCsvString(string csvLine)
    {
        string[] primarySplit = csvLine.Split(": ", 2);
        string questType = primarySplit[0];
        string data = primarySplit[1];

        string[] parts = data.Split('^');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool isCompleted = bool.Parse(parts[3]);

        if (questType == "Eternal Quest")
        {
            return new EternalQuest(name, description, points, isCompleted);
        }
        else if (questType == "Checklist Quest")
        {
            int stepCount = int.Parse(parts[4]);
            return new ChecklistQuest(name, description, points, stepCount, isCompleted);
        }
        else
        {
            return new Quest(name, description, points, isCompleted);
        }
    }
}