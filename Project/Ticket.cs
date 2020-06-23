using System;

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
    public class InternalTicket : Ticket
    {
        public InternalTicket(string Creator, string StaffID, string Email, string Description)
        {
            int IDInt = CounterPlus();
            int v = IDInt + 2000;
            this.ID = v.ToString();
            this.Creator = Creator;
            this.StaffID = StaffID;
            this.Email = Email;
            this.Description = Description;
            this.Status = "Open";
        }
        public InternalTicket(string StaffID, string Description)
        {
            int IDInt = CounterPlus();
            int v = IDInt + 2000;
            this.ID = v.ToString();
            this.Creator = "Not Specified";
            this.StaffID = StaffID;
            this.Email = "Not Specified";
            this.Description = Description;
            this.Status = "Open";
        }
        public InternalTicket(string Creator, string StaffID, string Email, string Description, string Response, string Status)
        {
            int IDInt = CounterPlus();
            int v = IDInt + 2000;
            this.ID = v.ToString();
            this.Creator = Creator;
            this.StaffID = StaffID;
            this.Email = Email;
            this.Description = Description;
            this.Response = Response;
            this.Status = Status;
        }
    }
    class Output
    {
        public static void StringOutput(Ticket Ticket)
        {
            string Converted =
                "Ticket Number: " + Ticket.ID + "\n" +
                "Ticket Creator: " + Ticket.Creator + "\n" +
                "Staff ID: " + Ticket.StaffID + "\n" +
                "Email Address: " + Ticket.Email + "\n" +
                "Description: " + Ticket.Description + "\n" +
                "Response: " + (Ticket.Response ?? "Not Yet Provided") + "\n" +
                "Ticket Status: " + Ticket.Status + "\n";
            Console.WriteLine(Converted);
        }
    }
}