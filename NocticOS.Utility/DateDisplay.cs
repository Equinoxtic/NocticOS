using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class DateDisplay
    {
        ProgramReturn Program = new ProgramReturn();
        public void DisplayTime()
        {
            Console.Write("\n");

            System.DateTime.Now.ToString("HH:mm:ss");

            Program.DoReturn(false);
        }
    }
}