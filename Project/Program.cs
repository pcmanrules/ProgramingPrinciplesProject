using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main()
        {
            bool InternalGenerate = false;
            List<object> TicketList = new List<object>();
            ConsoleKeyInfo Option;
            do
            {
                Console.Clear();
                Console.Write("╔══════════════════════════════════════════════╗\n" +
                              "║ Ticket System                                ║\n" +
                              "╠══════════════════════════════════════════════╣\n" +
                              "║ 1: Internal Ticket Generate                  ║\n" +
                              "║ 2: Password Generator                        ║\n" +
                              "║ Esc: Exit                                    ║\n" +
                              "╚══════════════════════════════════════════════╝\n" +
                              "Option: ");
                Option = Console.ReadKey(false);
                switch (Option.KeyChar.ToString())
                {
                    case "1":   //Internal Ticket Generate 
                        Console.Clear();
                        if (InternalGenerate == false)
                        {
                            TicketList.Add(new InternalTicket("Inna", "INNAM", "inna@whitecliffe.co.nz", "My monitor stopped working"));
                            TicketList.Add(new InternalTicket("Maria", "MARIAH", "maria@whitecliffe.co.nz", "Request for a video camera to conduct webinar"));
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
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
        static void PwdGen()
        {
            Console.WriteLine("Comming soon!");
        }
    }
}