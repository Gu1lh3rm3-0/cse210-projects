using System;

public class WritingAssingment : Assingment
{
   private string _title;
   public WritingAssingment(string StudentName, string Topic, string Title) : base (StudentName, Topic)
   {
      _title = Title;
   }
   public string GetWritingInfo()
   {
    string StudentName = GetStudentName();
    return $"{_title} by {StudentName}";
   } 
}