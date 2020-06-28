using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class TicketStats
    {
        private static int Total;
        private static int Open;
        private static int Closed;
        static TicketStats()
        {
            Total = 0;
            Open = 0;
            Closed = 0;
        }
        public static int[] Output()
        {
            int[] stats = new int[3];
            stats[0] = Total;
            stats[1] = Open;
            stats[2] = Closed;
            return stats;
        }
        public static void Input(Ticket Ticket)
        {
            Total++;
            if (Ticket.TicketStatus() == "Open")
            {
                Open++;
            }
            if (Ticket.TicketStatus() == "Closed")
            {
                Closed++;
            }
        }
    }
}
