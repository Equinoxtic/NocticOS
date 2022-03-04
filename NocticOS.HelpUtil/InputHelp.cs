using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class InputHelp
    {
        // ThrowError throwError = new ThrowError();
        Throw missingParams = new Throw();

        string[] InputCmdLs = {
            "-help - Shows help and information for the 'input' command.",
            "-sel - Select what type you should input.",
            "-str - Standard string input.",
            "-int - Standard float input.",
            "-flt - Standard float input.",
            "-dbl - Standard double input."
        };

        /*
        string[] InputCmdDescs = {
            " - Shows help and information for the 'input' command.",
            " - Select what type you should input.",
            " - Standard string input.",
            " - Standard integer input.",
            " - Standard float input.",
            " - Standard double input."
        };
        */
        
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            if (isMissingParams) {
                // throwError.MissingParamsThrow(true);
                missingParams.CreateThrow("mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            }

            Console.Write("\n");

            for (int i = 0; i < InputCmdLs.Length; i++) {
                Console.Write("input " + InputCmdLs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}