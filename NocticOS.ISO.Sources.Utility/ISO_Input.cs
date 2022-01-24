using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Utility
{
    public class ISO_Input
    {
        ISO_Mode IsoMain = new ISO_Mode();
        ProgramReturn ReturnedProgram = new ProgramReturn();

        public void InputStr(bool showOutput)
        {
            var curStr = "";
            Console.Write("\nInput some text for your string: ");
            curStr = Console.ReadLine();
            if (showOutput) {
                Console.WriteLine("\nString: " + curStr + "\n");
            }
            IsoMain.IsoMode(false);
        }

        public void InputInt(bool showOutput)
        {
            var curInt = 0;
            Console.Write("\nInput some numbers for your integer: ");
            curInt = Convert.ToInt32(Console.ReadLine());
            if (showOutput) {
                Console.WriteLine("\nInteger: " + curInt + "\n");
            }
            IsoMain.IsoMode(false);
        }

        public void InputDouble(bool showOutput)
        {
            var curDouble = 0.0;
            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());
            if (showOutput) {
                Console.WriteLine("\nDouble: " + curDouble + "\n");
            }
            IsoMain.IsoMode(false);
        }

        public void InputLs(bool IsHelp, bool isList, bool IsMissingParams, bool ModeReturn) 
        {
            string[] inputListArr = {
                "-ls",
                "-str",
                "-int",
                "-fld"
            };

            string[] inputListDescs = {
                "  : Shows the list of commands for '.input'",
                " : Standard string input.",
                " : Standard integer input.",
                " : Standard double input."
            };

            if (IsMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:\n");
            } else {
                Console.Write("\nCommands for '.input':\n\n");
            }

            for (int i = 0; i < 4; i++) {
                if (IsHelp || IsMissingParams) {
                    Console.Write(".input " + inputListArr[i] + inputListDescs[i] + "\n");
                } if (isList) {
                    Console.Write(inputListArr[i] + "\n");
                }
            }

            if (ModeReturn) {
                IsoMain.IsoMode(false);
            } else {
                ReturnedProgram.DoReturn(false);
            }
        }
    }
}