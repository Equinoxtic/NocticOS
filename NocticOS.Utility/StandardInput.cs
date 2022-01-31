using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class StandardInput
    {
        public void InputStr(bool ShowOutput)
        {
            var curString = "";

            Console.Write("\nInput some text for your string: ");
            curString = Console.ReadLine();

            if (ShowOutput)
            {
                Console.WriteLine("String: " + curString);
            }
        }

        public void InputInt(bool ShowOutput)
        {
            int curInteger = 0;

            Console.Write("\nInput some numbers for your integer: ");
            curInteger = Convert.ToInt32(Console.ReadLine());

            if (ShowOutput)
            {
                Console.WriteLine("Integer: " + curInteger);
            }
        }

        public void InputDouble(bool ShowOutput)
        {
            double curDouble = 0.0;

            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());

            if (ShowOutput)
            {
                Console.WriteLine("Double: " + curDouble);
            }
        }
    }
}