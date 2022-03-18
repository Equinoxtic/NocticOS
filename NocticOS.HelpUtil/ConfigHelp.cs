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
            "-bg - Background Color configuration.",
            "-fg - Foreground Color configuration.",
            "-cursor - Cursor configuration."
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