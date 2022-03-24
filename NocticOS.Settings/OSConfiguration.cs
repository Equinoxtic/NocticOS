using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Settings
{
    public class OSConfiguration
    {
        Options choices = new Options();
        CursorPrefs cursorPrefs = new CursorPrefs();

        string? choice = "";
        
        string[] choiceArray = {
            "bg",
            "fg",
            "cursor",
            "interface"
        };
        string[] choiceDescs = {
            "Background Configuration",
            "Foreground Configuration",
            "Cursor Configuration",
            "Interface Configuration"
        };

        public void Open()
        {
            Program program = new Program();
            Console.Write("\nSelect configuration:\n");
            /* if (isList) {
                choices.PushOptions(choiceArray, choiceArray.Length, true, "config");
            } */
            for (int i = 0; i < choiceArray.Length; i++) {
                Console.Write("[" + choiceArray[i] + "]" + " - " + choiceDescs[i] + "\n");
            }
            Console.Write("\n" + cursorPrefs.curSelectCursor);
            choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice)) {
                Throw emptyValue = new Throw();
                emptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    false
                );
                program.DoReturn(false);
            } else {
                SwitchConfigState(choice);
            }
        }
        
        public void SwitchConfigState(string? choice)
        {
            switch (choice)
            {
                case "config -bg" or "bg" : BGorFGconfig("bg"); break;
                case "config -fg" or "fg" : BGorFGconfig("fg"); break;
                case "config -cursor" or "cursor" : cursorPrefs.CursorConfigPrompt(); break;
            }
        }

        string[] colorChoices = {
            "[0] - Black",
            "[1] - Dark Blue",
            "[2] - Dark Green",
            "[3] - Dark Cyan",
            "[4] - Dark Red",
            "[5] - Dark Magenta",
            "[6] - Dark Yellow",
            "[7] - Gray",
            "[8] - Dark Gray",
            "[9] - Blue",
            "[10] - Green",
            "[11] - Cyan",
            "[12] - Red",
            "[13] - Magenta",
            "[14] - Yellow",
            "[15] - White"
        };

        void BGorFGconfig(string type) {
            Program program = new Program();
            Options colorOptions = new Options();
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
            colorOptions.PushOptions(colorChoices, colorChoices.Length);
            Console.Write(cursorPrefs.curSelectCursor);
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
    }
}