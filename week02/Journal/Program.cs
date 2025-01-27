public class Program
{
    private Journal journal;
    private PromptGenerator promptGenerator; 
  
    public Program()
    {
        journal = new Journal();
        promptGenerator = new PromptGenerator();
    }

    
    public void ShowMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

  
    public void Run()
    {
      while (true) 
        {
            ShowMenu(); 
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine(); 

            switch (choice) 
            {
                case "1":
                    WriteNewEntry(); 
                    break;
                case "2":
                    journal.DisplayAll(); 
                    break;
                case "3":
                    SaveJournal(); 
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Invalid option. Try again."); 
                    break;
            }
        }
    }

    
    private void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt(); 
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine(); 
        string date = DateTime.Now.ToShortDateString(); 

        Entry entry = new Entry(prompt, response, date); 
        journal.AddEntry(entry); 
    }

   
    private void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine(); 
        journal.SaveToFile(filename); 
        Console.WriteLine("Journal saved successfully.");
    }

    
    private void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine(); 
        journal.LoadFromFile(filename); 
        Console.WriteLine("Journal loaded successfully.");
    }

    
    public static void Main(string[] args)
    {
        Program program = new Program(); 
        program.Run(); 
    }
}
