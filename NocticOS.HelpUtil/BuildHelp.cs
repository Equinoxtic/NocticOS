using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.HelpUtil
{
    public class BuildHelp
    {
        // ThrowError throwError = new ThrowError();
        Options buildOptions = new Options();
        Throw missingParams = new Throw();

        string[] buildLs = {
            "-dirs - Builds the standard NocticOS directories.",
            "-os - (WIP) Builds NocticOS' system files (package managers and etc).",
            "-de - (WIP) Builds NocticOS' Desktop Enviroment (Desktop UI)."
        };

        /*
        string[] BuildDescs = {
            " - Builds the standard NocticOS directories.",
            " - (WIP) Builds NocticOS' system files (package managers and etc).",
            " - (WIP) Builds NocticOS' Desktop Enviroment (Desktop UI)."
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

            for (int i = 0; i < buildLs.Length; i++) {
                if (isMissingParams) {
                    buildOptions.PushOptions("build", buildLs, buildLs.Length);
                } else {
                    Console.Write(buildLs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}