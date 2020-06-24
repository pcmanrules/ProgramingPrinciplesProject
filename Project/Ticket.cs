namespace Project
{
    public abstract class Ticket
    {
        private static int IDCounter = 0;
        protected int CounterPlus()
        {
            IDCounter++;
            return IDCounter;
        }
        public string ID, Creator, StaffID, Email, Description, Response, Status;
    }
}