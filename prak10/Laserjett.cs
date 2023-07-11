using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak10
{
    public class Laserjett : IPrinterWindows
    {
        public void Print(Printer printer)
        {

            Console.WriteLine("Dimensi display Printer LaserJet: 12*12");
            Console.WriteLine("Printer LaserJet printing...");
        }
    }
}
