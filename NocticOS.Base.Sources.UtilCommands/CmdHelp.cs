using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdHelp
    {
        public void HelpCommand()
        {
            Base_Mode mainBase = new Base_Mode();
            string[] strCmdList = {
                "-h", "-ls", "-input", "-math"
            };

            Console.WriteLine(
                "\n" + strCmdList[0] + "   Displays commands and the information for each command.\n" +
                strCmdList[1] + "   Displays commands but does not display information for each command.\n" +
                strCmdList[2] + "   Standard Input for strings, integers, floats and doubles.\n" +
                strCmdList[3] + "   Used for performing calculations with addition, subtraction, multiplication and division.\n"
            );
            mainBase.BaseMode(false);
        }
    }
}