using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on. your own understanding; in all your ways submit to. Him, and He will make your paths straight.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide a random word, or type 'quit' to exit: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1);
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. The game is over.");
                break;
            }
        }
    
    }
    
    
}