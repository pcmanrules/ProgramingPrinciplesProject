using System;

namespace Project
{
    internal class Menu
    {
        public static void ShowMain()
        {
            Console.Clear();
            Console.Write("╔══════════════════════════════════════════════╗\n" +
                          "║ Ticket System                                ║\n" +
                          "╠══════════════════════════════════════════════╣\n" +
                          "║ 1: Internal Ticket Generate                  ║\n" +
                          "║ 2: External Ticket Generate                  ║\n" +
                          "║ 3: List all Tickets                          ║\n" +
                          "║ 4: Display Ticket Statistics                 ║\n" +
                          "║                                              ║\n" +
                          "║ Esc: Exit                                    ║\n" +
                          "╚══════════════════════════════════════════════╝\n" +
                          "Option: ");
        }
    }
}