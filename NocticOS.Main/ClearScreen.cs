using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Main
{
    public class ClearScreen
    {
        public void ScreenClear(bool returnToProgram) {
            Program program = new Program();
            System.Console.Clear();
            if (returnToProgram) {
                program.DoReturn(false);
            }
        }
    }
}