using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO.Program;

namespace NocticOS.ISO.Sources.Classes.Utility
{
    public class ISO_Math
    {
        public void IsoMath(string cmdOpr, bool isInit)
        {
            ISO_Mode IsoMain = new ISO_Mode();

            var curOpr = "";
            var a = 0;
            var b = 0;

            if (!isInit) {
                Console.WriteLine("\nYou'll have to initialize some numbers first!");
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
                    case ".math -add":
                        Console.Write(a + b);
                        break;

                    case ".math -subtract":
                        Console.Write(a - b);
                        break;

                    case ".math -multiply":
                        Console.Write(a * b);
                        break;

                    case ".math -divide":
                        Console.Write(a / b);
                        break;
                }
            }
            Console.WriteLine("\n");
            IsoMain.IsoMode(false);
        }
    }
}