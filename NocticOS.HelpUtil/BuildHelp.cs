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

            string[] BuildLs = {
                "-dirs - Builds the standard NocticOS directories.",
                "-os - (WIP) Builds NocticOS' system files (package managers and etc).",
                "-de - (WIP) Builds NocticOS' Desktop Enviroment (Desktop UI)."
            };

            if (isMissingParams) {
                throwError.MissingParamsThrow(true);
            }

            for (int i = 0; i < BuildLs.Length; i++) {
                if (isMissingParams) {
                    Console.Write("build " + BuildLs[i] + "\n");
                } else {
                    Console.Write(BuildLs[i] + "\n");
                }
            }

            Program.DoReturn(false);
        }
    }
}