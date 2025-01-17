using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        int userNumbers = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(userNumbers !=0)
        {
            
            Console.Write("Enter number:");
            string response = Console.ReadLine();
            userNumbers = int.Parse(response);
            if(userNumbers!=0)
            {
                numbers.Add(userNumbers);
            }
        

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    

    }

     
     
     
}
