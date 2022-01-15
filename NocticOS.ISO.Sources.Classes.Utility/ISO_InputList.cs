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
                "-str : Standard string Input.",
                "-int : Standard integer Input.",
                "-fl  : Standard float Input.",
                "-dou : Standard double Input."
            };

            Console.WriteLine("Missing parameters, you can enter the following:\n");

            for (int i = 0; i < 4; i++) {
                Console.WriteLine(".input " + InputListArr[i]);
            }
            Console.WriteLine("\n");
            IsoMain.IsoMode(false);
        }
    }
}