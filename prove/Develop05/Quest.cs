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
        Console.WriteLine($"Quest: {_name}\n {_description} \n Points: {_points} \n Status: {getStatus()} \n");
    }

    public string ToCsvString()
    {
        return $"{_name}^{_description}^{_points}^{_isCompleted}";
    }

    public static Quest FromCsvString(string csvLine)
    {
        string[] parts = csvLine.Split('^');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool isCompleted = bool.Parse(parts[3]);

        return new Quest(name, description, points, isCompleted);

    }
}