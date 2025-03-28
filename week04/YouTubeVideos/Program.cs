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

        v1._author = "";
        v1._title = "";
        v1._time = 20;

        v2._author = "";
        v2._title = "";
        v2._time = 20; 

        v3._author = "";
        v3._title = "";
        v3._time = 20; 

        v4._author = "";
        v4._title = "";
        v4._time = 20;  
    }
}