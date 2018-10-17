using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class FileStream1
    {
        static void Main(string[] args)
        {
            FileStream N = new FileStream("F:\\FileHandling\\a.txt", FileMode.OpenOrCreate);
            N.WriteByte(65);
            N.Close();
            
        }
    }
}
