using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;
using NocticOS.Settings;

namespace NocticOS.Settings
{
    public class UIConfiguration
    {
        static bool timeAllowed = false;
        static bool dotnetVersionShowing = false;
        static bool osVersionShowing = true;
        public bool showTime = timeAllowed;
        public bool showDotnetVersion = dotnetVersionShowing;
        public bool showOSVersion = osVersionShowing;
        string[] configList = {
            "[time] - Show Time",
            "[dnver] - Show .NET Version",
            "[osver] - Show OS Version",
            "[back] - Go Back"
        };

        public void ConfigPrompt() {
            Program program = new Program();
            Options configOptions = new Options();
            CursorPrefs cursorPrefs = new CursorPrefs();
            string? choice = "";
            configOptions.PushOptions(configList, configList.Length);
            Console.Write("\n" + cursorPrefs.curSelectCursor);
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
                SwitchConfigState(choice);
            }
        }

        public void SwitchConfigState(string state) {
            string prefix = "";
            switch(state) {
                case "show-time" or "time":
                    prefix = "show-time";
                    break;
                case "show-dotnet-version" or "dnver":
                    prefix = "show-dotnet-version";
                    break;
                case "show-os-version" or "osver":
                    prefix = "show-os-version";
                    break;
                case "back":
                    prefix = "back";
                    break;
            }
            ConfigState(prefix);
        }

        void ConfigState(string curState) {
            Program program = new Program();
            string statePrefix = "";
            string? choice = "";
            bool isConfig = true;
            switch(curState) {
                case "show-time":
                    statePrefix = "Show Time";
                    break;
                case "show-dotnet-version":
                    statePrefix = "Show .NET Version";
                    break;
                case "show-os-version":
                    statePrefix = "Show OS Version";
                    break;
                case "back":
                    isConfig = false;
                    break;
            }
            if (isConfig) {
                Console.Write("\nConfiguring: " + statePrefix + "\nEnable this? [Y/N]: ");
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) {
                    Throw emtpyValueThrow = new Throw();
                    emtpyValueThrow.CreateThrow(
                        false,
                        "ev",
                        "Empty value, please try again.",
                        true
                    );
                    program.DoReturn(false);
                } else {
                    switch(choice) {
                        case "Y" or "y":
                            switch(curState) {
                                case "show-time":
                                    timeAllowed = true;
                                    break;
                                case "show-dotnet-version":
                                    dotnetVersionShowing = true;
                                    break;
                                case "show-os-version":
                                    osVersionShowing = true;
                                    break;
                            }
                        break;

                        case "N" or "n":
                            switch(curState) {
                                case "show-time":
                                    timeAllowed = false;
                                    break;
                                case "show-dotnet-version":
                                    dotnetVersionShowing = false;
                                    break;
                                case "show-os-version":
                                    osVersionShowing = false;
                                    break;
                            }
                        break;
                    }
                }
            } else {
                Console.Write("\nDo you want to cancel this operation? [Y/N]: ");
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) {
                    Throw emptyValueThrow = new Throw();
                    emptyValueThrow.CreateThrow(
                        false,
                        "ev",
                        "Empty value, please try again.",
                        true
                    );
                    program.DoReturn(false);
                } else {
                    switch(choice) {
                        case "Y" or "y":
                            program.DoReturn(false);
                            break;
                        case "N" or "n":
                            ConfigPrompt();
                            break;
                    }
                }
            }
            program.DoReturn(false);
        }
    }
}