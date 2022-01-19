using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdMathList
    {
        public void ExecMathList(bool isMissingParams)
        {
            Base_Mode BaseMain = new Base_Mode();

            string[] mathCmds = {
                "-ls       : Displays all commands for '-math'",
                "-init     : Initialize numbers and select an operation after initialization.",
                "-add      : Adds two numbers.",
                "-subtract : Subtracts two numbers.",
                "-multiply : Multiplies two numbers.",
                "-divide   : Divides two numbers."
            };

            if (isMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:\n");
            } else {
                Console.Write("\nCommands for Math:\n\n");
            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine("-math " + mathCmds[i]);
            }
            Console.Write("\n");
            BaseMain.BaseMode(false);
        }
    }
}