using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_InputList
    {
        public void InputList()
        {
            ISO_Mode IsoMain = new ISO_Mode();

            string[] InputListArr = {
                "-str : Standard string input.",
                "-int : Standard integer input.",
                "-fl  : Standard float input.",
                "-dou : Standard double input."
            };

            Console.WriteLine("\nMissing parameters, you can enter the following:");

            for (int i = 0; i < 4; i++) {
                Console.WriteLine(".input " + InputListArr[i]);
            }
            Console.Write("\n");
            IsoMain.IsoMode(false);
        }
    }
}