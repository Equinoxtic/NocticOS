using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Input
    {
        ISO_Mode IsoMain = new ISO_Mode();
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
    }
}