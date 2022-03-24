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
        Program program = new Program();
        CursorPrefs prefs = new CursorPrefs();
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

            Options inputList = new Options();
            inputList.PushOptions(InputTypeList, InputTypeList.Length, false);

            Console.Write("\n" + prefs.curSelectCursor);
            daInputType = Console.ReadLine();
            if (String.IsNullOrEmpty(daInputType)) {
                Throw EmptyValue = new Throw();
                EmptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    true
                );
                program.DoReturn(false);
            }

            Console.Write("Show Output? [Y/N]: ");
            options = Console.ReadLine();
            if (String.IsNullOrEmpty(options)) {
                Throw EmptyValue = new Throw();
                EmptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again.",
                    true
                );
                program.DoReturn(false);
            } else {
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