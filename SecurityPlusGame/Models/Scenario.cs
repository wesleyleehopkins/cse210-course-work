using System.Collections.Generic;

namespace SecurityPlusGame.Models
{
    public class Scenario
    {
        public string Title { get; set; }
        public string ScenarioStory { get; set; }
        public Dictionary<string, string> Flashcards { get; set; }
        public List<QuizQuestion> QuizQuestions { get; set; }

        // Initialized to string.Empty to avoid null warnings
        public string ChallengePrompt { get; set; } = string.Empty;

        public int ChallengePoints { get; set; } = 3;

        public Scenario(string title, string story)
        {
            Title = title;
            ScenarioStory = story;
            Flashcards = new Dictionary<string, string>();
            QuizQuestions = new List<QuizQuestion>();
        }
    }
}
