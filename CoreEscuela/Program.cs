using System;

namespace CoreEscuela
{
    internal class Escuela
    {
        public int AñoFundacion;
        public string Ceo;
        public string Direccion;
        public string Nombre;

        public void Timbrar()
        {
            Console.Beep(987, 1000); //Si
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Escuela miEscuela = new Escuela();

            miEscuela.Nombre = "Platzi Academy";
            miEscuela.Direccion = "Cr 9 calle 72";
            miEscuela.AñoFundacion = 2012;
            miEscuela.Ceo = "Fredy Vega";

            Console.WriteLine("TIMBRAR");

            miEscuela.Timbrar();
        }
    }
}