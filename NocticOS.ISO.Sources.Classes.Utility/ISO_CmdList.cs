using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_CmdList
    {
        public void ExecCmdList()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            string[] strCmdList = {
                ".h", ".l", ".input", ".math"
            };

            string[] cmdType = { "[Utility]", "[Misc]", "[Creation]" };

            Console.WriteLine("\nAll Valid Commands:");
            Console.WriteLine(
                "\n" + strCmdList[0] + " " + cmdType[0] + "\n" +
                strCmdList[1] + " " + cmdType[1] + "\n" +
                strCmdList[2] + " " + cmdType[0] + "\n" +
                strCmdList[3] + " " + cmdType[0] + "\n"
            );
            IsoMain.IsoMode(false);
        }
    }
}