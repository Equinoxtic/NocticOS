using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class ThrowError
    {
        /*
        * ev - Empty Value
        * oc - Operation Cancelled
        * mp - Missing Parameters
        */
        public void DoThrow(string currentType)
        {
            switch(currentType)
            {
                // Empty Value
                case "ev":
                    EmptyValThrow();
                    break;
                
                // Operation Cancelled
                case "oc":
                    break;

                // Missing Parameters
                case "mp":
                    break;
            }
        }

        static void EmptyValThrow(bool insertNewLine)
        {
            if (insertNewLine) {
                Console.Write("\n");
            }
            Console.Write("Empty Value, please try again.\n");
        }

        static void OperationCancelledThrow(bool insertNewLine)
        {
            if (insertNewLine) {
                Console.Write("\n");
            }
            Console.Write("Operation Cancelled.");
        }
    }
}