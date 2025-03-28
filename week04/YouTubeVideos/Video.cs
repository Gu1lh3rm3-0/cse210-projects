using System;

public class Videos
{
    public string _title;
    public string _author;
    public int _time;
    public List<Comments> _comments = new List<Comments>();

    public void Display()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_author}");
        Console.WriteLine($"Time: {_time} seconds");
        Console.WriteLine("Comments:");

        foreach (Comments comments in _comments)
        {
            comments.Display();
        }
    }

}