using System;

class Program
{
    static void Main(string[] args)
    {
        Comments c1 = new Comments();
        Comments c2 = new Comments();
        Comments c3 = new Comments();
        Comments c4 = new Comments();

        c1._name = "John";
        c1._comment = "Amazing video!"; 

        c2._name = "James";
        c2._comment = "I liked the video"; 

        c3._name = "William";
        c3._comment = "Don't stop post videos like this"; 

        c4._name = "Susan";
        c4._comment = "The best video that I saw today! ";

        Videos v1 = new Videos();
        Videos v2 = new Videos();
        Videos v3 = new Videos();
        Videos v4 = new Videos();

        v1._author = "Josh";
        v1._title = "Teaching tricks to my dog";
        v1._time = 40;

        v2._author = "Vivian";
        v2._title = "Chocolate cake recipe";
        v2._time = 27; 

        v3._author = "Thomas";
        v3._title = "Which is the best car to buy this year?";
        v3._time = 30; 

        v4._author = "Samuel";
        v4._title = "Which is the cheapest course of BYU?";
        v4._time = 20;

        v1._comments.Add(c1);
        v1._comments.Add(c2); 
        v1._comments.Add(c3); 
        v1._comments.Add(c4);

        v2._comments.Add(c1); 
        v2._comments.Add(c2); 
        v2._comments.Add(c3); 
        v2._comments.Add(c4); 

        v3._comments.Add(c1); 
        v3._comments.Add(c2); 
        v3._comments.Add(c3); 
        v3._comments.Add(c4); 

        v4._comments.Add(c1); 
        v4._comments.Add(c2); 
        v4._comments.Add(c3); 
        v4._comments.Add(c4);

        v1.Display();

        v2.Display();

        v3.Display();

        v4.Display();
    }
}