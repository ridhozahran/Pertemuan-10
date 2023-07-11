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
            Person1.Name = "Rahmat Fauzi Abu Bakar";
            Person1.Age = 20;
            Person1.InfoPerson();
            Console.WriteLine();

            // Inheritance
            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Fauzi";
            Karyawan1.Age = 28;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Sekertaris", "6HC231");

            Console.ReadLine();
        }

    }
}