using System;
//using System.Collections.Generic;
//using System.IO;

class Journal
{
    private List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(string prompt)
    {
        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        entries.Add(new Entry(prompt, response, date));
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        //string filename = Console.ReadLine();
        string filename ="myFile.txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt()},{entry.GetResponse()}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }
    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string[] fields = reader.ReadLine().Split(',');
                string date = fields[0];
                string prompt = fields[1];
                string response = fields[2];
                entries.Add(new Entry(prompt, response, date));
            }
        }
        Console.WriteLine("Journal loaded from file.");
    }
}

