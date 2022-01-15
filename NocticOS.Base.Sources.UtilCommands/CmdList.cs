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
                "-h", "-l", "-input"
            };

            Console.WriteLine("All valid NocticOS commands:\n");

            Console.WriteLine(
                "\n" + strCmdList[0] + "\n" +
                strCmdList[1] + "\n" +
                strCmdList[2] + "\n"
            );
            BaseMain.BaseMode(false);
        }
    }
}