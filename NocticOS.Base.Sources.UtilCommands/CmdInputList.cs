using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdInputList
    {
        public void ExecInputList(bool isMissingParams)
        {
            Base_Mode BaseMain = new Base_Mode();

            string[] inputListArr = {
                "-ls  : Shows the list of commands for '-input'",
                "-str : Standard string input.",
                "-int : Standard integer input.",
                "-fld : Standard double input."
            };

            if (isMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:\n");
            } else {
                Console.Write("\nCommands for '-input':\n\n");
            }

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("-input " + inputListArr[i]);
            }
            Console.Write("\n");
            BaseMain.BaseMode(false);
        }
    }
}