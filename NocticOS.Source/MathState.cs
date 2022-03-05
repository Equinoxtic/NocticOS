using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;
using NocticOS.Lib;

namespace NocticOS.Source
{
    public class MathState
    {
        public void OpenState()
        {
            StandardMath standardMath = new StandardMath();
            Options operationls = new Options();

            var operOpts = "";
            
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

            Console.Write("~ ");
            
            operOpts = Console.ReadLine();

            switch(operOpts)
            {
                case "add" : standardMath.NocticMath("add", true); break;
                case "subtract" : standardMath.NocticMath("subtract", true); break;
                case "multiply" : standardMath.NocticMath("multiply", true); break;
                case "divide" : standardMath.NocticMath("divide", true); break;
            }
        }
    }
}