using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;
using NocticOS.Settings;

namespace NocticOS.Settings
{
    public class TimeConfiguration
    {
        static bool showSeconds = false;
        static bool showMinutes = false;
        static bool showHour = false;
        static bool[] showList = {
            showSeconds,
            showMinutes,
            showHour
        };
        static bool isAll = true;
        public bool secondsShowing = showSeconds;
        public bool minutesShowing = showMinutes;
        public bool hoursShowing = showHour;
        public bool showingAll = isAll;
        string[] timeConfigList = {
            "[secs] - Show seconds?",
            "[mins] - Show minutes?",
            "[hrs] - Show hours?",
            "[all] - Show all?",
            "[back] - Go back"
        };

        public void TimeConfigPrompt() {
            Program program = new Program();
            Options timeConfigOptions = new Options();
            CursorPrefs cursorPrefs = new CursorPrefs();
            string? choice = "";
            timeConfigOptions.PushOptions(timeConfigList, timeConfigList.Length);
            Console.Write("\n" + cursorPrefs.curSelectCursor);
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value, please try again.",
                    true
                );
                program.DoReturn(false);
            } else {
                SwitchTimeConfigState(choice);
            }
        }

        public void SwitchTimeConfigState(string currentState) {
            string prefix = "";
            switch(currentState) {
                case "secs" or "seconds":
                    prefix = "secs";
                    break;
                case "mins" or "minutes":
                    prefix = "mins";
                    break;
                case "hrs" or "hours":
                    prefix = "hrs";
                    break;
                case "all":
                    prefix = "all";
                    break;
                case "back":
                    prefix = "back";
                    break;
            }
            TimeConfigState(prefix);
        }

        void TimeConfigState(string curState)
        {
            Program program = new Program();
            string statePrefix = "";
            string? choice = "";
            bool isConfig = true;
            switch(curState) {
                case "secs":
                    statePrefix = "Seconds";
                    break;
                case "mins":
                    statePrefix = "Minutes";
                    break;
                case "hrs":
                    statePrefix = "Hours";
                    break;
                /* case "all":
                    statePrefix = "";
                    break; */
                case "back":
                    isConfig = false;
                    break;
            }
            if (isConfig)
            {
                if (curState != "all") {
                    Console.Write("\nConfiguring whether or not the " + statePrefix.ToLower() + " should appear.\nWould like for " + statePrefix + " to appear? [Y/N]: ");
                } else {
                    Console.Write("Configuring whether or not to show the time.\nWould you like for the time to appear? [Y/N]: ");
                }
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) {
                    Throw emptyValue = new Throw();
                    emptyValue.CreateThrow(
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
                                case "secs":
                                    isAll = false;
                                    showSeconds = true;
                                    break;
                                case "mins":
                                    isAll = false;
                                    showMinutes = true;
                                    break;
                                case "hrs":
                                    isAll = false;
                                    showHour = true;
                                    break;
                                case "all":
                                    isAll = true;
                                    break;
                            }
                        break;

                        case "N" or "n":
                            switch (curState) {
                                case "secs":
                                    showSeconds = false;
                                    break;
                                case "mins":
                                    showMinutes = false;
                                    break;
                                case "hrs":
                                    showHour = false;
                                    break;
                                case "all":
                                    isAll = false;
                                    break;
                            }
                        break;
                    }
                    /* if (showSeconds || showMinutes || showHour) {
                        isAll = false;
                    } */
                    if (isAll) {
                        for (int i = 0; i < showList.Length; i++) {
                            showList[i] = false;
                        }
                        isAll = true;
                    }
                }
            }
            else
            {
                Console.Write("Would you like to exit this operation? [Y/N]: ");
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) {
                    Throw emptyValue = new Throw();
                    emptyValue.CreateThrow(
                        false,
                        "ev",
                        "Empty value, please try again.",
                        true
                    );
                    TimeConfigPrompt();
                } else {
                    switch(choice) {
                        case "Y" or "y":
                            program.DoReturn(false);
                            break;
                        case "N" or "n":
                            TimeConfigPrompt();
                            break;
                    }
                }
            }
            program.DoReturn(false);
        }
    }
}