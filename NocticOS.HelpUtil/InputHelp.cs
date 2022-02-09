using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class InputHelp
    {
        ThrowError throwError = new ThrowError();
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] InputCmdLs = {
                "-help",
                "-str",
                "-int",
                "-flt",
                "-dbl"
            };

            string[] InputCmdDescs = {
                " - Shows help and information for the 'input' command.",
                " - Standard string input.",
                " - Standard integer input.",
                " - Standard float input.",
                " - Standard double input."
            };

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            Console.Write("\n");

            for (int i = 0; i < 5; i++) {
                Console.Write("input " + InputCmdLs[i] + InputCmdDescs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}