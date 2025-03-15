using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        List<Entry> oldEntries = ReadfromFile();
        List<Entry> allEntries = new List<Entry>();

        int options = 0;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        while (options != 5)

        {
            Console.WriteLine("Welcome to your jornal! ");
            Console.WriteLine("1.Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select one of the options above: ");
            String select = Console.ReadLine();
            options = int.Parse(select);
            Entry e = new Entry();

            if (options == 1)
            {
                Console.Write("");
                String anEntry = Console.ReadLine();
                e._entryText = anEntry;
                allEntries.Add(e);

            }
            else if (options == 2)
            {
                Console.WriteLine(allEntries);
            }
            else if (options == 3)
            {
                foreach(Entry ent in oldEntries)
                {
                    Console.WriteLine(ent._entryText);
                }
            }
            else if (options == 4)
            {
                SaveToFile(allEntries);
            }
            else 
            {
                Console.WriteLine("Closing your jornal");
            }
        }

        Entry p1 = new Entry();
        p1._promptText = "For what are you grateful today?";

        Entry p2 = new Entry();
        p2._promptText = "Did you do any good for another person today?";

        Entry p3 = new Entry();
        p3._promptText = "What was the most meaninful thing that you learned in the scriptures today?";

        Entry p4 = new Entry();
        p4._promptText = "What was the best part of my day?";

        Entry p5 = new Entry();
        p5._promptText = "If you could change something today what would be?";

        Prompt allPrompts = new Prompt();

        allPrompts._newPrompt.Add(p1);
        allPrompts._newPrompt.Add(p2);
        allPrompts._newPrompt.Add(p3);
        allPrompts._newPrompt.Add(p4);
        allPrompts._newPrompt.Add(p5);

    }

    //Function to save the file
    public static void SaveToFile(List<Entry> allEntries)
    {
        string filename = "jornal.txt";

        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            foreach (Entry myEntries in allEntries)
            {
                outPutFile.WriteLine(myEntries._entryText);
            }
        }
    }

    //Function to read the file
    public static List<Entry> ReadfromFile()
    {
       List<Entry> allEntries = new List<Entry>();
       string filename = "jornal.txt";
       string[] lines = System.IO.File.ReadAllLines(filename);
       foreach (string line in lines)
       {
        Console.WriteLine(line);
       }
       return allEntries; 
    }
}