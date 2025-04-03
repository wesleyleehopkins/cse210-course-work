using System;
using System.Collections.Generic;
using System.IO;

namespace MealTrackingSystem
{
    public class FileHandler
    {
        public List<string[]> ReadCSV(string filePath)
        {
            List<string[]> csvData = new List<string[]>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found at " + filePath + ". Creating new file.");
                string header = "Date,Name,ServingSize,Calories,Protein,Carbs,Fat";
                File.WriteAllText(filePath, header + Environment.NewLine);
                Console.WriteLine("Created file at " + filePath + ".");
            }

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim().Length == 0)
                    continue;
                string[] fields = lines[i].Split(',');
                csvData.Add(fields);
            }
            return csvData;
        }

        public void WriteCSV(string filePath, List<string[]> data)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                string line = string.Join(",", data[i]);
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
