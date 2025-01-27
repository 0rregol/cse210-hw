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
            foreach (var entry in Entries) 
            {
                
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

   
    public void LoadFromFile(string filename)
    {
        Entries.Clear(); 
        string[] lines = File.ReadAllLines(filename); 

        foreach (string line in lines) 
        {
            string[] parts = line.Split('|'); 
            Entry entry = new Entry(parts[1], parts[2], parts[0]);
            Entries.Add(entry); 
        }
    }
}
