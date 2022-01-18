using System;
using System.Linq;
using System.IO;
using Main.ISO.Program;
using NocticOS.ISO.Sources.Classes.Utility;

namespace NocticOS.ISO.Sources.Classes.Creation
{
    public class ISO_ObjectCreation
    {
        public void ObjectCreator()
        {
            ISO_Mode IsoMain = new ISO_Mode();
            ISO_Input IsoIn = new ISO_Input();

            var objName = "";
            var objType = "";
            var strObjType = "";
            var options = "";
            var curString = "";
            var curInt = 0;
            var curDou = 0.0;
            var nocticObjDir = @"C:\NocticOS\Objects";
            var curObjDir = @"C:\NocticOS\Objects\" + objName + ".txt";

            StreamReader SR = new StreamReader(curObjDir);

            Console.Write("\nInput a name for your new object: ");
            objName = Console.ReadLine();

            switch (objType)
            {
                case "str":
                    Console.Write("Input some text for your string: ");
                    curString = SR.ReadLine();
                    strObjType = "string";
                    break;

                case "int":
                    Console.Write("Input some numbers: for your integer: ");
                    curInt = Convert.ToInt32(SR.ReadLine());
                    strObjType = "integer";
                    break;

                case "fld":
                    Console.Write("Input some numbers for your double: ");
                    curDou = Convert.ToDouble(SR.ReadLine());
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

            Console.WriteLine("Save Object? [y/n]: ");
            options = Console.ReadLine();

            void DoWrite()
            {
                if (System.IO.Directory.Exists(nocticObjDir)) {
                    System.IO.File.Create(curObjDir);
                    File.WriteAllText(curObjDir, "Name: " + objName + "\nType: " + strObjType);
                    switch (strObjType)  {
                        case "string" : File.WriteAllText(curObjDir, "\nString: " + curString); break;
                        case "integer" : File.WriteAllText(curObjDir, "\nInteger: " + curInt); break;
                        case "double" : File.WriteAllText(curObjDir, "\nDouble: " + curDou); break;
                    }
                }
                Console.Write("Successfully Saved Object: " + objName);
            }

            if (options == "y") {
                DoWrite();
            } else if (options == "n") {
                Console.WriteLine("Operation Cancelled.");
            } else {
                Console.WriteLine("Unknown Character.\n");
            }
            IsoMain.IsoMode(false);
        }
    }
}