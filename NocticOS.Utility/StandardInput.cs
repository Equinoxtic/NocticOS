using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class StandardInput
    {
        public bool ShowOutput = false;
        public void InputStr()
        {
            var curString = "";

            Console.Write("Input some text for your string: ");
            curString = Console.ReadLine();

            if (ShowOutput)
            {
                Console.WriteLine("String: " + curString);
            }
        }

        public void InputInt()
        {
            int curInteger = 0;

            Console.Write("Input some numbers for your integer: ");
            curInteger = Convert.ToInt32(Console.ReadLine());

            if (ShowOutput)
            {
                Console.WriteLine("Integer: " + curInteger);
            }
        }
    }
}