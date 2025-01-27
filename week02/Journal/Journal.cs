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
        // Escribir la cabecera del CSV
        outputFile.WriteLine("Date,Prompt,Response");

        foreach (var entry in Entries)
        {
            // Escapar comillas en el contenido
            string escapedPrompt = entry.Prompt.Replace("\"", "\"\"");
            string escapedResponse = entry.Response.Replace("\"", "\"\"");

            // Escribir la entrada en formato CSV
            outputFile.WriteLine($"\"{entry.Date}\",\"{escapedPrompt}\",\"{escapedResponse}\"");
        }
    }
}

   
public void LoadFromFile(string filename)
{
    Entries.Clear(); // Limpiar entradas actuales
    string[] lines = File.ReadAllLines(filename);

    // Saltar la cabecera (primera línea)
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(',');

        // Eliminar comillas y manejar contenido escapado
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"').Replace("\"\"", "\"");
        string response = parts[2].Trim('"').Replace("\"\"", "\"");

        // Crear una nueva entrada
        Entry entry = new Entry(prompt, response, date);
        Entries.Add(entry);
    }
}
}
