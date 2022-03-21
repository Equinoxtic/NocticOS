using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class DateDisplay
    {
        Program program = new Program();

        public void DisplaySwitch(string dateTime)
        {
            string prefix = "";

            switch(dateTime) {
                case "time":
                    prefix = "HH:mm:ss";
                    break;
                case "date":
                    prefix = DateTime.Now.ToShortDateString();
                    break;
                case "time-and-date":
                    prefix = "dddd, MMMM dd yyyy, HH:mm:ss";
                    break;
                case "month":
                    prefix = "MMMM";
                    break;
                case "year":
                    prefix = "yyyy";
                    break;
            }

            Console.Write("\n");

            Console.WriteLine(DateTime.Now.ToString(prefix));

            program.DoReturn(false);
        }
    }
}