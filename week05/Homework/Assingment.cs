using System;
public class Assingment
{
    private string _studentName;
    private string _topic;
    public Assingment(string StudentName, string Topic)
    {
        _studentName = StudentName;
        _topic = Topic;
    }
    public string GetStudentName()
    {
       return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}