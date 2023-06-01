using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Pregunta
    {
        public string pregunta;
        public List<RespuestaPosible> respuesta;
        public Encuesta Encuesta { get; set; }

        public Pregunta(string pregunta, List<RespuestaPosible> respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }

        public string SetGetPregunta 
        {
            get => pregunta;
            set => pregunta = value;
        }
        public List<RespuestaPosible> RespuestaPosible 

        {   get => respuesta;
            set => respuesta = value;
        }
        public string getDescripcion()
        {
            return this.pregunta;
        }
        public string getEncuesta()
        {
            return this.Encuesta.getDescripcionEncuesta();
        }
    }
}
