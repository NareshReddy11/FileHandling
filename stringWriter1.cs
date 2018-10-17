using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class stringWriter1
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint \n" +
              "It is nice site. \n" +
              "It provides technical tutor";
            StringBuilder sb = new StringBuilder();
            StringWriter writer = new StringWriter(sb);
            writer.WriteLine(text);
            writer.Flush();//clear buffers and return only bufferreader values
            writer.Close();
            StringReader reader = new StringReader(sb.ToString());
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine()+","+reader.Peek());
            }
        }
    }
}