using System.Collections.Generic;

namespace SecurityPlusGame.Models
{
    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        // Default points for each quiz question
        public int Points { get; set; } = 2;

        public QuizQuestion(string questionText, List<string> possibleAnswers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            PossibleAnswers = possibleAnswers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
