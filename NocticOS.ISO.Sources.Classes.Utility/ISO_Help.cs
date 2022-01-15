using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Help
    {
        public void IsoHelpCmd()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            string[] strCmdList = {
                ".h", ".l", ".input", ".math"
            };

            string[] cmdTypeList = { "[Utility]", "[Misc]", "[Creation]" };

            Console.WriteLine(
                "\n" + strCmdList[0] + " " + cmdTypeList[0] + " - Helps display information of all commands.\n" +
                strCmdList[1] + " " + cmdTypeList[1] + " - Displays all commands without displaying the information.\n" +
                strCmdList[2] + " <type> " + cmdTypeList[0] + " - Standard Input command for strings, integers, floats and doubles.\n" +
                strCmdList[3] + " <operation> " + cmdTypeList[0] + " - Used for performing simple calculations with additon, subtraction, multiplication and division.\n"
            );
            IsoMain.IsoMode(false);
        }
    }
}