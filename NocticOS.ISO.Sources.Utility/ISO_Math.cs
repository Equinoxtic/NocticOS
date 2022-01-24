using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.ISO.Sources.Utility
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
                    "[divide] Division "
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

        public void MathLs(bool isHelp, bool isList, bool MissingParams, bool ModeReturn)
        {
            ISO_Mode IsoMain = new ISO_Mode();
            ProgramReturn ReturnToProgram = new ProgramReturn();

            string[] mathList = {
                "-ls",
                "-init",
                "-add",
                "-subtract",
                "-multiply",
                "-divide"
            };

            string[] mathDescs = {
                "       : Displays all commands for '.math'",
                "     : Initialize the values of two numbers, and then choose an operation for them.",
                "      : Adds two numbers.",
                " : Subtracts two numbers.",
                " : Multiplies two numbers.",
                "   : Divides two numbers."
            };

            if (MissingParams) {
                Console.WriteLine("\nMissing Parameters, you can enter the following:\n");
            } else {
                Console.WriteLine("\nCommands for '.math':\n");
            }

            for (int i = 0; i < 6; i++) {
                if (isHelp) {
                    Console.Write(".math " + mathList[i] + mathDescs[i] + "\n");
                } if (isList || MissingParams) {
                    Console.Write(mathList[i] + mathDescs[i] + "\n");
                }
            }

            if (ModeReturn) {
                IsoMain.IsoMode(false);
            } else {
                ReturnToProgram.DoReturn(false);
            }
        }
    }
}