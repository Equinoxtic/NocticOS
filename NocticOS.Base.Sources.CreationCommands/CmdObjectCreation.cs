using System;
using System.Linq;
using System.Threading.Tasks;
using Main.ISO;

namespace NocticOS.Base.Sources.CreationCommands
{
    public class CmdObjectCreation
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
            IsoMain.IsoMode(false);
        }
    }
}