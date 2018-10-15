using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finanzas f1 = new Finanzas(0.99);
            f1.SetCambio(0.92);
            
            Console.WriteLine("5 euros son: " + f1.EurosToDolares(40) + "  dolares");
            Console.WriteLine("5 dolares son: " + f1.DolaresToEuros(50) + "dolares");
            Console.ReadLine();

           
        }
    }
}
