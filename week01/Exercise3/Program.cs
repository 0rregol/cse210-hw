using System;

class Program
{
    static void Main(string[] args)
    {
        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1,101);
        int number = -1;

        while(number!=magicNumber)
        {
            Console.Write("What is your guess?.");
            number = int.Parse(Console.ReadLine());
            if(magicNumber>number)
            {
                Console.WriteLine("Higher");
            }
            if(magicNumber<number)
            {
                Console.WriteLine("Lower");
            }
            if(magicNumber==number)
            {
                Console.WriteLine("You guessed it!");
            }

        }
       
    }
}
