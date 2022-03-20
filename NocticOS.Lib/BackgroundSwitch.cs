using System;

namespace NocticOS.Lib
{
    public class BackgroundSwitch
    {
        public void BGSwitch(int choice)
        {
            switch(choice)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Black;
                break;

                case 1:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                break;

                case 4:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                break;

                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                break;

                case 6:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                break;

                case 7:
                    Console.BackgroundColor = ConsoleColor.Gray;
                break;

                case 8:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                break;

                case 9:
                    Console.BackgroundColor = ConsoleColor.Blue;
                break;

                case 10:
                    Console.BackgroundColor = ConsoleColor.Green;
                break;

                case 11:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                break;

                case 12:
                    Console.BackgroundColor = ConsoleColor.Red;
                break;

                case 13:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                break;

                case 14:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                break;

                case 15:
                    Console.BackgroundColor = ConsoleColor.White;
                break;
            }
        }
    }
}