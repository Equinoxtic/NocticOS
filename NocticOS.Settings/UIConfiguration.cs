using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Settings
{
    public class UIConfiguration
    {
        public bool showTimeAndDate = false;
        public bool showDotnetVersion = false;
        public bool showOSVersion = false;
        string[] configList = {
            "[1] - Show Time and Date",
            "[2] - Show .NET Version",
            "[3] - Show OS Version"
        };

        public void ConfigPrompt() {
            Program program = new Program();
            string? choice = "";
            for (int i = 0; i < configList.Length; i++) {
                Console.Write(configList[i] + "\n");
            }
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValueThrow = new Throw();
                emptyValueThrow.CreateThrow(
                    false,
                    "ev",
                    "Emtpy value, please try again",
                    true
                );
                program.DoReturn(false);
            } else {
                
            }
        }
    }
}