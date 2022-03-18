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
            }
        }
    }
}