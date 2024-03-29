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
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            DrawLine();

            DrawSpace();

            DrawLine();
        }

        public static void DrawLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 20; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawSpace()
        {
            for (int lines = 0; lines <= 3; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 1);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("0 - Sair");
            
            Console.SetCursorPosition(3, 3);
            Console.Write("Op��o: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show();
                    break;
                case 2: Console.WriteLine("View");
                    break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();
                    break;
            }
        }
    }
}