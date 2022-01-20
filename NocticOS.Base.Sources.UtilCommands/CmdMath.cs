using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

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
                    "[+] Addition | " +
                    "[-] Subtraction | " +
                    "[*] Multiplication | " +
                    "[/] Division "
                );

                curOpr = Console.ReadLine();

                Console.Write("\nResult: ");

                switch (curOpr)
                {
                    case "+":
                        Console.Write(a + b);
                        break;

                    case "-":
                        Console.Write(a - b);
                        break;

                    case "*":
                        Console.Write(a * b);
                        break;

                    case "/":
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

        public void MathLs(bool isHelp, bool isList, bool MissingParams, bool ModeReturn)
        {
            Base_Mode BaseMain = new Base_Mode();
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
                "       : Displays all the commands for '-math'",
                "     : Initialize the values of two numbers, and then choose an operation for them.",
                "      : Adds two numbers.",
                " : Subtracts two numbers.",
                " : Multiplies two numbers.",
                "   : Divides two numbers."
            };

            if (MissingParams) {
                Console.WriteLine("\nMissing Parameters, you can enter the following:\n");
            } else {
                Console.WriteLine("\nCommands for '-math':\n");
            }

            for (int i = 0; i < 6; i++) {
                if (isHelp) {
                    Console.Write("-math " + mathList[i] + mathDescs[i] + "\n");
                } if (isList || MissingParams) {
                    Console.Write(mathList[i] + mathDescs[i] + "\n");
                }
            }

            if (ModeReturn) {
                BaseMain.BaseMode(false);
            } else {
                ReturnToProgram.DoReturn(false);
            }
        }
    }
}