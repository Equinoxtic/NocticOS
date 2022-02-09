using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.HelpUtil
{
    public class BuildHelp
    {
        ThrowError throwError = new ThrowError();
        public void OpenHelp(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] BuildFlags = {
                "-dirs",
                "-os",
                "-de"
            };

            string[] BuildDescs = {
                " - Builds the standard NocticOS directories.",
                " - (WIP) Builds NocticOS' system files (package managers and etc).",
                " - (WIP) Builds NocticOS' Desktop Enviroment (Desktop UI)."
            };

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            for (int i = 0; i < 3; i++) {
                if (isMissingParams) {
                    Console.Write("build " + BuildFlags[i] + BuildDescs[i] + "\n");
                } else {
                    Console.Write(BuildFlags[i] + BuildDescs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}