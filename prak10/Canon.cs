using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak10
{
    public class Canon : IPrinterWindows
    {
        public void Print(Printer printer)
        {
            Console.WriteLine("Dimensi Display Printer Canon: 9.5*12");
                Console.WriteLine("Printer Canon printing...");
        }
    }
}
