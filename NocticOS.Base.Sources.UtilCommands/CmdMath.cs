using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base.Program;

namespace NocticOS.Base.Sources.UtilCommands
{
    public class CmdMath
    {
        public void ExecMathCmd(string cmdOpr, bool isInit)
        {
            Base_Mode BaseMain = new Base_Mode();

            var curOpr = "";
            var a = 0;
            var b = 0;

            if (!isInit) {
                Console.WriteLine("You'll have to initialize some numbers first!");
            }

            Console.Write("\nInput your first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput your second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (isInit)
            {
                Console.WriteLine(
                    "\nSelect an operation:\n" +
                    "[add] Addition | " +
                    "[subtract] Subtraction | " +
                    "[multiply] Multiplication | " +
                    "[divide] Division | "
                );

                curOpr = Console.ReadLine();

                Console.Write("\nResult: ");

                switch (curOpr)
                {
                    case "add":
                        Console.Write(a + b);
                        break;

                    case "subtract":
                        Console.Write(a - b);
                        break;

                    case "multiply":
                        Console.Write(a * b);
                        break;

                    case "divide":
                        Console.Write(a / b);
                        break;
                }
            }
            else
            {
                Console.Write("\nResult: ");
                switch (cmdOpr)
                {
                    case "-math -add":
                        Console.Write(a + b);
                        break;

                    case "-math -subtract":
                        Console.Write(a - b);
                        break;

                    case "-math -multiply":
                        Console.Write(a * b);
                        break;

                    case "-math -divide":
                        Console.Write(a / b);
                        break;
                }
            }
            Console.WriteLine("\n");
            BaseMain.BaseMode(false);
        }
    }
}