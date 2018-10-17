using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class streammulReader
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\FileHandling\\c.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            string line = "";
            while((line=s.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
