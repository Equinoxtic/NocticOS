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

            Console.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));

            Program.DoReturn(false);
        }

        public void DisplayDate()
        {
            Console.Write("\n");

            Console.WriteLine("Date: " + DateTime.Now.ToShortDateString());

            Program.DoReturn(false);
        }
            Program.DoReturn(false);
        }
    }
}