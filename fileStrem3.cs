using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class fileStrem3
    {
        static void Main(string[] args)
        { 
                FileStream ss = new FileStream("F:\\FileHandling\\a.txt", FileMode.OpenOrCreate);
                int i = 0;
                while ((i = ss.ReadByte()) != -1)
                {
                    Console.Write((char)i);
                }
            ss.Close();
        }
    }
}
