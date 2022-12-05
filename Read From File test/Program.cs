using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_From_File_test
{
    public class FileNotFoundException : System.IO.IOException { }
    public static class File { }
    internal class Program
    {
        static void Main(string[] args)
        {
            String text;
            try
            {
                text = System.IO.File.ReadAllText("Test.txt");
                Console.WriteLine(text);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
