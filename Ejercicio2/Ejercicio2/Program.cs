using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            numero.SetNumero(30);
            Numero otroNumero = new Numero(30);
        }
    }
}
