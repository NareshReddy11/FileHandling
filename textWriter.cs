using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class textWriter
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("F:\\FileHandling\\d.txt"))
            {
                writer.WriteLine("i am naresh from ap");
                writer.WriteLine("c# is a very easy programing language");
            }
            Console.WriteLine("file successfully created");
        }
    }
}
