using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Pregunta
    {
        private string pregunta;
        private List<RespuestaPosible> respuesta;

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
    }
}
