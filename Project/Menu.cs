﻿using System;

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
                          "║ 2: External Ticket Generate                  ║\n" +
                          "║                                              ║\n" +
                          "║ 0: List all tickets                          ║\n" +
                          "║                                              ║\n" +
                          "║ Esc: Exit                                    ║\n" +
                          "╚══════════════════════════════════════════════╝\n" +
                          "Option: ");
        }
    }
}
