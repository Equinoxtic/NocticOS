using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class BuildHelp
    {
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

            for (int i = 0; i < 3; i++) {
                Console.Write("build " + BuildFlags[i] + BuildDescs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}