using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo.Dll.Lib
{
    public class DllLibClass
    {
        public DllLibClass()
        {
            // 長的命名空間使用短的命名空間不用Using
            var dllClass = new DllClass();
            var folderDllClass = new FolderDllClass();
        }
    }
}
