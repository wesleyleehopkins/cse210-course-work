using System.Collections.Generic;
using SecurityPlusGame.Models;

namespace SecurityPlusGame.DomainData
{
    public class DomainOneScenarios : DomainScenariosBase
    {
        // We'll store sub-objectives (1.1, 1.2, etc.) as separate scenarios in private methods
        public override List<Scenario> GetScenarios()
        {
            var scenarios = new List<Scenario>();
            scenarios.Add(GetScenario11());
            scenarios.Add(GetScenario12());
            // If you have 1.3, 1.4, etc., you can add them here
            return scenarios;
        }

        // ----------------------------
        // Sub-objective 1.1
        // ----------------------------
        private Scenario GetScenario11()
        {
            var scenario = new Scenario(
                "1.1 Compare and Contrast Various Types of Security Controls",
                "You’re the Castle Security Captain. Your fortress must defend against marauding cyber-knights (hackers)."
            );

            // Flashcards
            scenario.Flashcards.Add("Technical Controls", "Security measures implemented via technology (e.g., firewalls, IDS/IPS).");
            scenario.Flashcards.Add("Managerial Controls", "Policies, procedures, standards, and risk assessments.");
            scenario.Flashcards.Add("Operational Controls", "Day-to-day security mechanisms (e.g., user training, incident response).");
            scenario.Flashcards.Add("Physical Controls", "Locks, fences, cameras, security guards.");
            scenario.Flashcards.Add("Preventive Controls", "Stop incidents before they occur (locked doors, firewalls).");
            scenario.Flashcards.Add("Detective Controls", "Identify incidents during or after they occur (IDS, cameras).");
            scenario.Flashcards.Add("Corrective Controls", "Restore systems after an incident (backups, patching).");
            scenario.Flashcards.Add("Compensating Controls", "Alternate measures if the primary control isn’t feasible.");

            // Challenge
            scenario.ChallengePrompt =
                "CHALLENGE: An enemy spy disguised as a bard tries to enter. Which control DETECTS him, and which PREVENTS infiltration?";

            // Quiz questions (expanded)
            scenario.QuizQuestions.Add(new QuizQuestion(
                "1) Which control type is used to discover a breach soon after it happens?",
                new List<string> { "A) Preventive", "B) Detective", "C) Corrective", "D) Directive" },
                1 // B) Detective
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "2) Using camera surveillance to see if someone is tailgating is an example of which control type?",
                new List<string> {
                    "A) Physical + Detective",
                    "B) Managerial + Preventive",
                    "C) Technical + Compensating",
                    "D) Physical + Compensating"
                },
                0 // A) Physical + Detective
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "3) Which control type is specifically designed to return a system to normal operation after an incident?",
                new List<string> {
                    "A) Preventive",
                    "B) Detective",
                    "C) Corrective",
                    "D) Compensating"
                },
                2 // C) Corrective
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "4) Creating a set of backup authentication methods when the primary system is down is an example of:",
                new List<string> {
                    "A) Physical Control",
                    "B) Managerial Control",
                    "C) Compensating Control",
                    "D) Operational Control"
                },
                2 // C) Compensating Control
            ));

            return scenario;
        }

        // ----------------------------
        // Sub-objective 1.2
        // ----------------------------
        private Scenario GetScenario12()
        {
            var scenario = new Scenario(
                "1.2 Summarize Fundamental Security Concepts",
                "Welcome to the Interstellar Port. You must apply CIA, AAA, Zero Trust, and more. No spaceship is automatically trusted!"
            );

            scenario.Flashcards.Add("CIA Triad", "Confidentiality, Integrity, Availability.");
            scenario.Flashcards.Add("Non-Repudiation", "Ensuring an entity cannot deny an action (digital signatures, logs).");
            scenario.Flashcards.Add("AAA", "Authentication, Authorization, and Accounting.");
            scenario.Flashcards.Add("Zero Trust", "\"Never trust, always verify,\" with segmented access.");
            scenario.Flashcards.Add("Gap Analysis", "Finding differences between current posture and the ideal state.");

            scenario.ChallengePrompt =
                "CHALLENGE: A suspicious stowaway is tampering with cargo data. Which part of CIA is at risk, and how might AAA help?";

            // Expanded quiz questions
            scenario.QuizQuestions.Add(new QuizQuestion(
                "1) Which element of the CIA Triad focuses on ensuring information remains unaltered?",
                new List<string> { "A) Confidentiality", "B) Integrity", "C) Availability", "D) Non-Repudiation" },
                1 // B) Integrity
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "2) An admin uses digital signatures to prove a user sent a message. This is an example of:",
                new List<string> { "A) Authorization", "B) Non-Repudiation", "C) Availability", "D) Encryption" },
                1 // B) Non-Repudiation
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "3) In AAA, which step determines a user's permissions after identity is confirmed?",
                new List<string> { "A) Accounting", "B) Attestation", "C) Authorization", "D) Authentication" },
                2 // C) Authorization
            ));
            scenario.QuizQuestions.Add(new QuizQuestion(
                "4) Which concept states that each network segment or resource requires verification, without implicit trust?",
                new List<string> { "A) Defense in Depth", "B) Zero Trust", "C) Non-Repudiation", "D) Principle of Least Privilege" },
                1 // B) Zero Trust
            ));

            return scenario;
        }
    }
}
