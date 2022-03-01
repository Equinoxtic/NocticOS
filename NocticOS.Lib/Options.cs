using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Lib
{
    public class Options
    {
        ThrowError throwError = new ThrowError();
        
        public void PushOptions(string? daName, int? setLength, string[] setArrTag, string[] setArr) {
            if (!String.IsNullOrEmpty(daName)) {
                for (int i = 0; i < setLength; i++) {
                    Console.Write(setArrTag[i] + setArr[i] + "\n");
                }
            } else {
                throwError.CustomThrow("ERROR: Name is empty.\n", true);
            }
        }
    }
}