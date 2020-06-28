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

        protected string ID, Creator, StaffID, Email, Description, Response, Status;

        public abstract void Output();
    }
}