
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah fruit = new KodeBuah();

            string buahBaru = fruit.getKodeBuah(KodeBuah.buah.Kurma);
            Console.WriteLine(buahBaru);
        }
    }

}
