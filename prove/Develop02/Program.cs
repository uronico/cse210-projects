using System;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();

        while (true)
        {
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3:
                    journal.SaveJournalToFile();
                    break;

                case 4:
                    journal.LoadJournalFromFile();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("\n1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }
}