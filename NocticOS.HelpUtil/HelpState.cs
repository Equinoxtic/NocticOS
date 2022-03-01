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
            "help <command> - Shows information and help on a command.",
            "day <flag> - Displays the current time and date.",
            "build <flag> - Builds the NocticOS files and directories.",
            "input <type> - Standard Input for strings, integers and doubles.",
            "math <operation>  - Math for NocticOS. Does simple operations such as Addition, Subtraction, Multiplication and Division.",
            "create <type> - Allows you to create Custom Objects, Functions, and Classes!"
        };

        /*
        string[] CmdRequires = {
            " <command>",
            " <flag>",
            " <flag>",
            " <type>",
            " <operation>",
            " <type>"
        };
        */

        /*
        string[] CmdDescs = {
            " - Shows information and help on a command.",
            " - Displays the current time and date.",
            " - Builds the NocticOS files and directories.",
            " - Standard Input for strings, integers and doubles.",
            " - Math for NocticOS. Does simple operations such as Addition, Subtraction, Multiplication and Division.",
            " - Allows you to create Custom Objects, Functions, and Classes!"
        };
        */

        public void OpenState()
        {
            Console.Write("\n");

            for (int i = 0; i < CmdLs.Length; i++) {
                Console.Write(CmdLs[i] + "\n");
            }

            Program.DoReturn(false);
        }
    }
}