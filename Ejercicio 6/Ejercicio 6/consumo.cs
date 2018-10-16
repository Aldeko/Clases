using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class consumo
    {
        private double kms, litros, vmed;
        
        private string tipoComb;

        const double GASOLINA95 =1.14;
        const double GASOLINA98 =1.25;
        const double DIESEL = 1.04;       


        public consumo(double kms, double litros, double vmed, string tipoComb)
        {
            this.kms = kms;
            this.litros = litros;
            this.vmed = vmed;
            this.tipoComb = tipoComb;

        }
        public consumo ()
        {
            kms = 100;
            litros = 10;
            vmed = 110;
            tipoComb = "GASOLINA 98";
        }

        public double GetKms()
        {
            return kms;
        }
        public void SetKms(double kms)
        {
            this.kms = kms;
        }
        public double Getlitros()
        {
            return litros;
        }
        public void Setlitros(double litros)
        {
            this.litros = litros;
        }
        public double Getvmed()
        {
            return vmed;
        }
        public void Setvmed (double vmed)
        {
            this.vmed = vmed;
        }
        public string GettipoComb()
        {
            return tipoComb;
        }
        public void SettipoComb(string tipoComb)
        {
            this.tipoComb = tipoComb;

        }
        public double GetTiempo()
        {
            return kms / vmed;
        }
        public double GetConsumoMedio()
        {
            return (litros * 100) / kms;
        }
        public double ConsumoEuros()
        {
            switch (tipoComb.ToUpper())
            {
                case "GASOLINA 95":
                    return GASOLINA95 * GetConsumoMedio();

                case "GASOLINA 98":
                    return GASOLINA98 * GetConsumoMedio();
                case "DIESEL":
                    return DIESEL * GetConsumoMedio();
                default:
                    Console.WriteLine("No es correcto");
                    Console.ReadLine();
                    return 0;
            }

          
        }
        public void PrintInfo()
        {
            Console.WriteLine("Consumo" + GetConsumoMedio());
        }


    }
}
