using System;
using System.Collections.Generic;

namespace Project
{
    class Generate
    {
        public static void InternalTicket(List<Ticket> Ticket)
        {
            Ticket.Add(new InternalTicket("Inna", "INNAM", "inna@whitecliffe.co.nz", "My monitor stopped working"));
            Console.WriteLine("Generating...");
        }
    }
}
