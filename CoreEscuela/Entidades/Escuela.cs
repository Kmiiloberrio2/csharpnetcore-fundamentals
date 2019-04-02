using System;

namespace CoreEscuela.Entidades
{
    internal class Escuela
    {
        private string _nombre;

        public string Nombre
        {
            get { return $"Copia:{_nombre}"; }
            set { _nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }


        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);


        public void Timbrar()
        {
            Console.Beep(987, 1000); //Si
        }

        public override string ToString()
        {
            return $"nombre: {Nombre}  tipo: {TipoEscuela} \npais: {Pais} ciudad: {Ciudad}";
        }
    }
}