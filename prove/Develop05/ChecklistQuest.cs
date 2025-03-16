class ChecklistQuest : Quest
{
    private int _stepCount;
    private int _completedSteps;

    public ChecklistQuest(string name, string description, int points, int stepCount, bool isCompleted = false)
        : base(name, description, points, isCompleted)
    {
        _stepCount = stepCount;
        _completedSteps = 0;
    }

    public override string GetQuestType()
    {
        return "Checklist Quest";
    }

    public void ProgressStep()
    {
        if (_completedSteps < _stepCount)
        {
            _completedSteps++;
            Console.WriteLine($"✅ Step {_completedSteps}/{_stepCount} Completed!");

            if (_completedSteps == _stepCount)
            {
                Complete();
            }
        }
        else
        {
            Console.WriteLine("⚠️ This Quest is already complete.");
        }
    }

    public override string ToCsvString()
    {
        return $"{GetQuestType()}: {base.ToCsvString()}^{_stepCount}^{_completedSteps}";
    }
}
