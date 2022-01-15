using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdInputList
    {
        public void ExecInputList()
        {
            Base_Mode BaseMain = new Base_Mode();

            string[] inputListArr = {
                "-str : Standard string input.",
                "-int : Standard integer input.",
                "-fl  : Standard float input.",
                "-dou : Standard double input."
            };

            Console.WriteLine("\nMissing parameters, you can enter the following:");

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("-input " + inputListArr[i]);
            }
            Console.Write("\n");
            BaseMain.BaseMode(false);
        }
    }
}