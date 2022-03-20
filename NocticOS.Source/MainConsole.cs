using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Settings;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class MainConsole
    {
        static string mainPath = "Home";
        static string choice = "";
        ConsoleCommandSwitch consoleCommandSwitch = new ConsoleCommandSwitch();
        CursorPrefs prefs = new CursorPrefs();
        public void OpenConsole()
        {
            Console.Write("\n" + mainPath + prefs.curCursor);
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value, please try again.",
                    true
                );
            } else {
                consoleCommandSwitch.DoSwitch(choice);
            }
        }
    }
}