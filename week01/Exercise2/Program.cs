using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?.");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        
        string letter = "";
        
        if (grade>=90)
        {
            letter="A";
        }
        if((grade>=80)&&(grade<90))
        {
            letter="B";
        }
         if((grade>=70)&&(grade<80))
        {
            letter="C";
        }
         if((grade>=60)&&(grade<70))
        {
            letter="D";
        }
         if(grade<60)
        {
            letter="F";
        }

        Console.WriteLine($"Your grade is: {letter}");

         if(grade>=70)
        {
            Console.WriteLine("Congratulations on passing the course!.");
        }
        else
        {
            Console.WriteLine("Don't be discouraged, just try harder next time!.");
        }
    }
}
