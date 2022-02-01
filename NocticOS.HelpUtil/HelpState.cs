using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.HelpUtil
{
    public class HelpState
    {
        public void OpenState()
        {
            ProgramReturn Program = new ProgramReturn();

            string[] CmdLs = {
                "input"
            };

            string[] CmdRequires = {
                " <type>"
            };

            string[] CmdDescs = {
                " - Standard Input for strings, integers and doubles."
            };

            Console.Write("\n");

            for (int i = 0; i < 1; i++) {
                Console.Write(CmdLs[i]+CmdRequires[i]+CmdDescs[i]+"\n");
            }

            Program.DoReturn(false);
        }
    }
}