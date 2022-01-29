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
    }
}