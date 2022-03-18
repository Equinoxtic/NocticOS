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
            }
        }
    }
}