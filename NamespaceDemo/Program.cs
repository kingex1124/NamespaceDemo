using NamespaceDemo.Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 短的命名空間使用長的命名空間要Using
            var dllClass = new DllClass();
            var folderDllClass = new FolderDllClass();
        }
    }
}
