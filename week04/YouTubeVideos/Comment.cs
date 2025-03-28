using System;

public class Comments
{
    public string _comment;
    public string _name;

    public void Display()
    {
        Console.WriteLine($"{_name}: {_comment}");
    }
}