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
        public void ThrowSwitch(string currentType, bool shouldNewLine)
        {
            switch(currentType)
            {
                // Empty Value
                case "ev":
                    EmptyValThrow(shouldNewLine);
                    break;
                
                // Operation Cancelled
                case "oc":
                    OperationCancelledThrow(shouldNewLine);
                    break;

                // Missing Parameters
                case "mp":
                    MissingParamsThrow(shouldNewLine);
                    break;
            }
        }

        public void EmptyValThrow(bool insertNewLine)
        {
            if (insertNewLine) {
                Console.Write("\n");
            }
            Console.Write("Empty Value, please try again.\n");
        }

        public void OperationCancelledThrow(bool insertNewLine)
        {
            if (insertNewLine) {
                Console.Write("\n");
            }
            Console.Write("Operation Cancelled.\n");
        }

        public void MissingParamsThrow(bool insertNewLine)
        {
            if (insertNewLine) {
                Console.Write("\n");
            }
            Console.Write("Missing Parameters, please enter the following:\n");
        }
    }
}