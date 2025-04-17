using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal (string name, string description, int points) : base (name, description, points)
    {

    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
       _isComplete = true;
    }
    public override string GetStringRepresentation()
    {

    }
}