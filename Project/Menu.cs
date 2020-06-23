using System;

namespace Project
{
    class Menu
    {
        public static void ShowMain()
        {
            Console.Clear();
            Console.Write("╔══════════════════════════════════════════════╗\n" +
                          "║ Ticket System                                ║\n" +
                          "╠══════════════════════════════════════════════╣\n" +
                          "║ 1: Internal Ticket Generate                  ║\n" +
                          "║ 2: List all tickets                          ║\n" +
                          "║ Esc: Exit                                    ║\n" +
                          "╚══════════════════════════════════════════════╝\n" +
                          "Option: ");
        }
    }
}
