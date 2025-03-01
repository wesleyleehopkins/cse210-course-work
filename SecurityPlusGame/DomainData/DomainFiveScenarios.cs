using System.Collections.Generic;
using SecurityPlusGame.Models;

namespace SecurityPlusGame.DomainData
{
    public class DomainFiveScenarios : DomainScenariosBase
    {
        public override List<Scenario> GetScenarios()
        {
            var scenarios = new List<Scenario>();
            scenarios.Add(GetScenario56());
            // Add 5.1, 5.2, etc., as needed
            return scenarios;
        }

        private Scenario GetScenario56()
        {
            var scenario = new Scenario(
                "5.6 Implement Security Awareness Practices",
                "You’re the Chief People Officer launching a new security awareness program (phishing simulations, user training, etc.)."
            );

            scenario.Flashcards.Add("Phishing Campaign", "Simulated attacks to test and train users on email threats.");
            scenario.Flashcards.Add("Insider Threat Awareness", "Encouraging employees to watch for suspicious staff behaviors.");
            scenario.Flashcards.Add("Reporting Procedure", "Policies on how to report suspicious emails/incidents quickly.");

            scenario.ChallengePrompt =
                "CHALLENGE: Propose a fun/creative monthly security training idea beyond a dull PowerPoint.";

            scenario.QuizQuestions.Add(new QuizQuestion(
                "1) What is the main purpose of a simulated phishing campaign?",
                new List<string> {
                    "A) Harvest employee credentials",
                    "B) Evaluate and improve user ability to identify phishing",
                    "C) Punish employees who click",
                    "D) Reveal system patches"
                },
                1 // B) Evaluate/improve user ability
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "2) Why should security awareness training be recurring?",
                new List<string> {
                    "A) Because tech never changes",
                    "B) Threats remain static",
                    "C) Users can forget best practices over time",
                    "D) It's only needed once"
                },
                2 // C) Users can forget
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "3) Which type of internal threat might user-awareness training help detect early?",
                new List<string> { "A) Nation-State", "B) Insider Threat", "C) Hacktivist", "D) Malware" },
                1 // B) Insider Threat
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "4) Encouraging employees to report suspicious behavior from peers is which practice?",
                new List<string> { "A) Insider Threat Awareness", "B) Social Engineering Testing", "C) Zero Trust", "D) Security Gap Analysis" },
                0 // A) Insider Threat Awareness
            ));

            return scenario;
        }
    }
}
