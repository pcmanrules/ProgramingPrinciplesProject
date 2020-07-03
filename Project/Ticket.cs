namespace Project
{
    public abstract class Ticket
    {
        private static int _idCounter;

        protected string Id, Creator, StaffId, Email, Description, Response, Status;

        protected int CounterPlus()
        {
            _idCounter++;
            return _idCounter;
        }

        public abstract void Output();

        public string TicketStatus()
        {
            return Status;
        }
    }
}