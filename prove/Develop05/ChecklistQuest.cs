class ChecklistQuest : Quest
{
    private int _stepCount;
    private int _completedSteps;

    public ChecklistQuest(string name, string description, int points, int stepCount, bool isCompleted = false ): base(name, description, points, isCompleted)
    {
        _stepCount = stepCount;
        _completedSteps = 0;

    }
    



}