using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Lib
{
    public class Options
    {
        ThrowError throwError = new ThrowError();
        
        public void PushOptions(string? daName, int? setLength, string[] setArr, string[] setArrTag) {
            string[] curArr = setArr;
            string[] curArrTags = setArrTag;
            if (!String.IsNullOrEmpty(daName)) {
                for (int i = 0; i < setLength; i++) {
                    Console.Write(curArrTags[i] + curArr[i] + "\n");
                }
            } else {
                throwError.CustomThrow("ERROR: Name is empty.\n", true);
            }
        }
    }
}