using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillasMetros
{
    class Program
    {
        static void Main(string[] args)
        {
            double millas = 25;
            double metros;
            Millas m1 = new Millas(millas);
            Console.WriteLine(millas + " millas son" + m1.Metros(millas) + " metros");
            Console.WriteLine(m1.Metros(millas) + " metros son" + m1.Kilometros(m1.Metros(millas)) + " Kilometros");

            Console.ReadLine();
           

        }
    }
}
