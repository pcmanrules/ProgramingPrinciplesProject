using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        protected static List<Ticket> AllTickets = new List<Ticket>();
        static protected void Main()
        {
            bool InternalGenerate = false;
            ConsoleKeyInfo Option;
            do
            {
                Menu.ShowMain();
                Option = Console.ReadKey(false);
                switch (Option.KeyChar.ToString())
                {
                    case "1":   //Internal Ticket Generate 
                        Console.Clear();
                        if (InternalGenerate == false)
                        {
                            Generate.InternalTicket(AllTickets);
                            Console.WriteLine("Sussess: Sample internal tickets generated for this session");
                            InternalGenerate = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: Internal Ticket's have already been generated for this session");
                        }
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    case "2":   //List all tickets
                        Console.Clear();
                        AllTickets.ForEach(p => p.StringOutput(p));
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                };
            } while (Option.Key != ConsoleKey.Escape);
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}