using System;
using System.Linq;
using System.Threading.Tasks;

namespace NocticOS.Utility
{
    public class StandardMath
    {
        public void NocticMath(string oper, int a, int b)
        {   
            switch(oper)
            {
                case "add": Console.WriteLine(a+b); break;
                case "subtract": Console.WriteLine(a-b); break;
                case "multiply": Console.WriteLine(a*b); break;
                case "divide" : Console.WriteLine(a/b); break;
            }
        }
    }
}