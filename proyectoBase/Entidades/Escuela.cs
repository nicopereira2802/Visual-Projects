using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Escuela
    {
        // Propiedades de la escuela
        public string Nombre { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        // Constructor
        public Escuela(string nombre)
        {
            Nombre = nombre;
            Estudiantes = new List<Estudiante>();
        }

        // Método para agregar un estudiante a la escuela
        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }
    }
}
