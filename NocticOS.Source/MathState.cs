using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Source
{
    public class MathState
    {
        public void OpenState()
        {
            ProgramReturn Program = new ProgramReturn();

            string[] OperList = {
                "[add] Addition |",
                "[subtract] Subtraction |",
                "[multiply] Multiplication |",
                "[divide] Division\n"
            };

            Program.DoReturn(false);
        }
    }
}