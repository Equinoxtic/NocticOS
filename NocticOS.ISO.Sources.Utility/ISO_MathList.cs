using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Utility
{
    public class ISO_MathList
    {
        public void ExecMathList(bool isMissingParams)
        {
            ISO_Mode IsoMain = new ISO_Mode();

            string[] mathList = {
                "-ls       : Displays all the commands for '.math'",
                "-init     : Initialize numbers and select an operation after initialization.",
                "-add      : Adds two numbers.",
                "-subtract : Subtracts two numbers.",
                "-multiply : Multiplies two numbers.",
                "-divide   : Divides two numbers."
            };

            if (isMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:\n");
            } else {
                Console.Write("\nCommands for '.math':\n\n");
            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(".math " + mathList[i]);
            }
            Console.Write("\n");
            IsoMain.IsoMode(false);
        }
    }
}