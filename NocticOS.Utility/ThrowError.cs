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

        static void EmptyValThrow()
        {
            Console.WriteLine("\nEmpty Value, please try again.");
        }
    }
}