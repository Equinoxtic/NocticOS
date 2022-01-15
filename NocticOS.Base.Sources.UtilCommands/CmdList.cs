using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilityCommands
{
    public class CmdList
    {
        public void ExecCmdList()
        {
            Base_Mode BaseMain = new Base_Mode();
            string[] strCmdList = {
                "-h", "-l"
            };

            Console.WriteLine("All valid NocticOS commands:\n");

            Console.WriteLine(
                "\n" + strCmdList[0] + "\n" +
                strCmdList[1] + "\n"
            );
            BaseMain.BaseMode(false);
        }
    }
}