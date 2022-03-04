using System;
using System.Linq;
using System.Threading.Tasks;
using NocticOS.Lib;

namespace NocticOS.Templates.CS_Class_Templates
{
    public class SelectionTemplateNew
    {
        public void SelectionName()
        {
            Options options = new Options();
            string[] ls = {};
            options.PushOptions("list", ls, ls.Length);
        }
    }
}