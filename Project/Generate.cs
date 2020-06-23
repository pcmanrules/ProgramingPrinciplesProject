using System.Collections.Generic;

namespace Project
{
    class Generate
    {
        public static void InternalTicket(List<Ticket> Ticket)
        {
            Ticket.Add(new InternalTicket("Inna", "INNAM", "inna@whitecliffe.co.nz", "My monitor stopped working"));
            Ticket.Add(new InternalTicket("James", "JAMESM", "james@whitecliffe.co.nz", "Computer is slow, please fix!"));
            Ticket.Add(new InternalTicket("LINDAM", "Coffee machine in break room is too cold!"));
            Ticket.Add(new InternalTicket("Stanley", "STANLEYK", "stanley@whitecliffe.co.nz", "My computer can't cut and paste, only copy", "Attended on site, broken X key, keyboard replaced", "Closed"));
        }
    }
}
