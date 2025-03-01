
namespace SecurityPlusGame.DomainData
{
    // Demonstrates inheritance: a base class each domain extends.
    // Holds an abstract method to return a list of Scenarios.
    using System.Collections.Generic;
    using SecurityPlusGame.Models;

    public abstract class DomainScenariosBase
    {
        // Each derived class must implement this method
        public abstract List<Scenario> GetScenarios();
    }
}
