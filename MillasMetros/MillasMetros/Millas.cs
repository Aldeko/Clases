using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillasMetros
{
    class Millas
    {
        private double millas;
        private double metros;

        public Millas()
        {

        }
        public Millas(double millas)
        {
            this.millas = millas;
            
        }

        public double Metros(double millas)
        {
            return millas * 1852;
        }
        public double Kilometros(double metros)
        {
            return metros / 1000;
        }
        
    }
}
