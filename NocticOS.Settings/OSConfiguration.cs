using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Settings
{
    public class OSConfiguration
    {
        Options choices = new Options();
        ConsoleProperties consoleProperties = new ConsoleProperties();
        SystemProperties systemProperties = new SystemProperties();

        static string choice = "";
        static string[] choiceArray = {
            "-bg",
            "-fg"
        };
        static string[] choiceDescs = {
            "Background Configuration",
            "Foreground Configuration"
        };

        public void Open(bool isList)
        {
            Console.Write("\nSelect configuration:\n");
            choice = Console.ReadLine();
            if (isList) {
                choices.PushOptions(choiceArray, choiceArray.Length, "config");
            } else {
                for (int i = 0; i < choiceArray.Length; i++) {
                    Console.Write("[" + choiceArray[i] + "]" + " - " + choiceDescs + "\n");
                }
            }
        }
        
        public void SwitchConfigState(string choice)
        {
            switch (choice)
            {
                case "config -bg" or "-bg" : BGorFGconfig("bg"); break;
                case "config -fg" or "-fg" : BGorFGconfig("fg"); break;
            }
        }

        static string[] colorChoices = {
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

        static void BGorFGconfig(string type) {
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
            Console.Write(kw + " color configuration, input your desired color.\n");
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
        }
    }
}