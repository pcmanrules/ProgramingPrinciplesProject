using System;

namespace Project
{
    internal class PasswordGenerator
    {
        public static string Invoke(string id, string staffid)
        {
            Console.Clear();
            int a = staffid[0];
            int b = staffid[1];
            var c = Convert.ToString(int.Parse(id) - 2000, 2);
            var password = "" + a + b + c + staffid[2] + staffid[3];
            return password;
        }
    }
}