using CoreEscuela.Entidades;
using System;

namespace CoreEscuela
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Pascual Bravo", 1984, TiposEscuela.PreEscolar, ciudad: "Medellin");

            Console.WriteLine(escuela);
        }
    }
}