using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        protected static List<Ticket> AllTickets = new List<Ticket>(); //Create list for all tickets
        static protected void Main()
        {
            bool InternalGenerate = false; //Generator checks
            ConsoleKeyInfo Option; //Object for menu key use
            ConsoleKeyInfo OptionSecret;
            do
            {
                Menu.ShowMain(); //Write Menu
                Option = Console.ReadKey(false); //Wait and read user key press
                switch (Option.KeyChar.ToString()) //Menu Options
                {
                    case "1": //Internal Ticket Generate 
                        Console.Clear();
                        if (InternalGenerate == false) //Check if run before
                        {
                            Generate.InternalTicket(AllTickets);
                            Console.WriteLine("Sussess: Sample internal tickets generated for this session");
                            InternalGenerate = true; //Prevent further running
                        }
                        else
                        {
                            Console.WriteLine("Error: Internal Ticket's have already been generated for this session");
                        }
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    case "0":   //List all tickets
                        Console.Clear();
                        AllTickets.ForEach(p => Output.StringOutput(p));
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    case "s":   //Secret debug menu
                        {
                            do
                            {
                                Console.Clear();
                                Menu.ShowSecret();
                                OptionSecret = Console.ReadKey(false);
                                switch (OptionSecret.KeyChar.ToString())
                                {
                                    case "1":
                                        {
                                            break;
                                        }
                                };
                            } while (OptionSecret.Key != ConsoleKey.Escape);
                            break;
                        }
                };
            } while (Option.Key != ConsoleKey.Escape);
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}