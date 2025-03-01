using System.Collections.Generic;
using SecurityPlusGame.Models;

namespace SecurityPlusGame.DomainData
{
    public class DomainFourScenarios : DomainScenariosBase
    {
        public override List<Scenario> GetScenarios()
        {
            var scenarios = new List<Scenario>();
            scenarios.Add(GetScenario48());
            // Add 4.1, 4.2, etc., as needed
            return scenarios;
        }

        private Scenario GetScenario48()
        {
            var scenario = new Scenario(
                "4.8 Explain Appropriate Incident Response Activities",
                "A massive data exfiltration is detected! Use IR steps (Preparation, Detection, Analysis, Containment, Eradication, Recovery, Lessons Learned) to handle it."
            );

            scenario.Flashcards.Add("Preparation", "Train staff, develop IR plans, gather tools.");
            scenario.Flashcards.Add("Detection", "Identify signs via alerts/logs.");
            scenario.Flashcards.Add("Analysis", "Investigate scope, cause, potential impact.");
            scenario.Flashcards.Add("Containment", "Isolate affected systems to prevent spread.");
            scenario.Flashcards.Add("Eradication", "Remove threat components (malware, compromised creds).");
            scenario.Flashcards.Add("Recovery", "Restore systems, confirm normal ops.");
            scenario.Flashcards.Add("Lessons Learned", "Document, improve processes, share knowledge.");

            scenario.ChallengePrompt =
                "CHALLENGE: Outline a quick plan for handling a ransomware outbreak from Detection to Lessons Learned.";

            scenario.QuizQuestions.Add(new QuizQuestion(
                "1) Which IR step involves isolating compromised hosts to prevent further spread?",
                new List<string> { "A) Detection", "B) Containment", "C) Recovery", "D) Analysis" },
                1 // B) Containment
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "2) Removing malicious files, patches, or attacker accounts from the environment is part of:",
                new List<string> { "A) Eradication", "B) Recovery", "C) Lessons Learned", "D) Preparation" },
                0 // A) Eradication
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "3) During which phase do you fully restore operations and ensure no backdoors remain?",
                new List<string> { "A) Containment", "B) Recovery", "C) Eradication", "D) Detection" },
                1 // B) Recovery
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "4) After the incident is over, the team meets to discuss what went right/wrong and updates policies. Which step is this?",
                new List<string> { "A) Analysis", "B) Preparation", "C) Lessons Learned", "D) Detection" },
                2 // C) Lessons Learned
            ));

            return scenario;
        }
    }
}
