using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Creation
{
    public class ISO_CreateList
    {
        public void ExecCreateList(bool IsMissingParams)
        {
            ISO_Mode IsoMain = new ISO_Mode();

            string[] createList = {
                "-ls",
                "-obj",
                "-func (WIP)",
                "-class (WIP)",
                "-makefile",
                "-makedir"
            };

            string[] createDescs = {
                " - Shows the list of parameters for, '.create'",
                " - Create a Custom Object.",
                " - Create a Custom Function.",
                " - Create a Custom Class."
            };

            if (IsMissingParams) {
                Console.WriteLine("Missing parameters, you can enter the following.");
            }

            Console.Write("\n");
            for (int i = 0; i < 4; i++) {
                if (IsMissingParams) {
                    Console.Write(".create " + createList[i] + createDescs[i] + "\n");
                } else {
                    Console.Write(createList[i] + createDescs[i] + "\n");
                }
            }
            Console.Write("\n");

            IsoMain.IsoMode(false);
        }
    }
}