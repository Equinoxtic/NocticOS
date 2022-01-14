using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.NocticISO.Sources.Classes.Utility
{
    public class ISO_Help
    {
        public void IsoHelpCmd()
        {
            ISO IsoMain = new ISO();
            string[] strCmdList = {
                ".h", ".l"
            };

            string[] cmdTypeList = { "[Utility]", "[Misc]", "[Creation]" };

            Console.WriteLine(
                "\n" + strCmdList[0] + " " + cmdTypeList[0] + " - Helps display information of all commands.\n" +
                strCmdList[1] + " " + cmdTypeList[1] + " - Displays all commands without displaying the information.\n"
            );
            IsoMain.IsoMode(false);
        }
    }
}