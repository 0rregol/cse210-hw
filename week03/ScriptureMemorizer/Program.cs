class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

          Console.WriteLine("How many words do you want to hide at a time? (Enter a number):");
        int wordsToHide;
        while (!int.TryParse(Console.ReadLine(), out wordsToHide) || wordsToHide <= 0)
        {
            Console.WriteLine("Please enter a valid number greater than 0:");
        } 

        while (true)
        {
        
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

        
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\n¡All words are hidden! Press Enter to exit.");
                Console.ReadLine();
                break;
            }

        
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

 
            scripture.HideRandomWords(wordsToHide);
        }
    }
}
// Showing Creativity and Exceeding Requirements: allows you to choose how many words to hide
