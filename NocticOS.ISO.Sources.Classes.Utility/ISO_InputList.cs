using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_InputList
    {
        public void InputList(bool isMissingParams)
        {
            ISO_Mode IsoMain = new ISO_Mode();

            string[] InputListArr = {
                "-ls  : Shows the list of commands for '.input'",
                "-str : Standard string input.",
                "-int : Standard integer input.",
                "-fl  : Standard float input.",
                "-dou : Standard double input."
            };

            if (isMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:");
            }

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(".input " + InputListArr[i]);
            }
            Console.Write("\n");
            IsoMain.IsoMode(false);
        }
    }
}