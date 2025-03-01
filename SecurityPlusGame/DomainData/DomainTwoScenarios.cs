using System.Collections.Generic;
using SecurityPlusGame.Models;

namespace SecurityPlusGame.DomainData
{
    public class DomainTwoScenarios : DomainScenariosBase
    {
        public override List<Scenario> GetScenarios()
        {
            var scenarios = new List<Scenario>();
            scenarios.Add(GetScenario21());
            // Add 2.2, 2.3, etc. as needed
            return scenarios;
        }

        private Scenario GetScenario21()
        {
            var scenario = new Scenario(
                "2.1 Compare and Contrast Common Threat Actors and Motivations",
                "Detective Byte investigates sabotage at ByteCorp. Could it be a nation-state, insider threat, hacktivist, or something else?"
            );

            scenario.Flashcards.Add("Nation-State Actor", "Highly funded with advanced persistent threats (espionage).");
            scenario.Flashcards.Add("Insider Threat", "Abuse of legitimate access by employees/contractors.");
            scenario.Flashcards.Add("Hacktivist", "Motivated by ideology or politics.");
            scenario.Flashcards.Add("Organized Crime", "Cybercrime groups aiming for financial gain.");
            scenario.Flashcards.Add("Shadow IT", "Unapproved systems/services introduced by staff without official IT knowledge.");

            scenario.ChallengePrompt =
                "CHALLENGE: ByteCorp's R&D got leaked. Provide 1 clue that suggests an inside job vs. a foreign nation-state infiltration.";

            scenario.QuizQuestions.Add(new QuizQuestion(
                "1) Which threat actor typically has the MOST resources and sophistication?",
                new List<string> { "A) Script Kiddie", "B) Nation-State", "C) Insider Threat", "D) Hacktivist" },
                1 // B) Nation-State
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "2) An employee with legitimate access who copies sensitive data for personal gain is an example of:",
                new List<string> { "A) Insider Threat", "B) Organized Crime", "C) Nation-State", "D) Shadow IT" },
                0 // A) Insider Threat
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "3) Threat actor focusing on political or social agendas is known as:",
                new List<string> { "A) Hacktivist", "B) Script Kiddie", "C) Insider Threat", "D) Nation-State" },
                0 // A) Hacktivist
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "4) Workers using unauthorized cloud services or devices is an example of:",
                new List<string> { "A) Organized Crime", "B) Shadow IT", "C) Insider Threat", "D) Phishing" },
                1 // B) Shadow IT
            ));

            return scenario;
        }
    }
}
