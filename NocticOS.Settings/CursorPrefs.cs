using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using NocticOS.Lib;

namespace NocticOS.Settings
{
    public class CursorPrefs
    {
        static string? cursor = "";
        static string? selectCursor = "";
        static string? secretCursor = "";

        // Auto space lol. v
        public string curCursor = cursor + " ";
        public string curSelectCursor = selectCursor + " "; 
        public string curSecretCursor = secretCursor + " ";
        // Auto space lol. ^

        string[] cursorTypeChoice = {
            "default",
            "selection",
            "back"
        };

        public void SwitchCursorConfig(string? cursorChoice)
        {
            switch(cursorChoice) {
                case "default":
                    CursorConfig("default");
                    break;
                case "selection":
                    CursorConfig("selection");
                    break;

                case "secret":
                    CursorConfig("secret");
                    break;
            }
        }

        public void CursorConfigPrompt() {
            Program program = new Program();
            Options cursorOptions = new Options();
            string choice = "";
            Console.Write("\nCursor Configuration, please select a cursor type to configure.\n");
            cursorOptions.PushOptions(cursorTypeChoice, cursorTypeChoice.Length);
            Console.Write("\n" + curSelectCursor);
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    true
                );
                program.DoReturn(false);
            } else {
                CursorConfig(choice);
            }
        }

        void CursorConfig(string? configCursorChoice)
        {
            Program program = new Program();
            string cursorPrefix = "";
            string charParse = "";
            bool isConfig = false;
            if (configCursorChoice != "back") {
                isConfig = true;
                if (isConfig) {
                    switch (configCursorChoice) {
                        case "default" or "main":
                            cursorPrefix = "Default";
                            break;
                        case "selection" or "secondary":
                            cursorPrefix = "Selection";
                            break;
                        case "secret":
                            cursorPrefix = "Secret";
                            break;
                    }
                    Console.Write("Input character(s) from your keyboard to be as your " + cursorPrefix.ToLower() +  " cursor: ");
                }
            } else {
                Console.Write("\nAre you sure you want to exit out of this operation? [Y/N]: ");
            }
            switch (configCursorChoice) {
                case "default" or "main":
                    cursor = Console.ReadLine();
                    charParse = cursor;
                    break;
                case "selection" or "secondary":
                    selectCursor = Console.ReadLine();
                    charParse = selectCursor;
                    break;
                case "secret":
                    secretCursor = Console.ReadLine();
                    charParse = secretCursor;
                    break;
                case "back" or "exit":
                    ExitPrompt();
                    break;
            }
            if (!String.IsNullOrEmpty(charParse)) {
                Console.Write(
                    "\n" + cursorPrefix + "Cursor has been successfully configured.\n" + cursorPrefix + " Cursor Character: " + charParse + "\n"
                );
            } else {
                Throw emptyThrow = new Throw();
                emptyThrow.CreateThrow(
                    false, 
                    "et", 
                    "FAILED: Empty Value.", 
                    true
                );
            }
            curCursor = cursor;
            curSelectCursor = selectCursor;
            curSecretCursor = secretCursor;
            program.DoReturn(false);
        }

        void ExitPrompt()
        {
            Program program = new Program();
            string? choice = "";
            choice = Console.ReadLine();
            switch(choice) {
                case "Y" or "y":
                    Console.Write("\nExiting...\n");
                    Thread.Sleep(1000);
                    program.DoReturn(false);
                    break;
                case "N" or "n":
                    CursorConfigPrompt();
                    break;
            }
        }
    }
}