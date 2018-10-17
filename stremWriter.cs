using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class stremWriter
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("F:\\FileHandling\\k.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.Write("buz runtime is a it company.it was completed 8 years");
            s.Close();
            f.Close();
            Console.WriteLine("file created see the f drive");

        }
    }
}
