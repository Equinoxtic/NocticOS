using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Settings
{
    public class ConsolePrefs
    {
        public static string currentCursorChar = "";
        public static string currentConsoleFG = "";
        public static string currentConsoleBG = "";
    }

    public class DebugPrefs
    {
        public void SetDebugProperty(string dbgLevel, bool allowDebug)
        {
            if (allowDebug) {
                switch(dbgLevel) {
                    case "guest-debug":
                        dbgLevel = "guest";
                        break;

                    case "debug":
                        dbgLevel = "debug";
                        break;

                    case "debug-admin":
                        dbgLevel = "admin";
                        break;
                }
            } else {
                dbgLevel = "none";
            }
        }
    }
}