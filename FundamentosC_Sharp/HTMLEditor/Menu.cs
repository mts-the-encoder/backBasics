using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
        }

        public static void DrawScreen()
        {
            DrawLine();

            DrawSpace();

            DrawLine();
        }

        static void DrawLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        static void DrawSpace()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}