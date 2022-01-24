using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Utility
{
    public class ISO_CmdList
    {
        public void ExecCmdList()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            string[] strCmdList = {
                ".h", 
                ".ls", 
                ".input <type>", 
                ".math <operation>",
                ".create <type>"
            };

            Console.WriteLine("\nAll Valid Commands:\n");

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(strCmdList[i]);
            }
			Console.Write("\n");

            IsoMain.IsoMode(false);
        }
    }
}