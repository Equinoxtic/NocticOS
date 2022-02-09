using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Source
{
    public class InputState
    {
        ProgramReturn Program = new ProgramReturn();
        ThrowError throwError = new ThrowError();
        StandardInput DaInput = new StandardInput();
        public void InputSelect()
        {
            var DaInputType = "";
            var options = "";
            var ShowDaOutput = false;

            string[] InputTypeList = {
                "[str] String | ",
                "[int] Integer | ",
                "[flt] Float | ",
                "[dbl] Double"
            };

            Console.Write("\nSelect a type for input:\n");

            for (int i = 0; i < 4; i++) {
                Console.Write(InputTypeList[i]);
            }

            Console.Write("\n~ ");
            DaInputType = Console.ReadLine();

            Console.Write("Show Output? [Y/N]: ");
            options = Console.ReadLine();

            if (options == "y" || options == "Y") {
                ShowDaOutput = true;
                switch(DaInputType)
                {
                    case "str" : DaInput.InputStr(ShowDaOutput, true); break;
                    case "flt" : DaInput.InputFloat(ShowDaOutput, true); break;
                    case "int" : DaInput.InputInt(ShowDaOutput, true); break;
                    case "dbl" : DaInput.InputDouble(ShowDaOutput, true); break;
                }
            } else if (options == "n" || options == "N") {
                throwError.OperationCancelledThrow(true);
            } else {
                throwError.UnknownCharThrow(true);
                Program.DoReturn(false);
            }
        }

        public void InputSwitch(string CurType)
        {
            switch(CurType)
            {
                case "str": DaInput.InputStr(true, true); break;
                case "int": DaInput.InputInt(true, true); break;
                case "flt": DaInput.InputFloat(true, true); break;
                case "dbl": DaInput.InputDouble(true, true); break;
            }
        }
    }
}