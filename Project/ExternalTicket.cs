using System;

namespace Project
{
    public class ExternalTicket : Ticket
    {
        public ExternalTicket(string Creator, string Email, string Description)
        {
            int IDInt = CounterPlus();
            this.ID = IDInt.ToString();
            this.Creator = Creator;
            this.Email = Email;
            this.Description = Description;
            this.Status = "Open";
        }
        public ExternalTicket(string Description)
        {
            int IDInt = CounterPlus();
            this.ID = IDInt.ToString();
            this.Creator = "Not specified";
            this.Email = "Not specified";
            this.Description = Description;
            this.Status = "Open";
        }
        public ExternalTicket(string Creator, string Email, string Description, string Response, string Status)
        {
            int IDInt = CounterPlus();
            this.ID = IDInt.ToString();
            this.Creator = Creator;
            this.Email = Email;
            this.Description = Description;
            this.Response = Response;
            this.Status = Status;
        }
        public override void Output()
        {
            Console.WriteLine(
                "Ticket Number: " + this.ID + "\n" +
                "Ticket Creator: " + this.Creator + "\n" +
                "Email Address: " + this.Email + "\n" +
                "Description: " + this.Description + "\n" +
                "Response: " + (this.Response ?? "Not Yet Provided") + "\n" +
                "Ticket Status: " + this.Status + "\n"
                );
        }
    }
}
