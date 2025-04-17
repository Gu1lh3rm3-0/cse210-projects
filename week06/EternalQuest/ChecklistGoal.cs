using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
       _amountCompleted++;
       if (_amountCompleted > _target)
       {
         _isComplete = true;
       }
    }
    public override bool IsComplete()
    {

    }
    public override string GetStringRepresentation()
    {

    }
    public override string GetDetailsString()
    {

    }

}