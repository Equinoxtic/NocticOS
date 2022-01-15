using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Input
    {
        public void InputStr()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            var curStr = "";

            Console.Write("\nInput some text for your string: ");
            curStr = Console.ReadLine();
            Console.WriteLine("String: " + curStr);
            
            IsoMain.IsoMode(false);
        }

        public void InputInt()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            var curInt = 0;

            Console.Write("\nInput some numbers for your integer: ");
            curInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer: " + curInt);

            IsoMain.IsoMode(false);
        }

        public void InputFloat()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            var curFloat = 0;

            Console.Write("\nInput some numbers for your float: ");
            curFloat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Float: " + curFloat);

            IsoMain.IsoMode(false);
        }

        public void InputDouble()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            var curDouble = 0.0;

            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Double: " + curDouble);

            IsoMain.IsoMode(false);
        }
    }
}