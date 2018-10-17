using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileHandling
{
    class binaryReader1
    {
        static void Main(string[] args)
        {
            binaryWriter();
            binaryReader();
        }
        static void binaryWriter()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("F:\\FileHandling\\e.txt", FileMode.Create)))
            {
                writer.Write(8.4);
                writer.Write("naresh");
                writer.Write(true);
            }
        }
        static void binaryReader()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("F:\\FileHandling\\e.txt", FileMode.Open)))
            {
                Console.WriteLine(reader.ReadDouble());
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadBoolean());
            }
        }
    }
}
