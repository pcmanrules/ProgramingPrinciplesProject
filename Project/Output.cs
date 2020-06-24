using System;

namespace Project
{
    class Output
    {
        public static void StringOutput(Ticket Ticket)
        {
            string Converted =
                "Ticket Number: " + Ticket.ID + "\n" +
                "Ticket Creator: " + (Ticket.Creator ?? "Not Yet Provided") + "\n" +
                "Staff ID: " + (Ticket.StaffID ?? "Not Yet Provided") + "\n" +
                "Email Address: " + (Ticket.Email ?? "Not Yet Provided") + "\n" +
                "Description: " + Ticket.Description + "\n" +
                "Response: " + (Ticket.Response ?? "Not Yet Provided") + "\n" +
                "Ticket Status: " + Ticket.Status + "\n";
            Console.WriteLine(Converted);
        }
    }
}