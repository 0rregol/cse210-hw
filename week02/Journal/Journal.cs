using System;
using System.Collections.Generic;

public class Journal
{
    
    public List<Entry> Entries { get; set; }

   
    public Journal()
    {
        Entries = new List<Entry>();
    }

   
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry); 
    }

    
    public void DisplayAll()
    {
        foreach (var entry in Entries) 
        {
            entry.Display(); 
        }
    }

    
    public void SaveToFile(string filename)
{
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        
        outputFile.WriteLine("Date,Prompt,Response");

        foreach (var entry in Entries)
        {
            
            string escapedPrompt = entry.Prompt.Replace("\"", "\"\"");
            string escapedResponse = entry.Response.Replace("\"", "\"\"");

           
            outputFile.WriteLine($"\"{entry.Date}\",\"{escapedPrompt}\",\"{escapedResponse}\"");
        }
    }
}

   
public void LoadFromFile(string filename)
{
    Entries.Clear(); 
    string[] lines = File.ReadAllLines(filename);

  
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(',');

        
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"').Replace("\"\"", "\"");
        string response = parts[2].Trim('"').Replace("\"\"", "\"");

       
        Entry entry = new Entry(prompt, response, date);
        Entries.Add(entry);
    }
}
}
