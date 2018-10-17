using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class fileStrem2
    {
        static void Main(string[] args)
        {
            FileStream s = new FileStream("F:\\FileHandling\\a.txt", FileMode.OpenOrCreate);
            for (int i = 60; i <= 120; i++)
            {
                s.WriteByte((byte)i);
            }
            Console.WriteLine("create the file");
            s.Close();
           
        }
        
    }
}