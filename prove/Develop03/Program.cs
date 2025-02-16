using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main()
    {
        // 1. Create a Reference object (e.g., John 3:16)
        var reference = new Reference("John", 3, 16);
        // 2. Create a Scripture object using the reference and a verse text
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

              // 3. Loop until all words are hidden
        while (!scripture.AllWordsHidden())
        {
            // Clear the console and display the scripture text
            Console.Clear();
            Console.WriteLine($"Reference: {scripture.GetReference()}");
            Console.WriteLine(scripture.GetMaskedText());
            Console.WriteLine("\nPress Enter to hide words,or type quit to exit.");
            // Hide 3 words if Enter is pressed
            string input = Console.ReadLine();
            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
                break;

            scripture.HideWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetMaskedText());
        Console.WriteLine("\n All the words hidden, Have you memorized it?");
    }
}
