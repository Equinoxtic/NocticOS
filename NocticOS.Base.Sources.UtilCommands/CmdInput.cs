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
            Console.WriteLine("String: " + curStr + "\n");
            BaseMain.BaseMode(false);
        }

        public void InputInt()
        {
            var curInt = 0;
            Console.Write("\nInput some numbers for your integer: ");
            curInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer: " + curInt + "\n");
            BaseMain.BaseMode(false);
        }

        public void InputFloat()
        {
            var curFloat = 0;
            Console.Write("\nInput some numbers for your float: ");
            curFloat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Float: " + curFloat + "\n");
            BaseMain.BaseMode(false);
        }

        public void InputDouble()
        {
            var curDouble = 0.0;
            Console.Write("\nInput some numbers for your double: ");
            curDouble = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Double: " + curDouble + "\n");
            BaseMain.BaseMode(false);
        }
    }
}