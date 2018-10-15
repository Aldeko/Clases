using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Numero
    {
        private int entero;

        //CONSTRUCTOR POR DEFECTO

        public Numero()
        {
            this.entero = 0;
        }
        public Numero(int entero)
        {
            this.entero = entero;
        }

        
        public void SetNumero(int entero)
        {
            this.entero = entero;
        }
        public int GetNumero()
        {
            return this.entero;
        }

        //METODO aniade

        public void aniade(int entero)
        {
            this.entero = this.entero + 1;
        }

        //METODO Resta

        public void resta(int entero)
        {
            this.entero = this.entero - 1;
        }

        //METODO GetValor

        public int getValor(int entero)
        {
            return this.entero;
        }

        //METODO getDoble

        public int getDoble (int entero)
        {
            //return this.entero = this.entero * 2; Multiplica el valor por dos y guarda ese valor
            return this.entero * 2;
        }

        //METODO getTriple
        public int GetTriple (int entero)

        {
            return this.entero * 3;
        }

        //METODO setNumero

        public void SetNumero2(int entero)
        {
            this.entero = 5;
        }
        
    }
}
