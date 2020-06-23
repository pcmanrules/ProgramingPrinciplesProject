using System;

namespace Project
{
    public abstract class Ticket
    {
        private static int IDCounter = 0;
        protected string CounterPlus()
        {
            IDCounter++;
            return IDCounter.ToString();
        }
        protected string ID, Creator, StaffID, Email, Description, Response, Status;
        public void StringOutput()
        {
            string Converted =
                "Ticket Number: " + ID + "\n" +
                "Ticket Creator: " + Creator + "\n" +
                "Staff ID: " + StaffID + "\n" +
                "Email Address: " + Email + "\n" +
                "Description: " + Description + "\n" +
                "Response: " + Response + "\n" +
                "Ticket Status: " + Status;
            Console.WriteLine(Converted);
        }
    }
    public class InternalTicket : Ticket
    {
        public InternalTicket(string Creator, string StaffID, string Email, string Description)
        {
            this.ID = CounterPlus();
            this.Creator = Creator;
            this.StaffID = StaffID;
            this.Email = Email;
            this.Description = Description;
            this.Status = "Open";
        }
    }
}