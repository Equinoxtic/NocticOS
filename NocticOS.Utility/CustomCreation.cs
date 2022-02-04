using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class CustomCreation
    {
        public void ObjectCreation()
        {
            ProgramReturn Program = new ProgramReturn();

            string[] objTypes = {};

            var OBJECT_NAME = "";
            var OBJECT_TYPE = "";

            Console.Write("\nInput a name for your object: ");
            OBJECT_NAME = Console.ReadLine();

            Console.Write("\nSelect an Object Type:\n");

            for (int i = 0; i < 3; i++) {
                Console.Write(objTypes[i] + "\n");
            }

            OBJECT_TYPE = Console.ReadLine();

            switch(OBJECT_TYPE) {}

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