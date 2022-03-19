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

        // Auto space lol. v
        public string curCursor = cursor + " ";
        public string curSelectCursor = selectCursor + " "; 
        // Auto space lol. ^

        string[] cursorTypeChoice = {
            "default",
            "selection"
        };

        public void CursorConfigPrompt() {
            string choice = "";
            Console.Write("\nCursor Configuration, please select a cursor type to configure.\n");
            for (int i = 0; i < cursorTypeChoice.Length; i++) {
                Console.Write(cursorTypeChoice[i] + "\n");
            }
            Console.Write("\n" + curSelectCursor);
            choice = Console.ReadLine();
            CursorConfig(choice);
        }

        void CursorConfig(string? configCursorChoice)
        {
            Program program = new Program();
            string cursorPrefix = "";
            string charParse = "";
            if (configCursorChoice == "selection" || configCursorChoice == "secondary") {
                cursorPrefix = "Selection ";
            }
            Console.Write("Input a character from your keyboard to be as your " + cursorPrefix.ToLower() +  "cursor: ");
            switch (configCursorChoice) {
                case "default" or "main":
                    cursor = Console.ReadLine();
                    charParse = cursor;
                    break;
                case "selection" or "secondary":
                    selectCursor = Console.ReadLine();
                    charParse = selectCursor;
                    break;
            }
            if (!String.IsNullOrEmpty(charParse)) {
                Console.Write(
                    "\n" + cursorPrefix + "Cursor has been successfully configured.\nCharacter: " + charParse + "\n"
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
            program.DoReturn(false);
        }
    }
}