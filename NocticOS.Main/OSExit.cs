using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Main
{
    public class OSExit
    {
        public void Exit(bool shouldClearScreen) {
            ClearScreen clearScreen = new ClearScreen();
            Console.Write("\nExiting...\n");
            Thread.Sleep(3000);
            if (shouldClearScreen) {
                clearScreen.ScreenClear(false);
            }
        }
    }
}