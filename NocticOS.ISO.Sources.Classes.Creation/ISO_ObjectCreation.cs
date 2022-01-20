using System;
using System.Linq;
using System.IO;
using Main.ISO;
using NocticOS.ISO.Sources.Classes.Utility;

namespace NocticOS.ISO.Sources.Classes.Creation
{
    public class ISO_ObjectCreation
    {
        public void ObjectCreator()
        {
            ISO_Mode IsoMain = new ISO_Mode();

            var objName = "";
            var objType = "";
            var strObjType = "";
            var curString = "";
            var curInt = 0;
            var curDou = 0.0;
            Console.Write("\nInput a name for your new object: ");
            objName = Console.ReadLine();

            string[] typesOfObj = {
                "[str] String | ",
                "[int] Integer | ",
                "[fld] Double"
            };

            Console.Write("\nChoose a type for your new object:\n");

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
                    Console.Write("Input some numbers: for your integer: ");
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
                case "string" : Console.Write("String: " + curString); break;
                case "integer" : Console.Write("Integer: " + curInt); break;
                case "double" : Console.Write("Double: " + curDou); break;
            }
            IsoMain.IsoMode(false);
        }

        public void CreationList(bool ParamsMissing)
        {
            ISO_Mode IsoMain = new ISO_Mode();

            string[] createList = {
                "-ls",
                "-obj",
                "-func (WIP)",
                "-class (WIP)",
                "-makefile",
                "-makedir"
            };

            string[] createDescs = {
                " - Shows the list of parameters for, '.create'",
                " - Create a Custom Object.",
                " - Create a Custom Function.",
                " - Create a Custom Class."
            };

            if (ParamsMissing) {
                Console.WriteLine("Missing parameters, you can enter the following.");
            }

            Console.Write("\n");
            for (int i = 0; i < 4; i++) {
                if (ParamsMissing) {
                    Console.Write(".create " + createList[i] + createDescs[i] + "\n");
                } else {
                    Console.Write(createList[i] + createDescs[i] + "\n");
                }
            }
            Console.Write("\n");

            IsoMain.IsoMode(false);
        }
    }
}