using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class StandardInput
    {
        ProgramReturn Program = new ProgramReturn();
        public void InputStr(bool ShowOutput, bool ReturnToProgram)
        {
            var curString = "";

            Console.Write("\nInput some text for your string: ");
            curString = Console.ReadLine();

            if (ShowOutput)
            {
                Console.WriteLine("String: " + curString);
            }

            if (ReturnToProgram)
            {
                Program.DoReturn(false);
            }
        }

        public void InputInt(bool ShowOutput, bool ReturnToProgram)
        {
            int curInteger = 0;

            Console.Write("\nInput some numbers for your integer: ");
            curInteger = Convert.ToInt32(Console.ReadLine());

            if (ShowOutput)
            {
                Console.WriteLine("Integer: " + curInteger);
            }

            if (ReturnToProgram)
            {
                Program.DoReturn(false);
            }
        }

        public void InputFloat(bool ShowOutput, bool ReturnToProgram)
        {
            float curFloat = 0;

            Console.Write("\nInput some numbers for your float: ");
            curFloat = float.Parse(Console.ReadLine());

            if (ShowOutput)
            {}

            if (ReturnToProgram)
            {}
        }

        public void InputDouble(bool ShowOutput, bool ReturnToProgram)
        {
            double curDouble = 0.0;

            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());

            if (ShowOutput)
            {
                Console.WriteLine("Double: " + curDouble);
            }

            if (ReturnToProgram)
            {
                Program.DoReturn(false);
            }
        }
    }
}