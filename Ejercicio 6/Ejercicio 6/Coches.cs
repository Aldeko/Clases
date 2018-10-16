using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Coches
    {

        private string marca;
        private string modelo;
        private string clase;

        public Coches()
        {
            this.marca = "Audi";
            this.modelo = "A3";
            this.clase = "Sportback";

        }

        public Coches (string marca, string modelo, string clase)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.clase = clase;
        }

        //GETTERS y SETTERS

        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetClase()
        {
            return clase;
        }
        public void SetClase(string clase)
        {
            this.clase = clase;
        }

        //METODOS

        public void PrintInfo()
        {
            Console.WriteLine("Marca " + marca + " modelo " + modelo + " Clase " + clase);
        }


    }
}
