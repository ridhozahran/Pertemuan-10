using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Canon");
            Console.WriteLine("2. Epson");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer[1...3]:");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            printer.jenis = pilihan;

            IPrinterWindows print;

            if (printer.jenis == 1)
                print = new Canon();
            else if (printer.jenis == 2)
                print = new Epson();
            else
                print = new Laserjett();

            print.Print(printer);
            Console.ReadLine();
        }
    }
}
