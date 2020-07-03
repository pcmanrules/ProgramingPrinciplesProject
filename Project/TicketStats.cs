namespace Project
{
    internal class TicketStats
    {
        private static int _total;
        private static int _open;
        private static int _closed;

        static TicketStats()
        {
            _total = 0;
            _open = 0;
            _closed = 0;
        }

        public static int[] Output()
        {
            var stats = new int[3];
            stats[0] = _total;
            stats[1] = _open;
            stats[2] = _closed;
            return stats;
        }

        public static void Input(Ticket ticket)
        {
            _total++;
            if (ticket.TicketStatus() == "Open") _open++;
            if (ticket.TicketStatus() == "Closed") _closed++;
        }
    }
}