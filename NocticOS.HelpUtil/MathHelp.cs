using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class MathHelp
    {
        ThrowError throwError = new ThrowError();

        string[] mathCmdLs = {
            "-help - Shows help and information on the 'math' command.",
            "-new - Opens a built-in calculator.",
            "-add - Input and add two numbers.",
            "-subtract - Input and subtract two numbers.",
            "-multiply - Input and multiply two numbers.",
            "-divide - Input and divide two numbers.",
        };

        /*
        string[] MathDescs = {
            " - Shows help and information on the 'math' command.",
            " - Opens a built-in calculator.",
            " - Input and add two numbers.",
            " - Input and subtract two numbers.",
            " - Input and multiply two numbers.",
            " - Input and divide two numbers.",
        };
        */

        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            Console.Write("\n");

            for (int i = 0; i < mathCmdLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("math " + mathCmdLs[i] + "\n");
                } else { 
                    Console.Write(mathCmdLs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}