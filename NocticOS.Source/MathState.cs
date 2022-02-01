using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Source
{
    public class MathState
    {
        public void OpenState()
        {
            ProgramReturn Program = new ProgramReturn();
            StandardMath standardMath = new StandardMath();

            var operOpts = "";
            
            string[] OperList = {
                "[add] Addition",
                "[subtract] Subtraction",
                "[multiply] Multiplication",
                "[divide] Division\n"
            };

            Console.WriteLine("\nSelect an Operation:\n");

            for (int i = 0; i < 4; i++) {
                Console.Write(OperList[i] + "\n");
            }

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