using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Encuesta
    {
        private string descripcion;
        private List<Pregunta> pregunta;

        public Encuesta(string descripcion, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.pregunta = pregunta;
        }

        public string Descripcion 
        { 
            get => descripcion;
            set => descripcion = value;
        }
        public List<Pregunta> Pregunta 
        {   get => pregunta;
            set => pregunta = value;
        }

        public string getDescripcionEncuesta()
        {
            return this.descripcion;
        }
       
    }
}
