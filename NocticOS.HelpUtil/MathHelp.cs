using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class MathHelp
    {
        // ThrowError throwError = new ThrowError();
        Throw missingParams = new Throw();

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
            Program program = new Program();

            if (isMissingParams) {
                // throwError.MissingParamsThrow(true);
                missingParams.CreateThrow(false,
                    "mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            }

            Console.Write("\n");

            for (int i = 0; i < mathCmdLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("math " + mathCmdLs[i] + "\n");
                } else { 
                    Console.Write(mathCmdLs[i] + "\n");
                }
            }

            program.DoReturn(false);
        }
    }
}