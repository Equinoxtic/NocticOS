using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class InputHelp
    {
        public void InputHelpState(bool isMissingParams)
        {
            ProgramReturn Program = new ProgramReturn();

            string[] InputCmdLs = {
                "-help",
                "-str",
                "-int",
                "-dbl"
            };

            string[] InputCmdDescs = {};

            if (isMissingParams) {
                Console.Write("\nMissing parameters, please enter the following:\n");
            }

            for (int i = 0; i < null; i++) {

            }

            Program.DoReturn(false);
        }
    }
}