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
        
        public void PushOptions(string[] setArr, int? setLength, bool shouldNewLine = true, string? cmd="") {
            if (!String.IsNullOrEmpty(cmd)) {
                for (int i = 0; i < setLength; i++) {
                    Console.Write(cmd + " " + setArr[i] + "\n");
                }
            } else {
                for (int i = 0; i < setLength; i++) {
                    if (shouldNewLine) {
                        Console.Write(setArr[i] + "\n");
                    } else {
                        Console.Write(setArr[i]);
                    }
                }
            }
        }
    }
}