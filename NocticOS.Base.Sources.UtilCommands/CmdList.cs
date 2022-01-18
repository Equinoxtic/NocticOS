using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdList
    {
        public void ExecCmdList()
        {
            Base_Mode BaseMain = new Base_Mode();
            string[] strCmdList = {
                "-h", "-ls", "-input", "-math"
            };

            Console.WriteLine("All valid NocticOS commands:\n");

            for (int i = 0; i < 4; i++) {
                Console.WriteLine(strCmdList[i]);
            }
            Console.Write("\n");
            BaseMain.BaseMode(false);
        }
    }
}