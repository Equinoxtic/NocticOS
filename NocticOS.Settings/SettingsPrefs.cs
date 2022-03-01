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
        public void SetDebugProperty(string funcTag, string dbgLevel, bool allowDebug)
        {
            if (allowDebug && !String.IsNullOrEmpty(funcTag)) {
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

    public class SystemPrefs
    {
        public static string currentSystem = "";
        public static string currentSystemKey = "";
        public static string currentSystemVersion = "";

        public void GetVersion(string sysname, string sysversion, string syskey)
        {
            string[] versionls = {
                sysname,
                sysversion,
                syskey
            };
            
            for (int i = 0; i < versionls.Length; i++) {
                Console.Write(versionls[i] + "\n");
            }
        }
    }
}