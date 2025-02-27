using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts;
    private List<string> questions;
    private Queue<string> shuffledQuestions;
    private const int MaxLineLength = 80; // Set the maximum length for each line to avoid terminal overflow

    public ReflectionActivity()
    {
        ActivityName = "Reflection";
        Description = WrapText(
            "This activity will help you reflect on times in your life when you have shown " +
            "strength and resilience. This will help you recognize how you are strong in " +
            "various aspects of your life."
        );

        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What strengths did you discover in yourself through this experience?",
            "What challenges did you overcome to achieve this?",
            "How did this experience change your perspective on life?",
            "What impact did this have on the people around you?",
            "How can this experience guide you in future decisions?",
            "What did you enjoy the most about this experience?",
            "What skills did you develop from this experience?",
            "How did this experience influence your values?",
            "What would you do differently if you were to experience this again?",
            "What external factors contributed to your success in this situation?",
            "How did you motivate yourself to push through the difficult moments?",
            "What did you learn about handling setbacks from this experience?",
            "How can you apply the lessons learned here to new situations?",
            "What role did others play in your success, and how did you collaborate?",
            "How did this experience affect your emotional well-being?",
            "What is one small step you can take today to build on this experience?",
            "What habits helped you succeed in this situation?",
            "How did you handle uncertainty during this experience?",
            "What was the most surprising part of this experience?",
            "How did you adapt when things did not go as planned?",
            "How can you use what you learned to help others?",
            "What are you most proud of from this experience?",
            "How does this experience connect with your long-term goals?",
            "What insights did this give you about your personal growth?",
            "What did this teach you about being resilient?",
            "How did you celebrate your success in this situation?",
            "What would your future self thank you for about this experience?"
        };

        shuffledQuestions = new Queue<string>();
    }

    private void DisplayWithTypewriterEffect(string text, int delay = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    public void RunReflectionSession()
    {
        Random random = new Random();
        int elapsedTime = 0;

        Console.Clear();
        DisplayWithTypewriterEffect("Consider the following prompt:");
        DisplayWithTypewriterEffect($"--- {WrapText(prompts[random.Next(prompts.Count)])} ---");
        DisplayWithTypewriterEffect("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.Clear();
        DisplayWithTypewriterEffect("Now, ponder each of the following questions regarding that experience.");
        DisplayWithTypewriterEffect("You may begin in...");
        ShowCountdown(5);

        while (elapsedTime < DurationInSeconds)
        {
            if (shuffledQuestions.Count == 0)
            {
                ShuffleQuestions();
            }

            string question = shuffledQuestions.Dequeue();
            Console.Clear();
            DisplayWithTypewriterEffect(WrapText(question));
            ShowProgressBar(5); 
            elapsedTime += 5;
        }
    }

    private void ShuffleQuestions()
    {
        Random random = new Random();
        List<string> tempQuestions = new List<string>(questions);

        for (int i = tempQuestions.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = tempQuestions[i];
            tempQuestions[i] = tempQuestions[j];
            tempQuestions[j] = temp;
        }

        shuffledQuestions = new Queue<string>(tempQuestions);
    }

    private string WrapText(string text)
    {
        string[] words = text.Split(' ');
        string wrappedText = "";
        string line = "";

        foreach (string word in words)
        {
            if ((line + word).Length > MaxLineLength)
            {
                wrappedText += line.TrimEnd() + "\n";
                line = "";
            }
            line += word + " ";
        }

        if (!string.IsNullOrWhiteSpace(line))
        {
            wrappedText += line.TrimEnd();
        }

        return wrappedText;
    }

    private void ShowProgressBar(int durationInSeconds)
    {
        int totalTicks = 20;
        int interval = durationInSeconds * 1000 / totalTicks;

        for (int i = 0; i <= totalTicks; i++)
        {
            int progress = (i * 100) / totalTicks;
            Console.Write($"\r[{new string('#', i)}{new string('-', totalTicks - i)}] {progress}%");
            Thread.Sleep(interval);
        }
        Console.WriteLine();
    }
}
