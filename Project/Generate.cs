using System.Collections.Generic;

namespace Project
{
    internal class Generate
    {
        public static void InternalTicket(List<Ticket> ticket)
        {
            ticket.Add(new InternalTicket("Inna", "INNAM", "inna@whitecliffe.co.nz", "My monitor stopped working"));
            ticket.Add(
                new InternalTicket("James", "JAMESM", "james@whitecliffe.co.nz", "Computer is slow, please fix!"));
            ticket.Add(new InternalTicket("LINDAM", "Coffee machine in break room is too cold!"));
            ticket.Add(new InternalTicket("Stanley", "STANLEYK", "stanley@whitecliffe.co.nz",
                "My computer can't cut and paste, only copy", "Attended on site, broken X key, keyboard replaced",
                "Closed"));
            ticket.Add(new InternalTicket("Peter", "PETERF", "peter@whitecliffe.co.nz", "Password Change"));
        }

        public static void ExternalTicket(List<Ticket> ticket)
        {
            ticket.Add(new ExternalTicket("The CCTV Monitor in the lobby is blank"));
            ticket.Add(new ExternalTicket("Hannah", "hannybunny@gmail.com",
                "Email app on phone is no longer functioning off site"));
            ticket.Add(new ExternalTicket("Lindsey", "lindsey.powell@outlook.com",
                "My computer will only start boot to Startup Repair", "Technician attended and repaired OS, 1.5 Hr",
                "Closed"));
        }
    }
}