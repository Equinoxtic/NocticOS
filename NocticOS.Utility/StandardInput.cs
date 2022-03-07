using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Utility
{
    public class StandardInput
    {
        Program program = new Program();
        Throw emptyThrow = new Throw();
        public void InputStr(bool ShowOutput, bool ReturnToProgram)
        {
            string? curString;

            Console.Write("\nInput some text for your string: ");
            curString = Console.ReadLine();

            if (ShowOutput) {
                if (String.IsNullOrEmpty(curString)) {
                    emptyThrow.CreateThrow(false, 
                        "et",
                        "The current string has an empty value!\nPlease try again.",
                        true);
                } else {
                    Console.WriteLine("String: " + curString);
                }
            }

            if (ReturnToProgram) {
                program.DoReturn(false);
            }
        }

        public void InputInt(bool ShowOutput, bool ReturnToProgram)
        {
            int curInteger;

            Console.Write("\nInput some numbers for your integer: ");
            curInteger = Convert.ToInt32(Console.ReadLine());

            if (ShowOutput) {
                Console.WriteLine("Integer: " + curInteger);
            }

            if (ReturnToProgram) {
                program.DoReturn(false);
            }
        }

        public void InputFloat(bool ShowOutput, bool ReturnToProgram)
        {
            float curFloat;

            Console.Write("\nInput some numbers for your float: ");
            curFloat = float.Parse(Console.ReadLine());

            if (ShowOutput) {
                Console.WriteLine("Float: " + curFloat);
            }

            if (ReturnToProgram) {
                program.DoReturn(false);
            }
        }

        public void InputDouble(bool ShowOutput, bool ReturnToProgram)
        {
            double curDouble;

            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());

            if (ShowOutput) {
                Console.WriteLine("Double: " + curDouble);
            }

            if (ReturnToProgram) {
                program.DoReturn(false);
            }
        }
    }
}