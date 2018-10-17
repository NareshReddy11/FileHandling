using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class StringReader1
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("ho no yar i am fully happy");
            str.Close();  
            StringReader reader = new StringReader(str.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}