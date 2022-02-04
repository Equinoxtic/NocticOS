using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Utility
{
    public class CustomCreation
    {
        public void ObjectCreation()
        {
            ProgramReturn Program = new ProgramReturn();
            StandardInput standardInput = new StandardInput();

            string[] objTypes = {
                "[str] String",
                "[int] Integer",
                "[dbl] Double"
            };

            var OBJECT_NAME = "";
            var OBJECT_TYPE = "";

            Console.Write("\nInput a name for your object: ");
            OBJECT_NAME = Console.ReadLine();

            Console.Write("\nSelect an Object Type:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(objTypes[i] + "\n");
            }

            OBJECT_TYPE = Console.ReadLine();

            switch(OBJECT_TYPE) 
            {
                case "str" : standardInput.InputStr(true); break;
                case "int" : standardInput.InputInt(true); break;
                case "dbl" : standardInput.InputDouble(true); break;
            }

            Program.DoReturn(false);
        }

        public void FunctionCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            Console.Write("\nThis feature is still in WIP.\n");

            Program.DoReturn(false);
        }

        public void ClassCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            Console.Write("\nThis feature is still in WIP.\n");

            Program.DoReturn(false);
        }
    }
}