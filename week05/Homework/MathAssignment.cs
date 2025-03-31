using System;

public class MathAssingment : Assingment
{
   private string _textBookSection;
   private string _problems;
   public MathAssingment(string StudentName, string Topic, string TextBookSection, string Problems) : base (StudentName,Topic)
   {
      _textBookSection = TextBookSection;
      _problems = Problems;
   }
   public string GetHomeworkList()
   {
     return $"Section: {_textBookSection} Problems: {_problems}";
   }  
}