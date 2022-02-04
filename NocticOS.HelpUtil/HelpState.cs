using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class HelpState
    {
        ProgramReturn Program = new ProgramReturn();
        InputHelp inputHelp = new InputHelp();
        MathHelp mathHelp = new MathHelp();

        string[] CmdLs = {
            "help",
            "build",
            "input",
            "math"
        };

        string[] CmdRequires = {
            " <command>",
            " <flag>",
            " <type>",
            " <operation>"
        };

        string[] CmdDescs = {
            " - Shows information and help on a command.",
            " - Builds the NocticOS files and directories.",
            " - Standard Input for strings, integers and doubles.",
            " - Math for NocticOS. Does simple operations such as Addition, Subtraction, Multiplication and Division."
        };
        public void OpenState()
        {
            Console.Write("\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(CmdLs[i]+CmdRequires[i]+CmdDescs[i]+"\n");
            }

            Program.DoReturn(false);
        }
    }
}