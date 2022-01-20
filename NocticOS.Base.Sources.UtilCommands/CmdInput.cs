using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdInput
    {
        Base_Mode BaseMain = new Base_Mode();
        ProgramReturn ReturnToProgram = new ProgramReturn();
        public void InputStr(bool showOutput)
        {
            var curStr = "";
            Console.Write("\nInput some text for your string: ");
            curStr = Console.ReadLine();
            if (showOutput) {
                Console.WriteLine("\nString: " + curStr + "\n");
            }
            BaseMain.BaseMode(false);
        }

        public void InputInt(bool showOutput)
        {
            var curInt = 0;
            Console.Write("\nInput some numbers for your integer: ");
            curInt = Convert.ToInt32(Console.ReadLine());
            if (showOutput) {
                Console.WriteLine("\nInteger: " + curInt + "\n");
            }
            BaseMain.BaseMode(false);
        }

        public void InputDouble(bool showOutput)
        {
            var curDouble = 0.0;
            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());
            if (showOutput) {
                Console.WriteLine("\nDouble: " + curDouble + "\n");
            }
            BaseMain.BaseMode(false);
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
                " : Shows the list of commands for '-input'",
                " : Standard string input.",
                " : Standard integer input.",
                " : Standard double input."
            };

            if (IsMissingParams) {
                Console.WriteLine("\nMissing parameters, you can enter the following:\n");
            } else {
                Console.Write("\nCommands for '-input':\n\n");
            }

            for (int i = 0; i < 4; i++) {
                if (IsMissingParams) {
                    Console.Write("-input " + inputListArr[i] + inputListDescs[i] + "\n");
                } if (IsHelp) {
                    Console.Write(inputListArr[i] + inputListDescs[i] + "\n");
                } if (isList) {
                    Console.Write(inputListArr[i] + "\n");
                }
            }

            if (ModeReturn) {
                BaseMain.BaseMode(false);
            } else {
                ReturnToProgram.DoReturn(false);
            }
        }
    }
}