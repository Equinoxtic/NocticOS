using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class InputHelp
    {
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] InputCmdLs = {
                "-help",
                "-str",
                "-int",
                "-dbl"
            };

            string[] InputCmdDescs = {
                " - Shows help and information for the 'input' command.",
                " - Standard string input.",
                " - Standard integer input.",
                " - Standard double input."
            };

            if (isMissingParams) {
                Console.Write("\nMissing parameters, please enter the following:\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 4; i++) {
                Console.Write(InputCmdLs[i] + InputCmdDescs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}