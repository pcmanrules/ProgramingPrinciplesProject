using System;

namespace Project
{
    public class ExternalTicket : Ticket
    {
        public ExternalTicket(string creator, string email, string description)
        {
            var idint = CounterPlus();
            Id = idint.ToString();
            Creator = creator;
            Email = email;
            Description = description;
            Status = "Open";
            TicketStats.Input(this);
        }

        public ExternalTicket(string description)
        {
            var idint = CounterPlus();
            Id = idint.ToString();
            Creator = "Not specified";
            Email = "Not specified";
            Description = description;
            Status = "Open";
            TicketStats.Input(this);
        }

        public ExternalTicket(string creator, string email, string description, string response, string status)
        {
            var idint = CounterPlus();
            Id = idint.ToString();
            Creator = creator;
            Email = email;
            Description = description;
            Response = response;
            Status = status;
            TicketStats.Input(this);
        }

        public override void Output()
        {
            Console.WriteLine(
                "Ticket Number: " + Id + "\n" +
                "Ticket Creator: " + Creator + "\n" +
                "Email Address: " + Email + "\n" +
                "Description: " + Description + "\n" +
                "Response: " + (Response ?? "Not Yet Provided") + "\n" +
                "Ticket Status: " + Status + "\n"
            );
        }
    }
}