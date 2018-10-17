using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class FileInfo1
    {
        static void Main(string[] args)
        {
            try
            {
                string file = "F:\\FileHandling\\naresh.txt";
                FileInfo str = new FileInfo(file);
                str.Create();
                Console.WriteLine("file is created");
            }
            catch(IOException e)
            {
                Console.WriteLine("somthing went to wroung" + e);
            }

        }
    }
}
