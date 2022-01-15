using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdInput
    {
        Base_Mode BaseMain = new Base_Mode();
        public void InputStr()
        {
            var curStr = "";
            Console.Write("\nInput some text for your string: ");
            curStr = Console.ReadLine();
            Console.WriteLine("\nString: " + curStr + "\n");
            BaseMain.BaseMode(false);
        }

        public void InputInt()
        {
            var curInt = 0;
            Console.Write("\nInput some numbers for your integer: ");
            curInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInteger: " + curInt + "\n");
            BaseMain.BaseMode(false);
        }

        public void InputDouble()
        {
            var curDouble = 0.0;
            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDouble: " + curDouble + "\n");
            BaseMain.BaseMode(false);
        }
    }
}