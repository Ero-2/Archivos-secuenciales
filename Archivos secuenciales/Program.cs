using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Archivos_secuenciales
{
    internal class Program
    {
        static void WriteToSequentialFile(string filePath, string data)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                byte[] dataBytes = System.Text.Encoding.UTF8.GetBytes(data);
                fs.Write(dataBytes, 0, dataBytes.Length);
                Console.WriteLine($"Data '{data}' has been written to the file '{filePath}'.");
            }
        }

        static void ReadFromSequentialFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string fileContent = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"File '{filePath}':\n{fileContent}");
            }
        }
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\erick garcia\\Desktop\\file.txt";
            // Write data to the file
            WriteToSequentialFile(filePath, "Hello, World!");
            // Read data from the file
            ReadFromSequentialFile(filePath);
            Console.ReadLine();

        }
    }
}
