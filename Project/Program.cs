using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main()
        {
            bool InternalGenerate = false;
            List<Ticket> TicketList = new List<Ticket>();
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
                            Generate.InternalTicket();
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
                    case "2":   //Password Generator
                        Console.Clear();
                        PwdGen();
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                };
            } while (Option.Key != ConsoleKey.Escape);
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
        static void PwdGen()
        {
            Console.WriteLine("Comming soon!");
        }
    }
}