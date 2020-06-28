using System;

namespace Project
{
    internal class PasswordGenerator
    {
        public static string Invoke(string ID, string StaffID)
        {
            Console.Clear();
            int a = StaffID[0];
            int b = StaffID[1];
            string c = Convert.ToString((int.Parse(ID) - 2000), 2);
            string password = ("" + a + b + c + StaffID[2] + StaffID[3]);
            return password;
        }
    }
}