using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class TextReaderMul
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("F:\\FileHandling\\d.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}
