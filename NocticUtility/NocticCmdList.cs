using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticUtility
{
    public class NocticCmdList
    {
        public void OpenCmdList()
        {
            NocticOS.ProgramReturn ReturnToProgram = new NocticOS.ProgramReturn();

            Console.Write("\n");

            string[] CmdList = {
                "iso",
                "base",
                "exit",
                "help",
                "props"
            };

            string[] CmdDescs = {
                " - Open NocticOS's ISO mode.",
                " - Open NocticOS's Base mode.",
                " - Exits the program.",
                " <command> - Displays information about certain commands.",
                " - Modify NocticOS's properties. (WIP)"
            };

            for (int i = 0; i < 5; i++) {
                Console.Write(CmdList[i] + CmdDescs[i] + "\n");
            }
            ReturnToProgram.DoReturn(false);
        }
    }
}