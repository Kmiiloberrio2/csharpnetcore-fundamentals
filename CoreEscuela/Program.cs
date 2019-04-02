using CoreEscuela.Entidades;
using System;

namespace CoreEscuela
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Platzi Academy", 2012);

            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            Console.WriteLine(escuela);
        }
    }
}