using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;


public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void WriteNewEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string random = prompt.GetRandomPrompt();
        Console.WriteLine($"Prompt: {random}");

        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(random, response, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry._date} - {entry._promptText}\n{entry._entryText}\n");
        }
    }

    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter the filename to save the journal: ");
        string fileName = "journal.txt";
        

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('|');
                    Entry loadedEntry = new Entry(parts[1], parts[2], parts[0]);
                    entries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded from file successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


}
