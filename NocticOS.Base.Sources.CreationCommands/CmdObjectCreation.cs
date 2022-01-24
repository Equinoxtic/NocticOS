using System;
using System.Linq;
using System.Threading.Tasks;
using Main.Base;

namespace NocticOS.Base.Sources.CreationCommands
{
    public class CmdObjectCreation
    {
        public void ObjectCreator()
        {
            Base_Mode BaseMain = new Base_Mode();

            var objName = "";
            var objType = "";
            var strObjType = "";
            var curString = "";
            var curInt = 0;
            var curDou = 0.0;
            Console.Write("\nInput a name for your object: ");
            objName = Console.ReadLine();

            string[] typesOfObj = {
                "[str] String | ",
                "[int] Integer | ",
                "[fld] Double "
            };

            Console.Write("\nChoose a type for your object:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(typesOfObj[i]);
            }

            Console.Write("\n");

            objType = Console.ReadLine();

            switch (objType)
            {
                case "str":
                    Console.Write("Input some text for your string: ");
                    curString = Console.ReadLine();
                    strObjType = "string";
                    break;

                case "int":
                    Console.Write("Input some numbers for your integer: ");
                    curInt = Convert.ToInt32(Console.ReadLine());
                    strObjType = "integer";
                    break;

                case "fld":
                    Console.Write("Input some numbers for your double: ");
                    curDou = Convert.ToDouble(Console.ReadLine());
                    strObjType = "double";
                    break;
            }

            Console.WriteLine("\nName: " + objName + "\nType: " + strObjType);

            switch (strObjType)
            {
                case "string" : Console.Write("\nString: " + curString); break;
                case "integer" : Console.Write("\nInteger: " + curInt); break;
                case "double" : Console.Write("\nDouble: " + curDou); break;
            }
            BaseMain.BaseMode(false);
        }

        public void CreationList(bool isHelp, bool isList, bool isMissingParams, bool ModeReturn)
        {
            Base_Mode BaseMain = new Base_Mode();
            ProgramReturn ReturnToProgram = new ProgramReturn();

            string[] createList = {
                "-ls",
                "-obj",
                "-func (WIP)",
                "-class (WIP)",
                "-makefile",
                "-makedir"
            };

            string[] createDescs = {
                " - Shows the list of parameters/commands for '-create'",
                " - Create a Custom Object.",
                " - Create a Custom Function.",
                " - Create a Custom Class.",
                " - Create a Custom File in a specific directory.",
                " - Create a Directory."
            };

            if (isMissingParams) {
                Console.WriteLine("Missing Parameters. Please enter the following.");
            } else {
                Console.WriteLine("\nCommands for '-create':");
            }

            Console.Write("\n");
            
            for (int i = 0; i < 6; i++) {
                if (isMissingParams) {
                    Console.Write("-create " + createList[i] + createDescs[i] + "\n");
                }
                if (isHelp || isList) {
                    Console.Write(createList[i] + createDescs[i] + "\n");
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