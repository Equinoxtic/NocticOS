using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;
using NocticOS.Settings;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class MathState
    {
        public void OpenState()
        {
            Program program = new Program();
            CursorPrefs prefs = new CursorPrefs();
            StandardMath standardMath = new StandardMath();
            Options operationls = new Options();

            string? operOpts = "";
            
            string[] operList = {
                "[add] Addition",
                "[subtract] Subtraction",
                "[multiply] Multiplication",
                "[divide] Division\n"
            };

            Console.WriteLine("\nSelect an Operation:\n");

            /*
            for (int i = 0; i < 4; i++) {
                Console.Write(OperList[i] + "\n");
            }
            */

            operationls.PushOptions(operList, operList.Length);

            Console.Write(prefs.curSelectCursor);
            
            operOpts = Console.ReadLine();
            if (String.IsNullOrEmpty(operOpts)) {
                Throw EmptyValue = new Throw();
                EmptyValue.CreateThrow(
                    false,
                    "ev",
                    "Empty value. Please try again later.",
                    true
                );
                program.DoReturn(false);
            } else {
                switch(operOpts) {
                    case "add" : standardMath.NocticMath("add", true); break;
                    case "subtract" : standardMath.NocticMath("subtract", true); break;
                    case "multiply" : standardMath.NocticMath("multiply", true); break;
                    case "divide" : standardMath.NocticMath("divide", true); break;
                }
            }
        }
    }
}