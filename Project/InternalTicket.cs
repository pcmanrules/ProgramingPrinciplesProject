using System;

namespace Project
{
    public class InternalTicket : Ticket
    {
        public InternalTicket(string creator, string staffid, string email, string description)
        {
            var idint = CounterPlus();
            var v = idint + 2000;
            Id = v.ToString();
            Creator = creator;
            StaffId = staffid;
            Email = email;
            Description = description;
            if (Description.Contains("Password Change"))
            {
                Response = "New password generated: " + PasswordGenerator.Invoke(Id, StaffId);
                Status = "Closed";
            }
            else
            {
                Status = "Open";
            }

            TicketStats.Input(this);
        }

        public InternalTicket(string staffid, string description)
        {
            var idint = CounterPlus();
            var v = idint + 2000;
            Id = v.ToString();
            Creator = "Not Specified";
            StaffId = staffid;
            Email = "Not Specified";
            Description = description;
            if (Description.Contains("Password Change"))
            {
                Response = "New password generated: " + PasswordGenerator.Invoke(Id, StaffId);
                Status = "Closed";
            }
            else
            {
                Status = "Open";
            }

            TicketStats.Input(this);
        }

        public InternalTicket(string creator, string staffid, string email, string description, string response,
            string status)
        {
            var idint = CounterPlus();
            var v = idint + 2000;
            Id = v.ToString();
            Creator = creator;
            StaffId = staffid;
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
                "Staff Id: " + StaffId + "\n" +
                "Email Address: " + Email + "\n" +
                "Description: " + Description + "\n" +
                "Response: " + (Response ?? "Not Yet Provided") + "\n" +
                "Ticket Status: " + Status + "\n"
            );
        }
    }
}