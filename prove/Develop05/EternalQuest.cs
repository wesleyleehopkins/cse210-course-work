using System.ComponentModel;

class EternalQuest : Quest
{
    private int _completionCount ;

    public EternalQuest(string name, string description, int points, bool isCompleted= false) : base(name, description, points, isCompleted)
    {
        _completionCount= 0;
    }


    public override string GetQuestType()
    {
        return "Eternal Quest";

    }
    public override string ToCsvString()
    {
        return $"{GetQuestType()}: {base.ToCsvString()}^{_completionCount}";
    }
}