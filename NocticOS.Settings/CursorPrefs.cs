using System;
using System.Linq;
using System.Threading.Tasks;
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
            switch (configCursorChoice)
            {
                case "default" or "main":
                    Console.Write("Input a character from your keyboard to be as your cursor: ");
                    cursor = Console.ReadLine();
                    if (String.IsNullOrEmpty(cursor)) {
                        Throw emptyThrow = new Throw();
                        emptyThrow.CreateThrow(false, "et", "FAILED: Empty Value.", true);
                    } else {
                        Console.Write("\nCursor has been successfully configured.\n");
                    }
                break;

                case "selection" or "secondary":
                    Console.Write("Input a character from your keyboard to be as your selection cursor: ");
                    selectCursor = Console.ReadLine();
                    if (String.IsNullOrEmpty(selectCursor)) {
                        Throw emptyThrow = new Throw();
                        emptyThrow.CreateThrow(false, "et", "FAILED: Empty Value.", true);
                    } else {
                        Console.Write("\nSelection Cursor has been successfully configured.\n");
                    }
                break;
            }
            curCursor = cursor;
            curSelectCursor = selectCursor;
            program.DoReturn(false);
        }
    }
}