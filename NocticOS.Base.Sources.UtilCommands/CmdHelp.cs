using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdHelp
    {
        public void HelpCommand(bool isHelp)
        {
            Base_Mode mainBase = new Base_Mode();

            string[] strCmdList = {
                "-h", 
                "-ls", 
                "-input <type>", 
                "-math <operation>",
                "-create <type>"
            };

            string[] strCmdDescs = {
                " - Displays commands and the information for each command.",
                " - Displays commands but does not display information for each command.",
                " - Standard Input for strings, integers, floats and doubles.",
                " - Used for performing calculations with addition, subtraction, multiplication and division."
            };

            if (!isHelp) {
                Console.WriteLine("\nAvailable commands for NocticOS (Base):");
            }

            Console.Write("\n");
            for (int i = 0; i < 5; i++) {
                if (isHelp) {
                    Console.Write(strCmdList[i] + strCmdDescs[i] + "\n");
                } else {
                    Console.Write(strCmdList[i]);
                }
            }
            Console.Write("\n");
            mainBase.BaseMode(false);
        }
    }
}