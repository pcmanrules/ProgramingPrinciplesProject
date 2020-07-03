using System;
using System.Collections.Generic;

namespace Project
{
    internal class Program
    {
        private static readonly List<Ticket> AllTickets = new List<Ticket>(); //List for storage of all Tickets
        private static bool _internalGenerate; //Generator checks
        private static bool _externalGenerate;

        private static void Main()
        {
            ConsoleKeyInfo option; //Object for menu key use
            do
            {
                Menu.ShowMain(); //Write Menu
                option = Console.ReadKey(false); //Wait and read user key press
                switch (option.KeyChar.ToString()) //Menu Options
                {
                    case "1": //Internal Ticket Generate
                        Console.Clear();
                        if (_internalGenerate == false) //Check if run before
                        {
                            Generate.InternalTicket(AllTickets); //Generate Internal Tickets
                            Console.WriteLine("Success: Sample internal tickets generated for this session");
                            _internalGenerate = true; //Prevent further running
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
                        if (_externalGenerate == false) //Check if run before
                        {
                            Generate.ExternalTicket(AllTickets); //Generate External Tickets
                            Console.WriteLine("Success: Sample External tickets generated for this session");
                            _externalGenerate = true; //Prevent further running
                        }
                        else
                        {
                            Console.WriteLine("Error: External Ticket's have already been generated for this session");
                        }

                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;

                    case "4": //Display all tickets
                        Console.Clear();
                        var stats = TicketStats.Output(); //Retrieve statistics as an int array and output
                        Console.WriteLine("Tickets Created: " + stats[0] + "\n" +
                                          "Tickets Resolved: " + stats[2] + "\n" +
                                          "Tickets To Solve: " + stats[1] + "\n"
                        );
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;

                    case "3": //List all tickets
                        Console.Clear();
                        if (AllTickets.Count == 0) //Check if empty
                            Console.WriteLine("Error: No tickets");
                        else
                            AllTickets.ForEach(p => p.Output()); //Calls the output function for every object in list
                        Console.Write("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                }
            } while (option.Key != ConsoleKey.Escape); //Program Exit

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}