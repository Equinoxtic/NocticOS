using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class MathHelp
    {
        ThrowError throwError = new ThrowError();
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] MathCmdLs = {
                "-help",
                "-new",
                "-add",
                "-subtract",
                "-multiply",
                "-divide",
            };

            string[] MathDescs = {
                " - Shows help and information on the 'math' command.",
                " - Opens a built-in calculator.",
                " - Input and add two numbers.",
                " - Input and subtract two numbers.",
                " - Input and multiply two numbers.",
                " - Input and divide two numbers.",
            };

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            Console.Write("\n");

            for (int i = 0; i < 6; i++) {
                Console.Write("math " + MathCmdLs[i] + MathDescs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}