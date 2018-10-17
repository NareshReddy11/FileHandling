using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class directory1
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("f:\\india");
            // dir.Delete();
            if (dir.Exists)
            {
                Console.WriteLine("directory alredy exits");
                return;
            }
            Console.WriteLine("dir created");
            dir.Create();

        }
    }
}