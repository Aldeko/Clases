using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Finanzas
    {
        private double cambio;

        //CONSTRUCTOR POR DEFECTO
        public Finanzas()
        {
            this.cambio = 0.92;

        }

        public Finanzas(double cambio)
        {
            this.cambio = cambio;
        }

        public double GetCambio()
        {

            return cambio;

        }
        public void SetCambio(double cambio)
        {

            this.cambio = cambio;

        }
            //METODOS
        public double DolaresToEuros(double cantidad)
        {
        return cantidad * cambio;
        }
        public double EurosToDolares(double cantidad)
        {
            return cantidad / cambio;
        }

    }
}
