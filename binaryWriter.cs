using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class binaryWriter
    {
        static void Main(string[] args)
        {
            string filenem = "f:\\FileHandling\\f.txt";
            using (BinaryWriter tr = new BinaryWriter(File.Open(filenem, FileMode.Create)))
            {
                tr.Write(4.5);
                tr.Write("naresh reddy");
                tr.Write(true);
            }
            Console.WriteLine("file is created");
        }
    }
}
