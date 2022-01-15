using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilityCommands
{
    public class CmdHelp
    {
        public void HelpCommand()
        {
            Base_Mode mainBase = new Base_Mode();
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