using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak10
{
    public class Epson : IPrinterWindows
    {
        public void Print(Printer printer)
        {

            Console.WriteLine("Dimensi dislay Epson: 10*11");
            Console.WriteLine("Printer Epson printing...");
        }
    }
}
