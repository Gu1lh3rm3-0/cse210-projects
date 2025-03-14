using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        Prompt p1 = new Prompt();
        p1._prompt = "For what are you grateful today?";

        Prompt p2 = new Prompt();
        p2._prompt = "Did you do any good for another person today?";

        Prompt p3 = new Prompt();
        p3._prompt = "What was the most meaninful thing that you learned in the scriptures today?";

        Prompt p4 = new Prompt();
        p4._prompt = "What was the best part of my day?";

        Prompt p5 = new Prompt();
        p5._prompt = "If you could change something today what would be?";

        Prompt allPrompts = new Prompt();

        allPrompts.myPrompts.Add(p1);
        allPrompts.myPrompts.Add(p2);
        allPrompts.myPrompts.Add(p3);
        allPrompts.myPrompts.Add(p4);
        allPrompts.myPrompts.Add(p5);

        allPrompts.Display();
    }
}