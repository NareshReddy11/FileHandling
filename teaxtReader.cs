using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class teaxtReader
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("F:\\FileHandling\\d.txt"))
            {
                // string line= tr.ReadLine();
                //  Console.WriteLine(line);
                Console.WriteLine(tr.ReadLine());
            }
        }
    }
}
