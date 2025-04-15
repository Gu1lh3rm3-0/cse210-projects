using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base ()
    {
       
    }
    public string GetRandomPrompt()
    {
       Random random = new Random();
       int promptsIndex = random.Next(_prompts.Count);
       return _prompts[promptsIndex];
    }
    public string GetRandomQuestion()
    {
       Random random = new Random();
       int questionsIndex = random.Next(_questions.Count);
       return _questions[questionsIndex];
    }
    public void DisplayPrompt()
    {
       ReflectingActivity randomPrompt = new ReflectingActivity();
       string choosedPrompt = randomPrompt.GetRandomPrompt();
       Console.Write(choosedPrompt);
    }
    public void DisplayQuestions()
    {
       ReflectingActivity randomQuestion = new ReflectingActivity();
       string choosedQuestion = randomQuestion.GetRandomQuestion();
       Console.Write(choosedQuestion);
    }
    public void Run()
    {
        
    }
}