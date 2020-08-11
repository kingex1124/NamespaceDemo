using NamespaceDemo.Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo.Help.Lib
{
    public class HelpLibClass
    {
        public HelpLibClass()
        {
            // 長的命名空間使用短的命名空間不用Using
            var helpClass = new HelpClass();

            // .後面的命名空間不同要using
            var dllClass = new DllClass();
            var folderDllClass = new FolderDllClass();
            var origin = new Program();
        }
    }
}
