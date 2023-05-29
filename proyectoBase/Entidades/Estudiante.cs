using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Estudiante
    {
        // Propiedades del estudiante
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }

}
