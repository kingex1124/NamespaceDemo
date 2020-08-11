using NamespaceDemo.Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo.Help
{
    public class HelpClass
    {
        public HelpClass()
        {
            // .後面的命名空間不同也要using
            var dllClass = new DllClass();
        }
    }
}
