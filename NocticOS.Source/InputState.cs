using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Source
{
    public class InputState
    {
        StandardInput DaInput = new StandardInput();
        public void InputSelect()
        {
            var DaInputType = "";
            var options = "";
            var ShowDaOutput = false;

            string[] InputTypeList = {
                "[str] String | ",
                "[int] Integer | ",
                "[dbl] Double"
            };

            Console.Write("\nSelect a type for input:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(InputTypeList[i]);
            }

            Console.Write("\n~ ");
            DaInputType = Console.ReadLine();

            Console.Write("Show Output? [Y/N]: ");
            options = Console.ReadLine();

            if (options == "y" || options == "Y") {
                ShowDaOutput = true;
            } else if (options == "n" || options == "N") {
                ShowDaOutput = false;
            } else {
                Console.WriteLine("Operation cancelled.");
            }

            switch(DaInputType)
            {
                case "str" : DaInput.InputStr(ShowDaOutput, true); break;
                case "int" : DaInput.InputInt(ShowDaOutput, true); break;
                case "dbl" : DaInput.InputDouble(ShowDaOutput, true); break; 
            }
        }

        public void InputSwitch(string CurType)
        {
            switch(CurType)
            {
                case "str": DaInput.InputStr(true, true); break;
                case "int": DaInput.InputInt(true, true); break;
                case "dbl": DaInput.InputDouble(true, true); break;
            }
        }
    }
}