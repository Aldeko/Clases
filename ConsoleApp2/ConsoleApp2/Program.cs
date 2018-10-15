using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool orbita;
            Satelite s1 = new Satelite(100, 1000, 10000);
            s1.PrintPosicion();
            s1.SetPosicion(10, 20, 30);
            s1.PrintPosicion();
            s1.EnOrbita();
            orbita = s1.EnOrbita();
            if (orbita)
            {
                Console.WriteLine("Esta en Orbita");
            }
            else
            {
                Console.WriteLine("No esta en Orbita");
            }
            Console.ReadLine();
        }
    }
}
