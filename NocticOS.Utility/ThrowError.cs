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
                    break;
                
                // Operation Cancelled
                case "oc":
                    break;

                // Missing Parameters
                case "mp":
                    break;
            }
        }
    }
}