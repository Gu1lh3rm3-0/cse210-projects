using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
       _name = "";
       _description = "";
       _duration = 0;
    }
    public void DisplayStartingMessage()
    {
       Console.WriteLine($"Welcome to the {_name} activity!");
    }
    public void DisplayEndingMessage()
    {
       Console.WriteLine($"You have completed the {_name} activity! ");
    }
    public void ShowSpinner(int seconds)
    {
       _duration = seconds;
       List<String> animations = new List<string>();
       animations.Add("|");
       animations.Add("/");
       animations.Add("-");
       animations.Add("\\");

       DateTime startSpinner = DateTime.Now;
       DateTime endSpinner = startSpinner.AddSeconds(_duration);

       int sec = 0;

       while (DateTime.Now < endSpinner)
       {
          string spinner = animations[sec];
          Console.Write(spinner);
          Thread.Sleep(1000);
          Console.Write("\b\b");
          sec ++;
          
          if (sec >= animations.Count)
          {
            sec = 0;
          }
       }
    }
    public void ShowCountDown(int seconds)
    {
        _duration = seconds;
        for (int sec = _duration; sec > 0; sec--)
        {
            Console.Write(sec);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}