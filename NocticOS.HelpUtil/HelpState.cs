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
            "build-dirs",
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

        public void HelpSwitch(string curCmd)
        {
            Console.Write("\n");

            switch(curCmd)
            {
                case "build-dirs":
                    Console.Write(
                        CmdLs[1] +
                        CmdRequires[1] +
                        CmdDescs[1]
                    );
                    break;
                    
                case "input":
                    Console.Write(
                        CmdLs[2] + 
                        CmdRequires[2] + 
                        CmdDescs[2]
                    );
                    inputHelp.OpenHelp(false);
                    break;

                case "math":
                    Console.Write(
                        CmdLs[3] + 
                        CmdRequires[3] + 
                        CmdDescs[3]
                    );
                    mathHelp.OpenHelp(false);
                    break;
            }

            Console.Write("\n");

            Program.DoReturn(false);
        }
    }
}