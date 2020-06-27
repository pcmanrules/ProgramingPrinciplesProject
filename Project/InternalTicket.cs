namespace Project
{
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
            if (Description.Contains("Password Change") == true)
            {
                this.Response = ("New password generated: " + PasswordGenerator.Invoke(this.ID, this.StaffID));
                this.Status = "Closed";
            }
            else this.Status = "Open";

        }
        public InternalTicket(string StaffID, string Description)
        {
            int IDInt = CounterPlus();
            int v = IDInt + 2000;
            this.ID = v.ToString();
            this.StaffID = StaffID;
            this.Description = Description;
            if (Description.Contains("Password Change") == true)
            {
                this.Response = ("New password generated: " + PasswordGenerator.Invoke(this.ID, this.StaffID));
                this.Status = "Closed";
            }
            else this.Status = "Open";
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
}