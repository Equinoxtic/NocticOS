using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Settings
{
    public class OSConfiguration
    {
        Options choices = new Options();
        
        static string? cursor = "";
        static string? selectCursor = "";

        // Auto space lol. v
        public string curCursor = cursor + " ";
        public string curSelectCursor = selectCursor + " "; 
        // Auto space lol. ^

        string? choice = "";
        
        string[] choiceArray = {
            "bg",
            "fg",
            "cursor"
        };
        string[] choiceDescs = {
            "Background Configuration",
            "Foreground Configuration",
            "Cursor Configuration"
        };

        public void Open(bool isList)
        {
            Console.Write("\nSelect configuration:\n");
            if (isList) {
                choices.PushOptions(choiceArray, choiceArray.Length, "config");
            } else {
                for (int i = 0; i < choiceArray.Length; i++) {
                    Console.Write("[" + choiceArray[i] + "]" + " - " + choiceDescs[i] + "\n");
                }
            }
            Console.Write("\n" + curSelectCursor);
            choice = Console.ReadLine();
            SwitchConfigState(choice);
        }
        
        public void SwitchConfigState(string? choice)
        {
            switch (choice)
            {
                case "config -bg" or "-bg" : BGorFGconfig("bg"); break;
                case "config -fg" or "-fg" : BGorFGconfig("fg"); break;
                case "config -cursor" or "-cursor" : CursorConfigPrompt(); break;
            }
        }

        string[] colorChoices = {
            "Black",
            "Dark Blue",
            "Dark Green",
            "Dark Cyan",
            "Dark Red",
            "Dark Magenta",
            "Dark Yellow",
            "Gray",
            "Dark Gray",
            "Blue",
            "Green",
            "Cyan",
            "Red",
            "Magenta",
            "Yellow",
            "White"
        };

        void BGorFGconfig(string type) {
            Program program = new Program();
            BackgroundSwitch bgSwitch = new BackgroundSwitch();
            ForegroundSwitch fgSwitch = new ForegroundSwitch();
            string kw = "";
            int choice = 0;
            switch (type) {
                case "bg":
                    kw = "Background";
                    break;
                case "fg":
                    kw = "Foreground";
                    break;
            }
            Console.Write("\n" + kw + " color configuration, input your desired color.\n");
            for (int i = 0; i < colorChoices.Length; i++) {
                Console.Write("[" + i + "]" + " - " + colorChoices[i] + "\n");
            }
            choice = Convert.ToInt32(Console.ReadLine());
            switch (kw)
            {
                case "Background":
                    bgSwitch.BGSwitch(choice);
                break;

                case "Foreground":
                    fgSwitch.FGSwitch(choice);
                break;
            }
            program.DoReturn(false);
        }

        string[] cursorTypeChoice = {
            "default",
            "selection"
        };

        void CursorConfigPrompt() {
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