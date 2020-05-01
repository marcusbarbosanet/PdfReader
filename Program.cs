using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfReaderEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = PdfReaderClass.toString("File1.pdf");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
