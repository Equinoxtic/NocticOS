using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class DateDisplay
    {
        Program program = new Program();

        public void DisplayTime()
        {
            Console.Write("\n");

            Console.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));

            program.DoReturn(false);
        }

        public void DisplayDate()
        {
            Console.Write("\n");

            Console.WriteLine("Date: " + DateTime.Now.ToShortDateString());

            program.DoReturn(false);
        }

        public void DisplayTimeAndDate()
        {
            Console.Write("\n");

            Console.WriteLine(DateTime.Now.ToString("dddd, MMMM dd yyyy, hh:mm:ss"));

            program.DoReturn(false);
        }

        public void DisplayMonth()
        {
            Console.Write("\n");

            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            program.DoReturn(false);
        }


        public void DisplayYear()
        {
            Console.Write("\n");

            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            program.DoReturn(false);
        }
    }
}