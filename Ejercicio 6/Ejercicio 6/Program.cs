using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Coches c1 = new Coches();
            c1.PrintInfo();
            c1.SetMarca("Lamborghini");
            c1.SetModelo("Murcielago");
            c1.SetClase("Fucker");
            Console.WriteLine(" ");
            c1.PrintInfo();
            Console.ReadLine();

            consumo co1 = new consumo();
            co1.PrintInfo();
            Console.ReadLine();


        }
    }
}
