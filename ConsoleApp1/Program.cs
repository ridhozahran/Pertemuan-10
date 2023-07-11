using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Ridho Zahran Pratama";
            Person1.Age = 19;
            Person1.InfoPerson();
            Console.WriteLine();

            // Inheritance
            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Zahran";
            Karyawan1.Age = 28;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Sekertaris", "6HC231");

            Console.ReadLine();
        }

    }
}
