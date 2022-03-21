using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class ConfigHelp
    {
        Throw missingParamsThrow = new Throw();

        string[] configHelpLs = {
            "-help - Shows help and information for the 'config' command.",
            "-sel - Prompts you to what property you want to configure.",
            "-bg - Background Color configuration.",
            "-fg - Foreground Color configuration.",
            "-cursor - Cursor configuration.",
            "-interface - Interface configuration."
        };

        public void OpenHelp(bool isMissingParams)
        {
            Program program = new Program();

            if (isMissingParams) {
                missingParamsThrow.CreateThrow(
                    false,
                    "mp",
                    "Missing parameters, please enter the following:",
                    true
                );
            }

            Console.Write("\n");

            for (int i = 0; i < configHelpLs.Length; i++) {
                Console.Write("config " + configHelpLs[i] + "\n");
            }

            program.DoReturn(false);
        }
    }
}