using System;
using System.Collections.Generic;
using SecurityPlusGame.Models;
using SecurityPlusGame.DomainData;

namespace SecurityPlusGame.Services
{
    public class GameManager
    {
        private List<Scenario> _allScenarios = new List<Scenario>();
        private int _totalScore = 0;

        public void InitializeScenarios()
        {
            // Here we instantiate each domain's scenario class
            DomainScenariosBase domainOne = new DomainOneScenarios();
            DomainScenariosBase domainTwo = new DomainTwoScenarios();
            DomainScenariosBase domainFour = new DomainFourScenarios();
            DomainScenariosBase domainFive = new DomainFiveScenarios();
            // If you had DomainThree or more sub-objectives, add them too!

            // Collect all scenarios from each domain
            _allScenarios.AddRange(domainOne.GetScenarios());
            _allScenarios.AddRange(domainTwo.GetScenarios());
            _allScenarios.AddRange(domainFour.GetScenarios());
            _allScenarios.AddRange(domainFive.GetScenarios());
        }

        public void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the CompTIA Security+ (SY0-701) Interactive Study Game!");
            Console.WriteLine("We have multiple domains loaded (1, 2, 4, 5). Answer questions, complete challenges, earn points, and level up!");
            Console.WriteLine("\nPress Enter to begin...");
            Console.ReadLine();

            foreach (var scenario in _allScenarios)
            {
                Console.Clear();
                Console.WriteLine($"=== SCENARIO: {scenario.Title} ===\n");
                // Role-Playing Story
                Console.WriteLine($"Story:\n{scenario.ScenarioStory}\n");

                // Flashcards
                Console.WriteLine("FLASHCARDS (Key Terms):");
                foreach (var fc in scenario.Flashcards)
                {
                    Console.WriteLine($" - {fc.Key}: {fc.Value}");
                }
                Console.WriteLine();

                // Challenge
                if (!string.IsNullOrEmpty(scenario.ChallengePrompt))
                {
                    Console.WriteLine(scenario.ChallengePrompt);
                    Console.Write("Type your response (Press Enter when done): ");
                    Console.ReadLine();  
                    Console.WriteLine($"Great job! You earned {scenario.ChallengePoints} bonus points.");
                    _totalScore += scenario.ChallengePoints;
                    Console.WriteLine($"Current Score: {_totalScore}\n");
                }

                // Quiz
                Console.WriteLine("QUIZ TIME!\n");
                foreach (var q in scenario.QuizQuestions)
                {
                    Console.WriteLine(q.QuestionText);
                    foreach (var ans in q.PossibleAnswers)
                    {
                        Console.WriteLine(ans);
                    }

                    Console.Write("Your answer (A/B/C/D): ");
                    string userAnswer = Console.ReadLine()?.Trim().ToUpper() ?? "";

                    int selectedIndex = -1;
                    switch (userAnswer)
                    {
                        case "A": selectedIndex = 0; break;
                        case "B": selectedIndex = 1; break;
                        case "C": selectedIndex = 2; break;
                        case "D": selectedIndex = 3; break;
                        default:
                            Console.WriteLine("Invalid input. No points awarded.");
                            break;
                    }

                    if (selectedIndex == q.CorrectAnswerIndex)
                    {
                        Console.WriteLine($"Correct! You earned {q.Points} points.");
                        _totalScore += q.Points;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Better luck next time!");
                    }
                    Console.WriteLine($"Current Score: {_totalScore}\n");
                }

                // Pause
                Console.WriteLine("Press Enter to continue to the next scenario...");
                Console.ReadLine();
            }

            // End of the game
            Console.Clear();
            Console.WriteLine("All scenarios completed!");
            Console.WriteLine($"Your final score: {_totalScore}");
            Console.WriteLine(GetLevelTitle(_totalScore));
            Console.WriteLine("\nThanks for playing, and good luck with your Security+ studies!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Fun leveling system based on final score
        private string GetLevelTitle(int score)
        {
            if (score <= 10) return "Level: Security Squire";
            else if (score <= 20) return "Level: Cyber Knight";
            else if (score <= 30) return "Level: InfoSec Wizard";
            else if (score <= 40) return "Level: Security Dragon Master";
            else return "Level: Ultimate Cyber Champion";
        }
    }
}
