using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    class Program
    {
        private static List<Ticket> AllTickets = new List<Ticket>(); //List for storage of all Tickets
        private static bool InternalGenerate = false; //Generator checks
        private static bool ExternalGenerate = false;
        static void Main()
        {
            
            ConsoleKeyInfo Option; //Object for menu key use
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
                            Generate.InternalTicket(AllTickets); //Generate Internal Tickets
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
                    case "2": //External Ticket Generate 
                        Console.Clear();
                        if (ExternalGenerate == false) //Check if run before
                        {
                            Generate.ExternalTicket(AllTickets); //Generate External Tickets
                            Console.WriteLine("Sussess: Sample External tickets generated for this session");
                            ExternalGenerate = true; //Prevent further running
                        }
                        else
                        {
                            Console.WriteLine("Error: External Ticket's have already been generated for this session");
                        }
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    case "0":   //List all tickets
                        Console.Clear();
                        if (AllTickets.Count == 0) //Check if empty
                            Console.WriteLine("Error: No tickets");
                        else
                            AllTickets.ForEach(p => p.Output()); //Calls the output function for every object in list
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                }
            } while (Option.Key != ConsoleKey.Escape); //Program Exit
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}