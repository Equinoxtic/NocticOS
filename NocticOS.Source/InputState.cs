using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;
using NocticOS.Settings;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class InputState
    {
        CursorPrefs prefs = new CursorPrefs();
        Program program = new Program();
        // ThrowError throwError = new ThrowError();
        Throw theThrows = new Throw();
        StandardInput DaInput = new StandardInput();
        public void InputSelect()
        {
            var daInputType = "";
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

            Console.Write("\n" + prefs.curSelectCursor);
            daInputType = Console.ReadLine();

            Console.Write("Show Output? [Y/N]: ");
            options = Console.ReadLine();

            if (options == "y" || options == "Y") {
                ShowDaOutput = true;
                switch(daInputType)
                {
                    case "str" : DaInput.InputStr(ShowDaOutput, true); break;
                    case "flt" : DaInput.InputFloat(ShowDaOutput, true); break;
                    case "int" : DaInput.InputInt(ShowDaOutput, true); break;
                    case "dbl" : DaInput.InputDouble(ShowDaOutput, true); break;
                }
            } else if (options == "n" || options == "N") {
                // throwError.OperationCancelledThrow(true);
                theThrows.CreateThrow(false, 
                    "mp",
                    "Missing Parameters. Please enter the following:",
                    true
                );
            } else {
                // throwError.UnknownCharThrow(true);
                theThrows.CreateThrow(false, 
                    "uc",
                    "Unknown Character.",
                    true
                );
                program.DoReturn(false);
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