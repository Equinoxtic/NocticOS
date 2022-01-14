using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main.ISO.Program;

namespace NocticOS.NocticISO.Sources.Classes.Utility
{
    public class ISO_CmdList
    {
        public void ExecCmdList()
        {
            ISO IsoMain = new ISO();
            string[] strCmdList = {
                ".h", ".l"
            };

            string[] cmdType = { "[Utility]", "[Misc]", "[Creation]" };

            Console.WriteLine("\nAll Valid Commands:");
            Console.WriteLine(
                "\n" + strCmdList[0] + " " + cmdType[0] + "\n" +
                strCmdList[1] + " " + cmdType[1] + "\n"
            );
            IsoMain.IsoMode(false);
        }
    }
}