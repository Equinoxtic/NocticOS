using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Lib
{
    public class WIPThrow
    {
        public void ThrowWIP(string wipkey, bool donewline) {
            if (!String.IsNullOrEmpty(wipkey)) {
                if (donewline) {
                    Console.Write("\n");
                }
                Console.Write("This " + wipkey + " is still a WIP.");
            }
        }
    }
}