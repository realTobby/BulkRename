using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Path to the folder:");
            var folderPath = Console.ReadLine();

            Console.WriteLine("Starting count:");
            var count = Convert.ToInt32(Console.ReadLine());

            var files = System.IO.Directory.GetFiles(folderPath);

            string destinationFolder = folderPath + "//renamedFiles";
            System.IO.Directory.CreateDirectory(destinationFolder);

            foreach(var item in files)
            {
                count++;
                System.IO.File.Copy(item, destinationFolder + "//" + count + ".png");



            }
        }
    }
}
