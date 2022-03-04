using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Utility;

namespace NocticOS.Lib
{
    public class Options
    {
        // ThrowError throwError = new ThrowError();
        Throw emptyThrow = new Throw();
        
        public void PushOptions(string? cmd, string[] setArr, int? setLength) {
            if (!String.IsNullOrEmpty(cmd)) {
                for (int i = 0; i < setLength; i++) {
                    Console.Write(cmd + " " + setArr[i] + "\n");
                }
            } else {
                emptyThrow.CreateThrow("et",
                    "ERROR: Empty Command name.",
                    true
                );
            }
        }
    }
}