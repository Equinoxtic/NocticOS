using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Main.Base.Program;

namespace NocticOS.NocticBase.Sources.UtilityCommands
{
    public class CmdHelp
    {
        public void HelpCommand()
        {
            Base mainBase = new Base();
            string[] strCmdList = {
                "-h", "-l"
            };

            Console.WriteLine(
                "\n" + strCmdList[0] + "   Displays commands and the information for each command.\n" +
                strCmdList[1] + "   Displays commands but does not display information for each command.\n"
            );
            mainBase.BaseMode(false);
        }
    }
}