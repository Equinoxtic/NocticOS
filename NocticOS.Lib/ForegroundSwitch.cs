using System;

namespace NocticOS.Lib
{
    public class ForegroundSwitch
    {
        public void FGSwitch(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Black;
                break;

                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                break;

                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                break;
            }
        }
    }
}